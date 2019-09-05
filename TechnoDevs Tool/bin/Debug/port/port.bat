@echo off
setlocal
set CYGWIN=nodosfilewarning

set "aik=%~dp0"
set "bin=%~dp0\android_win_tools"
set "rel=..\android_win_tools"
set "cur=%cd%"
%~d0
cd "%~p0"
if "%~1" == "--help" echo usage: unpackimg.bat ^<recovery.img^> & goto end
if "[%~1]" == "[]" (
  for /f "delims=" %%a in ('dir /b /o *.elf *.img *.sin 2^>nul') do (
    if not "%%a" == "aboot.img" if not "%%a" == "image-new.img" if not "%%a" == "unlokied-new.img" if not "%%a" == "unsigned-new.img" (
      set "img=%%a"
      goto imgset
    )
  )
) else (
  set "img=%~1"
)
:imgset
if "[%img%]" == "[]" goto noargs
if exist "%cur%\%img%" set "img=%cur%\%img%"
call :main "%img%" & exit /b
:main
set attr=%~a1
set dirattr=%attr:~0,1%
if /i "%dirattr%"=="d" goto noargs
set "file=%~dsp1%~nx1"
if not exist "%file%" goto noargs

echo Android Image Kitchen - UnpackImg Script
echo by osm0sis @ xda-developers
echo.

echo Supplied image: %~nx1
echo.

if exist split_img\nul set "noclean=1"
if exist ramdisk\nul set "noclean=1"
if defined noclean (
  echo Removing old work folders and files . . .
  echo.
  call cleanup.bat >nul
)

echo Setting up work folders . . .
echo.
md split_img
if errorlevel == 1 call "%aik%\cleanup.bat" >nul & goto error
md ramdisk
if errorlevel == 1 call "%aik%\cleanup.bat" >nul & goto error

cd split_img
"%bin%"\file -m %rel%\androidbootimg.magic "%file%" | "%bin%"\cut -d: -f2- | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f3 | "%bin%"\cut -d, -f1 > "%~nx1-imgtype"
for /f "delims=" %%a in ('type "%~nx1-imgtype"') do @set "imgtest=%%a"
if "%imgtest%" == "signing" (
  "%bin%"\file -m %rel%\androidbootimg.magic "%file%" | "%bin%"\cut -d: -f2- | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f2 > "%~nx1-sigtype"
  for /f "delims=" %%a in ('type "%~nx1-sigtype"') do @set "sigtype=%%a" & echo Signature with "%%a" type detected, removing . . .
  echo.
)
if "%sigtype%" == "BLOB" (
  copy /b "%file%" . >nul
  "%bin%"\blobunpack "%~nx1" | findstr "Name:" | "%bin%"\cut -d" " -f2 > "%~nx1-blobtype" 2>nul
  move /y "%~nx1.LNX" "%~nx1" >nul 2>&1
  move /y "%~nx1.SOS" "%~nx1" >nul 2>&1
  set "file=%~nx1"
)
if "%sigtype%" == "CHROMEOS" "%bin%"\futility vbutil_kernel --get-vmlinuz "%file%" --vmlinuz-out "%~nx1" & set "file=%~nx1"
if "%sigtype%" == "DHTB" "%bin%"\dd bs=4096 skip=512 iflag=skip_bytes conv=notrunc if="%file%" of="%~nx1" 2>nul & set "file=%~nx1"
if "%sigtype%" == "NOOK" (
  "%bin%"\dd bs=1048576 count=1 conv=notrunc if="%file%" of="%~nx1-master_boot.key" 2>nul
  "%bin%"\dd bs=1048576 skip=1 conv=notrunc if="%file%" of="%~nx1" 2>nul
  set "file=%~nx1"
)
if "%sigtype%" == "NOOKTAB" (
  "%bin%"\dd bs=262144 count=1 conv=notrunc if="%file%" of="%~nx1-master_boot.key" 2>nul
  "%bin%"\dd bs=262144 skip=1 conv=notrunc if="%file%" of="%~nx1" 2>nul
  set "file=%~nx1"
)
if "%sigtype%" == "SIN" (
  "%bin%"\kernel_dump . "%file%" >nul
  move /y "%~nx1."* "%~nx1" >nul 2>&1
  set "file=%~nx1"
  del "%~nx1-sigtype"
)

