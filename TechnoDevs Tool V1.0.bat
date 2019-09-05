::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:::                                                    :::
:::           This Tool has coded by Barish            :::
:::                 TechnoDevs.Org                     :::
:::                                                    :::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
@echo off
:START
chcp 857 
cls
title TechnoDevs / GsmTurkey TOOL V1.0
cd "%~dp0"
if exist "%~dp0\bin" SET PATH=%PATH%;"%~dp0\bin"
::------------------------------------------------------------------------------------------------------------------
::Colors
set "[LGREEN]=\033[92m"
set "[LCYAN]=\033[96m"
set "[LRED]=\033[91m"
set "[LMAGENTA]=\033[95m"
set "[LYELLOW]=\033[93m"
set "[WHITE]=\033[0m"
::------------------------------------------------------------------------------------------------------------------
:MAIN_TR
cls
echo( 
echo ******************************************************************
echo ******************************************************************
echo *               %[LCYAN]%TechnoDevs / GsmKulup Tool V1.0 Beta%[WHITE]%             * | cmdcolor
echo *              %[LRED]%Emegimiz Kod Dolu SuperSu Sen Bizi Koru %[WHITE]%          * | cmdcolor
echo *  %[LYELLOW]%            TOOL BARIS MIZRAKLI TARAFINDAN KODLANDI         %[WHITE]%  * | cmdcolor
echo *         %[LBLUE]%Eger Yarida Kesilirse Fastboot'u Yeniden Aciniz.    %[WHITE]%   * | cmdcolor
echo *                   %[LGREEN]%TECHNODEVS.ORG / GSMTURKEY.NET    %[WHITE]%           * | cmdcolor
echo ******************************************************************
echo ******************************************************************
echo(
echo  Ne yapmak istersin
echo(
echo ][*******************************][
echo ][ %[LMAGENTA]%1.  Recovery Islemleri%[WHITE]%        ][ | cmdcolor
echo ][*******************************][
echo ][ %[LYELLOW]%2.  Oem Kilidi Islemleri %[WHITE]%     ][ | cmdcolor
echo ][*******************************][
echo ][ %[LCYAN]%3.  Cihazi FastBoot Mod'a Al%[WHITE]%  ][ | cmdcolor
echo ][*******************************][
echo ][ %[LRED]%4.  Log Islemleri %[WHITE]%            ][ | cmdcolor
echo ][*******************************][
echo ][ %[LMAGENTA]%5.  Rootlu Cihazlar %[WHITE]%          ][ | cmdcolor
echo ][*******************************][
echo ][ %[LYELLOW]%6.  Stock Rom'u Kur %[WHITE]%          ][ | cmdcolor
echo ][*******************************][
echo ][ %[LCYAN]%7.  FastBoot Driver Kur %[WHITE]%      ][ | cmdcolor
echo ][*******************************][
echo ][ %[LRED]%8.  FRP Google Kilidini Sil %[WHITE]%  ][ | cmdcolor
echo ][*******************************][
echo ][ %[LMAGENTA]%9.  Cikis Yap%[WHITE]%                 ][ | cmdcolor
echo ***********************************

echo ***********************************
echo                  %[LCYAN]%TechnoDevs.org%[WHITE]%                     | cmdcolor
echo   %[LRED]%                  Retzh.xyz                   %[WHITE]%   | cmdcolor
set /p option=Seáiminizi yazçn [1,2,3,4,5,6,7,8] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto bir
if /I %option%==2 goto iki
if /I %option%==3 goto fastbootmode
if /I %option%==4 goto logislemleri
if /I %option%==5 goto rootlucihaz
if /I %option%==6 goto stockrom
if /I %option%==7 goto adbdriver2
if /I %option%==8 goto frpsil
if /I %option%==9 goto exit
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:rootlucihaz
cls
echo(
echo %[LRED]%GSMTURKEY.NET.%[WHITE]% | cmdcolor
echo %[LCYAN]%TECHNODEVS.ORG.%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  Cihaz Bilgilerini Oku %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  Cihaza APK Yukle %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  TR Dil Ekle ( Daha Eklenmedi ) %[WHITE]%         | cmdcolor
echo %[LYELLOW]%Sadece ve Sadece %[LRED]% "Root'lu Cihazlarda Deneyiniz." .%[WHITE]% | cmdcolor
set /p option=Seáiminizi yazçn [1,2,3] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto readinfo
if /I %option%==2 goto adbpull
if /I %option%==3 goto start
:adbpull
cls
echo %[LRED]%Ana Dizine .Apk dosyasini atip adini %[LRED]% "tool.apk olarak adini degistirin" .%[WHITE]% | cmdcolor
pause
adb devices
adb install tool.apk
pause
goto start
:readinfo
cls
echo %[LRED]%Android Surumu.%[WHITE]% | cmdcolor
adb shell getprop ro.build.version.release
echo %[LYELLOW]%Kod Adi%[WHITE]% | cmdcolor
adb shell getprop ro.product.device
echo %[LGREEN]%Marka%[WHITE]% | cmdcolor
adb shell getprop ro.product.manufacturer
echo %[LCYAN]%Model%[WHITE]% | cmdcolor
adb shell getprop ro.product.model
echo %[LMAGENTA]%Uretici%[WHITE]% | cmdcolor
adb shell getprop ro.product.brand
echo %[LRED]%Dil ve Ulke%[WHITE]% | cmdcolor
adb shell getprop ro.product.locale
echo %[LYELLOW]%Derleme Kodu%[WHITE]% | cmdcolor
adb shell getprop ro.build.id
echo %[LRED]%Sdk Numarasi%[WHITE]% | cmdcolor
adb shell getprop ro.build.version.sdk
echo %[LCYAN]%Code Version'lar%[WHITE]% | cmdcolor
adb shell getprop ro.build.version.codename
adb shell getprop ro.build.version.all_codenames
echo %[LYELLOW]%Guvenlik Yamasi Tarihi%[WHITE]% | cmdcolor
adb shell getprop ro.build.version.security_patch
echo %[LRED]%Dil ve Ulke%[WHITE]% | cmdcolor
adb shell getprop ro.product.locale
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:exit
cls
echo %[LGREEN]%Bu Tool Baris MIZRAKLI tarafindan kodlandi%[WHITE]% | cmdcolor
echo %[LCYAN]%TechnoDevs.Org.%[WHITE]% | cmdcolor
echo %[LYELLOW]%GsmTurkey.Net.%[WHITE]% | cmdcolor
echo %[LRED]%Retzh.Xyz%[WHITE]% | cmdcolor
echo %[LBLUE]%Bizi Tercih Ettiginiz Icin Tesekkurler.%[WHITE]% | cmdcolor
pause
exit
echo(
echo %[LRED]%%option% geáerli bir seáenek deßil. LÅtfen tekrar deneyin! %[WHITE]% | cmdcolor
pause
goto MAIN_TR
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:bir
cls
echo(
echo %[LRED]%GSMTURKEY.NET.%[WHITE]% | cmdcolor
echo %[LCYAN]%TECHNODEVS.ORG.%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  Recovery Tek Seferlik Yukle%[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  Recovery Kalici Yukle%[WHITE]%         | cmdcolor
echo     %[LGREEN]%3.  Ust Menuye Git%[WHITE]%         | cmdcolor
echo %[LYELLOW]%Recovery'i Ana Dizine Ekleyiniz. Adini %[LRED]% "recovery.img Yapiniz" .%[WHITE]% | cmdcolor
set /p option=Seáiminizi yazçn [1,2,3] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto recoverytek
if /I %option%==2 goto recoverykalici
if /I %option%==3 goto menu
:recoverytek
cls
echo %[LYELLOW]%Recovery'i Tek Seferlik Yuklemeyi Sectiniz.%[WHITE]% | cmdcolor
fastboot devices
fastboot boot recovery.img
pause
goto menu
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:recoverykalici
cls
fastboot devices
echo %[LYELLOW]%Eski Recovery Siliniyor.%[WHITE]% | cmdcolor
fastboot erase recovery
cls
echo %[LRED]%Recovery Kalici olarak yukleniyor.%[WHITE]% | cmdcolor
cls
fastboot flash recovery recovery.img
cls
echo %[LCYAN]%Recovery Basarili bir sekilde yuklendi..%[WHITE]% | cmdcolor
echo  %[LMAGENTA]%1.  Recovery Acilsin %[WHITE]%        | cmdcolor
echo  %[LMAGENTA]%2.  Kendim Hallederim. %[WHITE]%         | cmdcolor
set/p input=Sec:
if /I %option%==1 goto evet
if /I %option%==2 goto hayir
:evet
cls
fastboot boot recovery.img
pause
:hayir
cls
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:menu
cls
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:iki
cls
echo  %[LMAGENTA]%1.  Oem Kilidini Ac %[WHITE]%         | cmdcolor
echo  %[LYELLOW]%2.  Oem Kilidini Kapat %[WHITE]%         | cmdcolor
set /p option=Seáiminizi yazçn [1,2] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto ac
if /I %option%==2 goto kapat
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:ac
cls
echo %[LRED]%Ayarlardan Gelistirici Seceneklerinden OEM Kilidini Acma ve USB Hata Ayiklama Modunu Acin..%[WHITE]% | cmdcolor
echo %[LBLUE]%Stock Oem Kilidi Aciliyor...%[WHITE]% | cmdcolor
fastboot oem unlock-go
echo %[LCYAN]%Basarili bir sekilde acildi.%[WHITE]% | cmdcolor
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:kapat
cls
echo %[LCYAN]%Dikkat ! Kapatmadan once stock recovery kurmak ZORUNDASINIZ. AKSI HALDE CIHAZINIZ KOTU DURUMA DUSER%[WHITE]% | cmdcolor
echo  %[LBLUE]%1.  Stock Recovery Kurulu Degil %[WHITE]%         | cmdcolor
echo  %[LGREEN]%2.  Stock Recovery Kurulu %[WHITE]%         | cmdcolor
set /p option=Seáiminizi yazçn [1,2] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto bir
if /I %option%==2 goto 3
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:3
cls
fastboot oem lock
echo %[LCYAN]%OEM Kilidi Kapatildi%[WHITE]% | cmdcolor
echo  %[LBLUE]%1.  Cihazimi Ac %[WHITE]%         | cmdcolor
echo  %[LBLUE]%2.  Ana Menuye Don %[WHITE]%         | cmdcolor
set /p option=Seáiminizi yazçn [1,2] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto cihaziac
if /I %option%==2 goto menu
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:cihaziac
cls
fastboot reboot
pause
goto menu
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:fastbootmode
cls
echo %[LCYAN]%Cihaz Adb Bagli olmak zorundadir%[WHITE]% | cmdcolor
echo %[LYELLOW]%Adb Driverleri kurulu olsun.%[WHITE]% | cmdcolor
echo %[LRED]%Usb Baglayin. Yalnizca Sarj Mode olsun.%[WHITE]% | cmdcolor
echo %[LBLUE]%Her Sey hazir ise:%[WHITE]% | cmdcolor
pause
adb reboot bootloader
pause
goto menu
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:logislemleri
cls
echo %[LCYAN]%2 Adet Log Alabilirsiniz%[WHITE]% | cmdcolor
echo %[LBLUE]%1.  Adb LogCat %[WHITE]%         | cmdcolor
echo %[LBLUE]%2.  Adb Dmesg Logu %[WHITE]%         | cmdcolor
set /p option=Seáiminizi yazçn [1,2] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto adblogcat
if /I %option%==2 goto adbdmesg
pause
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:adblogcat
cls
echo %[LCYAN]% Cihaz Adb Bagli olmak zorundadir%[WHITE]% | cmdcolor
echo %[LYELLOW]%Adb Driverleri kurulu olsun.%[WHITE]% | cmdcolor
echo %[LRED]%Adb Driverleri kurulu olsun..%[WHITE]% | cmdcolor
echo %[LBLUE]%Usb Baglayin. Yalnizca Sarj Mode olsun.:%[WHITE]% | cmdcolor
echo %[LCYAN]% Tool'u yonetici olarak calistirdiginizdan emin iseniz:%[WHITE]% | cmdcolor
echo %[LYELLOW]%Her Sey hazir ise:.%[WHITE]% | cmdcolor
pause
echo %[LBLUE]%Log alacak. Bunun sonu gelmez. 2 Dakika Sonra Kapat.%[WHITE]% | cmdcolor
adb logcat > logcat.txt
pause
goto menu
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:adbdmesg
cls
echo %[LCYAN]% Cihaz Adb Bagli olmak zorundadir%[WHITE]% | cmdcolor
echo %[LYELLOW]%Adb Driverleri kurulu olsun.%[WHITE]% | cmdcolor
echo %[LRED]%Adb Driverleri kurulu olsun..%[WHITE]% | cmdcolor
echo %[LBLUE]%Usb Baglayin. Yalnizca Sarj Mode olsun.:%[WHITE]% | cmdcolor
echo %[LCYAN]% Tool'u yonetici olarak calistirdiginizdan emin iseniz:%[WHITE]% | cmdcolor
echo %[LYELLOW]%Her Sey hazir ise:.%[WHITE]% | cmdcolor
echo %[LBLUE]%Log alacak. Bunun sonu gelmez. 2 Dakika Sonra Kapat.%[WHITE]% | cmdcolor
pause
adb shell dmesg > dmesg.txt
pause
goto menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:stockrom
cls
echo %[LCYAN]%Betadir Stock Rom Eklenmedi..%[WHITE]% | cmdcolor
echo %[LCYAN]% Stock Rom Aciliyor.%[WHITE]% | cmdcolor
echo %[LYELLOW]%Uzun Surebilir Bekleyin.%[WHITE]% | cmdcolor
echo %[LRED]%Adb Driverleri kurulu olsun..%[WHITE]% | cmdcolor
pause
cls
start FastBootStockRom.exe
pause
goto menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:adbdriver2
cls
echo  %[LMAGENTA]%1. 32 Bit Driver %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]%2. 64 Bit Driver %[WHITE]%         | cmdcolor
set /p option=Seáiminizi yazçn [1,2] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto 32bit
if /I %option%==2 goto 64bit
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:32bit
cls
cd 32 bit
pnputil -i -a android_usb.inf
pause
goto menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:64bit
cls
cd 64 bit
pnputil -i -a android_usb.inf
echo Erisim engellendi hatasi aliyorsaniz Tool'u yonetici olarak calistirin
pause 
goto menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:frpsil
cls
fastboot erase config
pause
echo %[LRED]%FRP SILINDI.%[WHITE]% | cmdcolor
pause
goto menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::