"%bin%"\file -m %rel%\androidbootimg.magic "%file%" | "%bin%"\cut -d: -f2- | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f3 | "%bin%"\cut -d, -f1 > "%~nx1-imgtype"
for /f "delims=" %%a in ('type "%~nx1-imgtype"') do @set "imgtest=%%a"
if "%imgtest%" == "bootimg" (
  set "imgtest="
  "%bin%"\file -m %rel%\androidbootimg.magic "%file%" | "%bin%"\cut -d: -f2- | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f4 > "%~nx1-imgtype"
  for /f "delims=" %%a in ('type "%~nx1-imgtype"') do (
    if "%%a" == "PXA" set "imgtest=-%%a"
  )
  "%bin%"\file -m %rel%\androidbootimg.magic "%file%" | "%bin%"\cut -d: -f2- | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f2 > "%~nx1-imgtype"
  for /f "delims=" %%a in ('type "%~nx1-imgtype"') do @set "imgtype=%%a"
) else (
  call "%aik%\cleanup.bat" >nul
  echo Unrecognized format.
  goto error
)
set "imgtype=%imgtype%%imgtest%"
echo %imgtype%>"%~nx1-imgtype"
echo Image type: %imgtype%
echo.

if "%imgtype%" == "AOSP" set "supported=1"
if "%imgtype%" == "AOSP-PXA" set "supported=1"
if "%imgtype%" == "ELF" set "supported=1"
if "%imgtype%" == "KRNL" set "supported=1"
if "%imgtype%" == "U-Boot" set "supported=1"
if not defined supported call "%aik%\cleanup.bat" >nul & echo Unsupported format. & goto error

"%bin%"\file -m %rel%\androidbootimg.magic "%file%" | "%bin%"\cut -d: -f2- | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f4 > "%~nx1-lokitype"
for /f "delims=" %%a in ('type "%~nx1-lokitype"') do @set "lokitest=%%a"
if "%lokitest%" == "LOKI" (
  "%bin%"\file -m %rel%\androidbootimg.magic "%file%" | "%bin%"\cut -d: -f2- | "%bin%"\cut -d: -f2 | "%bin%"\cut -d( -f2 | "%bin%"\cut -d^) -f1 > "%~nx1-lokitype"
  for /f "delims=" %%a in ('type "%~nx1-lokitype"') do @echo Loki patch with "%%a" type detected, reverting . . .
  echo.
  echo Warning: A dump of your device's aboot.img is required to re-Loki!
  "%bin%"\loki_tool unlok "%file%" "%~nx1" >nul
  echo.
  set "file=%~nx1"
) else (
  del "%~nx1-lokitype"
)

"%bin%"\tail -n50 "%file%" 2>nul | "%bin%"\file -m %rel%\androidbootimg.magic - | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f2 > "%~nx1-tailtype"
for /f "delims=" %%a in ('type "%~nx1-tailtype"') do @set "tailtype=%%a"
if not "%tailtype%" == "AVB" if not "%tailtype%" == "Bump" if not "%tailtype%" == "SEAndroid" del "%~nx1-tailtype"
if "%tailtype%" == "AVB" (
  "%bin%"\tail -n50 "%file%" 2>nul | "%bin%"\file -m %rel%\androidbootimg.magic - | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f6 > "%~nx1-avbtype"
  echo Signature with "%tailtype%" type detected. & echo.
  move /y "%~nx1-tailtype" "%~nx1-sigtype" >nul
)
if exist "*-tailtype" echo Footer with "%tailtype%" type detected. & echo.

echo Splitting image to "split_img/" . . .
echo.
if "%imgtype%" == "AOSP" "%bin%"\unpackbootimg -i "%file%"
if "%imgtype%" == "AOSP-PXA" "%bin%"\pxa-unpackbootimg -i "%file%"
if "%imgtype%" == "ELF" (
  md elftool_out
  "%bin%"\elftool unpack -i "%file%" -o elftool_out >nul
  move /y elftool_out\header "%~nx1-header" >nul 2>&1
  rd /s /q elftool_out >nul 2>&1
  "%bin%"\unpackelf -i "%file%"
)
if "%imgtype%" == "KRNL" "%bin%"\dd bs=4096 skip=8 iflag=skip_bytes conv=notrunc if="%file%" of="%~nx1-ramdisk.cpio.gz" 2>&1 | "%bin%"\tail -n+3 | "%bin%"\cut -d" " -f1-2
if "%imgtype%" == "U-Boot" (
  "%bin%"\dumpimage -l "%file%"
  "%bin%"\dumpimage -l "%file%" > "%~nx1-header"
  type "%~nx1-header" | findstr "Name:" | "%bin%"\cut -c15- > "%~nx1-name"
  type "%~nx1-header" | findstr "Type:" | "%bin%"\cut -c15- | "%bin%"\cut -d" " -f1 > "%~nx1-arch"
  type "%~nx1-header" | findstr "Type:" | "%bin%"\cut -c15- | "%bin%"\cut -d" " -f2 > "%~nx1-os"
  type "%~nx1-header" | findstr "Type:" | "%bin%"\cut -c15- | "%bin%"\cut -d" " -f3 | "%bin%"\cut -d- -f1 > "%~nx1-type"
  type "%~nx1-header" | findstr "Type:" | "%bin%"\cut -d^( -f2 | "%bin%"\cut -d^) -f1 | "%bin%"\cut -d" " -f1 | "%bin%"\cut -d- -f1 > "%~nx1-comp"
  type "%~nx1-header" | findstr "Address:" | "%bin%"\cut -c15- > "%~nx1-addr"
  type "%~nx1-header" | findstr "Point:" | "%bin%"\cut -c15- > "%~nx1-ep"
  del "%~nx1-header"
  "%bin%"\dumpimage -i "%file%" -p 0 "%~nx1-zImage"
  for /f "delims=" %%a in ('type "%~nx1-type"') do (
    if "%%a" == "Multi" (
      "%bin%"\dumpimage -i "%file%" -p 1 "%~nx1-ramdisk.cpio.gz"
    ) else (
      copy /y nul "%~nx1-ramdisk.cpio.gz" >nul
    )
  )
)
if errorlevel == 1 call "%aik%\cleanup.bat" >nul & goto error
echo.

if "%imgtype%" == "AOSP" (
  for /f "delims=" %%a in ('type "%~nx1-hash"') do (
    if "%%a" == "unknown" echo sha1>"%~nx1-hash" & echo Warning: "unknown" hash type detected; assuming "sha1" type! & echo.
  )
)

"%bin%"\file -m %rel%\androidbootimg.magic *-zImage | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f2 > "%~nx1-mtktest"
for /f "delims=" %%a in ('type "%~nx1-mtktest"') do @set "mtktest=%%a"
if "%mtktest%" == "MTK" (
  set "mtk=1"
  echo MTK header found in zImage, removing . . .
  "%bin%"\dd bs=512 skip=1 conv=notrunc if="%~nx1-zImage" of="tempzimg" 2>nul
  move /y tempzimg "%~nx1-zImage" >nul
)
for /f "delims=" %%a in ('dir /b *-ramdisk*.gz') do @set "ramdiskname=%%a"
"%bin%"\file -m %rel%\androidbootimg.magic "%ramdiskname%" | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f2 > "%~nx1-mtktest"
for /f "delims=" %%a in ('type "%~nx1-mtktest"') do @set "mtktest=%%a"
"%bin%"\file -m %rel%\androidbootimg.magic "%ramdiskname%" | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f4 > "%~nx1-mtktype"
for /f "delims=" %%a in ('type "%~nx1-mtktype"') do @set "mtktype=%%a"
if "%mtktest%" == "MTK" (
  if not defined mtk echo Warning: No MTK header found in zImage! & set "mtk=1"
  echo MTK header found in "%mtktype%" type ramdisk, removing . . .
  "%bin%"\dd bs=512 skip=1 conv=notrunc if="%ramdiskname%" of="temprd" 2>nul
  move /y temprd "%ramdiskname%" >nul
) else (
  if defined mtk (
    if "[%mtktype%]" == "[]" (
      echo Warning: No MTK header found in ramdisk, assuming "rootfs" type!
      echo rootfs>"%~nx1-mtktype"
    )
  ) else (
    del "%~nx1-mtktype"
  )
)
del "%~nx1-mtktest"
if defined mtk echo.

if exist "*-dtb" (
  "%bin%"\file -m %rel%\androidbootimg.magic *-dtb | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f2 > "%~nx1-dtbtype"
  for /f "delims=" %%a in ('type "%~nx1-dtbtype"') do (
    if "%imgtype%" == "ELF" if not "%%a" == "QCDT" if not "%%a" == "ELF" (
      echo Non-QC DTB found, packing zImage and appending . . .
      echo.
      "%bin%"\gzip --no-name -9 "%~nx1-zImage"
      copy /b "%~nx1-zImage.gz"+"%~nx1-dtb" "%~nx1-zImage" >nul
      del *-dtb* *-zImage.gz
    )
  )
)

"%bin%"\file -m %rel%\magic *-ramdisk*.gz | "%bin%"\cut -d: -f2 | "%bin%"\cut -d" " -f2 > "%~nx1-ramdiskcomp"
for /f "delims=" %%a in ('type "%~nx1-ramdiskcomp"') do @set "ramdiskcomp=%%a"
if "%ramdiskcomp%" == "gzip" set "unpackcmd=gzip -dcq" & set "compext=gz"
if "%ramdiskcomp%" == "lzop" set "unpackcmd=lzop -dc" & set "compext=lzo"
if "%ramdiskcomp%" == "lzma" set "unpackcmd=xz -dc" & set "compext=lzma"
if "%ramdiskcomp%" == "xz" set "unpackcmd=xz -dc" & set "compext=xz"
if "%ramdiskcomp%" == "bzip2" set "unpackcmd=bzip2 -dc" & set "compext=bz2"
if "%ramdiskcomp%" == "lz4" set "unpackcmd=lz4 -dcq" & set "compext=lz4"
if "%ramdiskcomp%" == "empty" set "compext=empty"
ren *ramdisk*.gz *ramdisk.cpio.%compext%
cd ..
if "%ramdiskcomp%" == "data" echo Unrecognized format. & goto error

if "%ramdiskcomp%" == "empty" echo Warning: No ramdisk found to be unpacked! & goto nord
echo Unpacking ramdisk to "ramdisk/" . . .
echo.
cd ramdisk
if errorlevel == 1 goto error
echo Compression used: %ramdiskcomp%
if not defined compext echo. & echo Unsupported format. & goto error
"%bin%"\%unpackcmd% "..\split_img\%~nx1-ramdisk.cpio.%compext%" | "%bin%"\cpio -i -d --no-absolute-filenames
if errorlevel == 1 goto error
cd ..
:nord
"%bin%"\chmod -f 755 ramdisk >nul 2>&1
echo.

echo Done!
goto end

:noargs
echo No image file supplied.

:error
echo Error!

:end
echo.
echo %cmdcmdline% | findstr /i pushd >nul
if errorlevel 1 pause
