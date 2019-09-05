::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:::                                                    :::
:::           This Tool has coded by Barish            :::
:::                 GSMTurkey.Net                      :::
:::                                                    :::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
@echo off
:START
chcp 857 
cls
title GsmTurkey TOOL Console Versiyon
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
echo *              %[LCYAN]%GsmTurkey Tool Console Versiyon%[WHITE]%                   * | cmdcolor
echo *  %[LYELLOW]%         TOOL BARIS MIZRAKLI TARAFINDAN KODLANDI            %[WHITE]%  * | cmdcolor
echo *                 %[LGREEN]%      GSMTURKEY.NET  %[WHITE]%                          * | cmdcolor
echo *           %[LMAGENTA]%YAPILACAK ISLEMLERDEN KULLANICI SORUMLUDUR%[WHITE]%           * | cmdcolor
echo ******************************************************************
echo %[LCYAN]%  __________________   ________________________     %[WHITE]% | cmdcolor
echo %[LCYAN]%  [__)[__][__) ! (__   !\/! !   _/ [__)[__]!_/ !    ! %[WHITE]% | cmdcolor
echo %[LCYAN]%  [__)!  !!  \_!____)  !  !_!__/___!  \!  !!  \!__  ! %[WHITE]% | cmdcolor
echo.
echo %[LRED]%GSMTurkey Tool Console Versiyon Has Coded Barish MIZRAKLI%[WHITE]% | cmdcolor
echo(
echo  Ne yapmak istersin ?
echo(	
echo  %[LMAGENTA]%1. CIHAZ BILGILERINI OKU%[LRED]% %[WHITE]%     %[LYELLOW]%       9.  SIFIRLAMA MENUSU  %[WHITE]%         %[LMAGENTA]%17. IMAJ OLUSTUR      %[WHITE]%   | cmdcolor 

echo  %[LYELLOW]%2. OEM KILIDI ISLEMLERI%[LRED]%    %[WHITE]%   %[LMAGENTA]%       10. DESEN KILIDI KIR%[LRED]%           %[LYELLOW]%18. ADB VE FASTBOOT TEST EKRANI      %[WHITE]%         %[WHITE]% | cmdcolor 

echo  %[LCYAN]%3. REBOOT ISLEMLERI%[WHITE]%   %[LGREEN]%               11. CIHAZDAN DOSYA CEK %[WHITE]%        %[LCYAN]%19. XIAOMI MI ACCOUNT SIFIRLAMA      %[WHITE]%| cmdcolor

echo  %[LGREEN]%4. LOG ISLEMLERI %[WHITE]%                    12. %[LCYAN]%CIHAZA DOSYA YUKLE%[LRED]%    %[WHITE]%     %[LGREEN]%20. CIHAZA ROOT AT      %[WHITE]%| cmdcolor	

echo  %[LMAGENTA]%5. TWRP RECOVERY PORTER   %[LRED]%      %[WHITE]%     13. %[LYELLOW]%RECOVERY ISLEMLERI %[WHITE]%        %[LCYAN]%21. DIAG ACMA      %[WHITE]%      | cmdcolor

echo  %[LYELLOW]%6. ZIP ROM KUR%[LRED]%        %[WHITE]%              %[LMAGENTA]% 14. CIHAZA APK YUKLE %[WHITE]%          %[LYELLOW]%22. NVRAM DOSYASINI CIHAZDAN CEK     %[WHITE]% | cmdcolor

echo  %[LCYAN]%7. FASTBOOT DRIVER KUR %[WHITE]%             %[LRED]% 15. TR DIL EKLE%[LRED]%       %[WHITE]%            %[WHITE]%               | cmdcolor

echo  %[LRED]%8. FRP GOOGLE KILIDINI SIL %[WHITE]%       %[LCYAN]%   16. ARAMA YAPTIRMA %[WHITE]%            %[WHITE]%        | cmdcolor
echo.
echo.
echo          %[LYELLOW]%"BAZI SECENEKLER ROOTLU CIHAZLAR ICIN GECERLIDIR"%[WHITE]% | cmdcolor

echo ******************************************************************

set /p option=Se‡iminizi yazn [1-24] ve ENTER'a basn: || set option="0"
if /I %option%==13 goto bir
if /I %option%==2 goto iki
if /I %option%==3 goto rebootmenu
if /I %option%==4 goto logislemleri
if /I %option%==5 goto tasima
if /I %option%==6 goto customrom
if /I %option%==7 goto adbdriver2
if /I %option%==8 goto frpsil
if /I %option%==9 goto factoryreset
if /I %option%==10 goto desenkilidikir
if /I %option%==11 goto adbdendosyacek
if /I %option%==12 goto adbdendosyayukle
if /I %option%==1 goto readinfo
if /I %option%==14 goto adbpull 
if /I %option%==r goto yenile
if /I %option%==15 goto trdil
if /I %option%==16 goto aramayaptirma
if /I %option%==17 goto imajolustur
if /I %option%==18 goto testekrani
if /I %option%==19 goto miaccountsifirla
if /I %option%==20 goto rootzip
if /I %option%==21 goto diagacma
if /I %option%==22 goto nvramdosyasinicek

if /I %option%==25 goto start
if /I %option%==26 goto start
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:tasima
@echo off
cls
title 404 Not Found
echo %[LGREEN]%Windows Formlarina tasinmistir%[WHITE]%         | cmdcolor
pause
goto menu
:premiumozellikler
@echo off
cls
title PREMIUM OZELLIKLER
echo %[LGREEN]%GENEL BILGILER               %[WHITE]%         | cmdcolor
echo  %[LCYAN]%PREMIUM SATIN ALARAK DESTEK OLDUGUNUZ ICIN TESEKKUR EDERIZ%[WHITE]%         | cmdcolor
echo  %[LCYAN]%PREMIUM VERSION TWRP PORTLAYICI ICERIR%[WHITE]%         | cmdcolor
echo  %[LRED]%YAKINDA MTK ISLEMCILER ICIN GELECEK OLAN ROM PORTLAMA TOOL'UNU ICERIR%[WHITE]%         | cmdcolor
echo  %[LMAGENTA]%SADECE 4 ADIMDA TWRP RECOVERY ELDE EDERSINIZ%[WHITE]%         | cmdcolor
echo  %[LCYAN]%EXTRA TELEFON OZELLESTIRMELERI ICERIR%[WHITE]%         | cmdcolor
echo  %[LCYAN]%ZIL SESI DEGISTIRME%[WHITE]%         | cmdcolor
echo  %[LCYAN]%XPOSED INSTALLER%[WHITE]%         | cmdcolor
echo  %[LRED]%KOLAY ARAYUZ%[WHITE]%         | cmdcolor
echo  %[LMAGENTA]%DAHA ACIKLAYICI VE ALGILAYICI MENU ICERIKLERI%[WHITE]%         | cmdcolor
echo %[LGREEN]%BIR TELEFONCUNUN ISINE YARAYACAK TOOL , DRIVER , PROGRAM ICERIR%[WHITE]%         | cmdcolor
echo  %[LCYAN]%CEKTIGINIZ BIR VIDEO'YU ANDROID ACILIS ANIMASYONU YAPAR%[WHITE]%         | cmdcolor
echo  %[LCYAN]%HAFTALIK GUNCELLEME ICERIR%[WHITE]%         | cmdcolor
echo %[LGREEN]%TUM OZELLIKLER V2 ILE BIRLIKTE UPDATE EDILECEKTIR%[WHITE]%         | cmdcolor
echo  %[LCYAN]%INSTAGRAM.COM/BARIS.MIZRAKLI%[WHITE]%| cmdcolor
echo  %[LRED]%FACEBOOK.COM/BARISMIZRAKLI%[WHITE]%         | cmdcolor
echo  %[LCYAN]%GMDISKITKAT@GMAIL.COM%[WHITE]%         | cmdcolor
echo  %[LRED]%TECHNODEVS.ORG%[WHITE]%         | cmdcolor
echo  %[LRED]%GIBI ALANLARDAN VEYA TOOL'U EDINDIGINIZ PLATFORMDAN%[WHITE]%         | cmdcolor
echo  %[LMAGENTA]%GELISTIRICI ILE ILETISIME GECEBILIRSINIZ%[WHITE]%         | cmdcolor
echo  %[LCYAN]%UCRET ICIN GELISTIRICI ILE GORUSMELISINIZ %[WHITE]%         | cmdcolor
echo  %[LCYAN]%UCRETI ODENDIKTEN SONRA PREMUIM TOOL VE SERIAL KEY'I ANINDA VERILIR %[WHITE]%         | cmdcolor
echo %[LGREEN]%AYRICA TEAM VIEWER , WHATSAPP GIBI ARACLARDAN%[WHITE]%         | cmdcolor
echo  %[LCYAN]%TEKNIK DESTEK SAGLANIR%[WHITE]%         | cmdcolor
echo  %[LCYAN]%TECHNODEVS.ORG %[WHITE]%         | cmdcolor
pause
goto start
:arachakkinda
@echo off
cls
title ARAC HAKKINDA
echo %[LGREEN]%GENEL BILGILER               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% BU ARAC ILE YAPABILECEKLERINIZI KISACA OZETLEDIK%[WHITE]%         | cmdcolor
echo  %[LCYAN]% TUM ISLEMLERI YAPMADAN ONCE DRIVER'LERIN KURULU OLDUGUNDAN EMIN OLUN%[WHITE]%         | cmdcolor
echo  %[LRED]% SECECEGINIZ MENUYU DIKKATLI SECIN. YAPTIGINIZ BIR HATA SONUCU CIHAZA KALICI HASAR VEREBILIRSINIZ  %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% HER MENUNUN DETAYLI BIR SEKILDE EKLENDI%[WHITE]%         | cmdcolor
echo  %[LCYAN]% MENU BASLIKLARI GAYET ANLASILIR SEKILDE. %[WHITE]%         | cmdcolor
echo  %[LCYAN]% GIRDIGINIZ ALT MENULERDE YAZILANLARA KESINLIKLE UYUNUZ.%[WHITE]%         | cmdcolor
echo  %[LCYAN]% BAZI MENULERDEKI ISLEMLER ROOT ISTEYECEKTIR.%[WHITE]%         | cmdcolor
echo  %[LRED]% MENU ICERIKLERINDE ROOT ISTEDIGI BELIRTILMISTIR%[WHITE]%         | cmdcolor
echo %[LGREEN]%  MENU ISLEVLERI VE BAZI KISA KODLAR %[WHITE]%         | cmdcolor
echo  %[LCYAN]% BIR ISLEM SIRASINDA IPTAL ETMENIZ ICAP ETTIYSE %[WHITE]%         | cmdcolor
echo  %[LCYAN]% CTRL + C TUSLARINA BASIN. Y/N GIBI BIR SORU ILE KARSI KARSIYA KALIRSANIZ%[WHITE]%         | cmdcolor
echo  %[LRED]% Y HARFINE BASARAK ONAY VERINIZ.  %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% ANA MENUDE SECIM YAPMADAN ENTER YAPARSANIZ ANA MENU YENILENIR  %[WHITE]%         | cmdcolor
echo %[LGREEN]%EMEGI GECENLER%[WHITE]%         | cmdcolor
echo  %[LCYAN]% GSMTURKEY.NET YONETICI KADROSU%[WHITE]%| cmdcolor
echo  %[LCYAN]% GAMAKEN.COM YONETICI KADROSU%[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% ASDERDD@TURKDEVS %[WHITE]%         | cmdcolor
echo  %[LRED]% WES@TURKDEVS%[WHITE]%         | cmdcolor
echo  %[LCYAN]% BU TOOL BARIS MIZRAKLI TARAFINDAN KODLANMISIR. %[WHITE]%         | cmdcolor
echo  %[LCYAN]% BASKA KAYNAKLARDA IZINI OLMADIKCA PAYLASILMASI YASAKTIR   %[WHITE]%         | cmdcolor
echo %[LGREEN]%BILINMESI ZORUNLU OLANLAR%[WHITE]%         | cmdcolor
echo  %[LCYAN]% DOGACAK YA DA DOGMUS HASARLARDAN KULLANICI SORUMLUDUR %[WHITE]%         | cmdcolor
echo  %[LCYAN]% BU BIR PROGRAMDIR VE BATCH DILI ILE KODLANMISTIR. %[WHITE]%         | cmdcolor
echo  %[LRED]% HATALARIN GOZDEN KACMASI MUHTEMELDIR. OLUSACAK HASARLARDAN KULLANICI SORUMLUDUR%[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% SIZE VERILEN TESCIL KODUNU PAYLASMANIZ HALINDE BLOCK EDILECEKTIR %[WHITE]%         | cmdcolor
echo  %[LCYAN]% TECHNODEVS.ORG %[WHITE]%         | cmdcolor
echo  %[LRED]% BIZ SEVDIK DE ELLER ALDI%[WHITE]%         | cmdcolor
pause
goto start

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:premium

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:rootlucihaz
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:changelog
@echo off
cls
title DEGISIKLIK LISTESI
echo %[LGREEN]%TECHNODEVS TOOL V1.8 Premium %[WHITE]%         | cmdcolor
echo  %[LCYAN]% TWRP PORTLAYICI EKLENDI. %[WHITE]%         | cmdcolor
echo  %[LCYAN]% PREMIUM ICIN EKRAN DUZENI DEGISTIRILDI   %[WHITE]%         | cmdcolor
echo  %[LRED]% MEVCUT HATALAR DUZELTILDI               %[WHITE]%         | cmdcolor
echo %[LGREEN]%TECHNODEVS TOOL V1.8               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% SIDELOAD ZIP ROM KURMA SECEGI EKLENDI.               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% TOOL EKRAN GUNCELLEME EKLENDI               %[WHITE]%         | cmdcolor
echo  %[LRED]% GELISMIS REBOOT MENUSU EKLENDI.               %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% EDL-SYSTEM-FASTBOOT-RECOVERY REBOOT SECENEKLERI             %[WHITE]%         | cmdcolor
echo  %[LCYAN]% GELISMIS SIFIRLAMA MENUSU EKLENDI               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% ARTIK ISTEDIGINIZ PARTITIONU SILEBILECEKSINIZ               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% CHANGELOG EKLENDI               %[WHITE]%         | cmdcolor
echo  %[LRED]% PREMIUM MENUSU EKLENDI.               %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% PRO VERSIYONA TWRP PORTER EKLENDI.               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% ARTIK MTK VE SNAPDRAGON CIHAZA TWRP PORTLAYABILIRSINIZ               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% MTK ICIN NVRAM DOSYASI CEKME EKLENDI               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% DIAG ACMA EKLENDI               %[WHITE]%         | cmdcolor
echo  %[LRED]% FRP GOOGLE KILIDI SILME GUNCELLENDI               %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% UFAK TEFEK HATALAR GIDERILDI               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% BIR KAC HATA DUZELTMESI YAPILDI.               %[WHITE]%         | cmdcolor
echo %[LGREEN]%TECHNODEVS TOOL V1.7             %[WHITE]%         | cmdcolor
echo  %[LCYAN]% KAYNAK KODLARI GIZLEDI.               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% REBOOT MENUSU EKLENDI.               %[WHITE]%         | cmdcolor
echo  %[LRED]% DESEN KIRMA EKLENDI..               %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% IMAJ ALMA SORUNU DUZELTILDI.               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% MI ACCOUNT SIFIRLAMA EKLENDI.             %[WHITE]%         | cmdcolor
echo  %[LCYAN]% MENULERDEKI UFAK TEFEK YAZIM HATALARI GIDERILDI.               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% HER ALT MENUDE > ANA MENUYE DONME SECENEGI EKLENDI..               %[WHITE]%         | cmdcolor
echo  %[LRED]% SETUP SEKLINDEDIR. KURULUM SIRASINDA SERIAL ISTEYECEKTIR.               %[WHITE]%         | cmdcolor
echo %[LGREEN]%TECHNODEVS TOOL V1.5             %[WHITE]%         | cmdcolor
echo  %[LCYAN]% BOOT, SYSTEM , RECOVERY ( PARTITIONLARINIZDA BULUNAN TUM DOSYALARIN) IMAJ HALINE GETIRILMESI EKLENDI.%[WHITE]%| cmdcolor
echo  %[LCYAN]% EDL MODE GECIS               %[WHITE]%         | cmdcolor
echo  %[LRED]% CIHAZDAN DOSYA CEKME               %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% CIHAZA DOSYA YUKLEME               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% TURKCE DILI OLMAYAN CIHAZA TURKCE DIL EKLEME               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% TELEFON NUMARASI GIREREK ARAMA YAPTIRMA               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% FACTORY RESET             %[WHITE]%         | cmdcolor
echo  %[LRED]% MENULER ARASI DUZENLEMELER YAPILDI.%[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% BIR KAC HATA DUZELTMESI YAPILDI. %[WHITE]%         | cmdcolor

echo %[LGREEN]%TECHNODEVS TOOL V1.0 %[WHITE]%         | cmdcolor
echo  %[LCYAN]% RECOVERY YUKLER: TEK SEFERLIK  KALICI YUKLEME%[WHITE]%         | cmdcolor
echo  %[LCYAN]% OEM ISLEMLERI OEM KILIDINI ACAR  KAPATIR%[WHITE]%         | cmdcolor
echo  %[LRED]% LOG ISLEMLERI ADB LOGCAT  ADB DMESG LOG'U ALIR. %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]% FASTBOOT MODE TUSLAR ILE GECMEYEN CIHAZI FASTBOOT MODE ALIR. %[WHITE]%         | cmdcolor
echo  %[LCYAN]% CIHAZ BILGILERINI OKUR: EKRAN ALINTISINDA MEVCUT %[WHITE]%         | cmdcolor
echo  %[LCYAN]% CIHAZA .APK YUKLER. %[WHITE]%         | cmdcolor
echo  %[LCYAN]% BAZI CIHAZLARIN FRP KILIDINI KALDIRIR.%[WHITE]%         | cmdcolor
echo  %[LRED]% FASTBOOT DRIVER KURABILIR.%[WHITE]%         | cmdcolor
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:twrpportlayici
cls
echo(
echo %[LRED]%TWRP RECOVERY PORTLAMAK ICIN GEREKLI SARTLAR ICIN 1'E BASINIZ%[WHITE]% | cmdcolor
echo %[LCYAN]%TWRP'DE GELISMIS MENUSUNDEN ADB SIDELOAD'A TIKLAYIP ASAGIDAKI CUBUGU KAYDIRIN%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  ILK ADIM ( DOSYA KOPYALAMA )%[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  IKINCI ADIM ( AYIKLAMA ) %[WHITE]%         | cmdcolor
echo    %[LRED]% 3.  UCUNCU ADIM ( PORT ) %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 4.  DORDUNCU ADIM ( PAKETLE )%[WHITE]%         | cmdcolor
echo    %[LCYAN]% 5.  ANA MENU'YE DON    %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-5] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto twrprecoverysartlari
if /I %option%==2 goto ikinciadimtwrpport
if /I %option%==3 goto ucuncuadim
if /I %option%==4 goto paketletwrp
if /I %option%==5 goto start
goto twrpportlayici
:paketletwrp
cls
echo %[LRED]%SON ADIM PAKETLEME ISLEMIDIR%[WHITE]% | cmdcolor
echo %[LGREEN]%AYIKLARKEN GIRDIGINIZ MENUDE PORT RECOVERY SECINIZ%[WHITE]% | cmdcolor
echo %[LCYAN%ARDINDAN PAKETLE TUSUNA BASARAK SECINIZ.%[WHITE]% | cmdcolor
echo %[LMAGENTA]%TWRP RECOVERY HAZIR OLARAK KLASOR ICINDE ACILACAKTIR%[WHITE]% | cmdcolor
pause
goto recovery
:ucuncuadim
c:\>copy con yedekle.bat
@echo off
cls
echo  %[LCYAN]% BIRAZDAN SORULACAK SORUYA 'Y' BASARAK ONAY VERINIZ.%[WHITE]%| cmdcolor
pause
xcopy "C:\Windows\TechnoDevsTool\recovery-stock\recovery.img-kernel" "C:\Windows\TechnoDevsTool\recovery-port" /s
xcopy "C:\Windows\TechnoDevsTool\recovery-stock\ramdisk\fstab.qcom" "C:\Windows\TechnoDevsTool\recovery-port\ramdisk" /s
pause
goto twrpportlayici
:ikinciadimtwrpport
cls
goto recovery
:twrprecoverysartlari
cls
echo %[LRED]%CIHAZINIZDA ROOT BULUNMALIDIR%[WHITE]% | cmdcolor
echo %[LGREEN]%STOCK RECOVERY'I BULUNMALIDIR%[WHITE]% | cmdcolor
echo %[LMAGENTA]%STOCK RECOVERY'I YOKSA 1' BASARAK YEDEK ALINIZ%[WHITE]% | cmdcolor
echo %[LGREEN]%STOCK RECOVERY VE PORT RECOVERY DOSYASINI%[WHITE]% | cmdcolor
echo %[LCYAN]%ACILAN KLASORE KOPYALAYINIZ%[WHITE]% | cmdcolor
start explorer.exe "C:\windows\TechnoDevsTool\recovery-resources"
echo %[LMAGENTA]%STOCK RECOVERY DOSYASININ ADINI stock.img YAPINIZ%[WHITE]% | cmdcolor
echo %[LRED]%PORT RECOVERY DOSYASININ ADINI port.img YAPINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%KOPYALAMA ISLEMINI YAPTIYSANIZ%[WHITE]% | cmdcolor
echo %[LCYAN]%PORTLAYICIYA GERI DONUN VE IKINCI ADIMA GECIN%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  RECOVERY IMAJ OLUSTUR %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  PORTLAYICIYA GERI DON %[WHITE]%         | cmdcolor
echo    %[LCYAN]% 3.  ANA MENU'YE DON    %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto imajolustur
if /I %option%==2 goto twrpportlayici
if /I %option%==3 goto start
goto twrprecoverysartlari



::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:desenkilidikir
cls
title DESEN KILIDI KIR @ BARISMIZRAKLI
echo(
echo %[LRED]%DESEN KILIDINI KIRMAK ICIN CIHAZI ADB SIDELOAD MOD'A ALIN%[WHITE]% | cmdcolor
echo %[LCYAN]%TWRP'DE GELISMIS MENUSUNDEN ADB SIDELOAD'A TIKLAYIP ASAGIDAKI CUBUGU KAYDIRIN%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  DESEN KILIDINI KIR %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  RECOVERY MODE AL %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  CIHAZI YENIDEN BASLAT%[WHITE]%         | cmdcolor
echo    %[LCYAN]% 4.  ANA MENU'YE DON    %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-4] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto desenikir
if /I %option%==2 goto recoveryreboot
if /I %option%==3 goto rebootsystem
if /I %option%==4 goto start
goto start
:desenikir
adb sideload sifreyikir.zip
adb reboot
goto start
:rebootmenu
cls
title REBOOT MENU @ BARISMIZRAKLI
echo(
echo %[LRED]%REBOOT MENUSU%[WHITE]% | cmdcolor
echo %[LCYAN]%ADB BAGLI OLMALIDIR FASTBOOT'TA SADECE EDL MODE GECIS SAGLANMAKTADIR.%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  RECOVERY %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  FASTBOOT %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  EDL MODE%[WHITE]%         | cmdcolor
echo    %[LCYAN]% 4.  SISTEM %[WHITE]%         | cmdcolor
echo    %[LRED]% 5.  ANA MENU'YE DON %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-4] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto recoveryreboot
if /I %option%==2 goto fastbootmode
if /I %option%==3 goto rebootedl
if /I %option%==4 goto rebootsystem
if /I %option%==5 goto start
goto start
:recoveryreboot
adb reboot recovery
goto menu
:rebootsystem
adb reboot
goto start
:adbdendosyayukle
cls
title CIHAZA DOSYA YUKLE @ BARISMIZRAKLI
@echo off
echo %[LMAGENTA]%DOSYAYI TOOL'UN BULUNDUGU KLASORE ATINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%YUKLEMEK ISTEDIGINIZ DOSYANIN YOLUNU BILMENIZ GEREKIYOR%[WHITE]% | cmdcolor
echo %[LCYAN]%ROOT GEREKTIRIR%[WHITE]% | cmdcolor
echo %[LRED]%YUKLEYECEGINIZ DOSYANIN ADININ SYSTEM'DEKI ADINI MUTLAKA BILIN%[WHITE]% | cmdcolor
echo %[LBLUE]%ONCE DOSYANIN ADINI SONRA ATACAGINIZ YERI YAZIN%[WHITE]% | cmdcolor
echo %[LGREEN]%CIHAZI ADB MOD'A ALINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%BIR ORNEK :framework-res.apk /system/framework%[WHITE]% | cmdcolor
set /p dosyaat=HANGI DOSYAYI YUKLEMEK ISTIYORSUNUZ ? :
adb pull %dosyaat%
cls
echo %[LMAGENTA]%BARIS MIZRAKLI%[WHITE]% | cmdcolor
echo %[LYELLOW]% TEHNODEVS.ORG%[WHITE]% | cmdcolor
pause
goto start
:rebootedl
cls
title EDL MODE @ BARISMIZRAKLI
@echo off
echo %[LMAGENTA]%DIKKAT EDINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%YAPILACAK ISLEMLERDEN SORUMLU SIZSINIZ%[WHITE]% | cmdcolor
echo %[LCYAN]%CIHAZI ADB MOD'A ALINIZ.%[WHITE]% | cmdcolor
echo %[LRED]%EDL MODE ALINIYOR%[WHITE]% | cmdcolor
pause
adb devices
fastboot devices
adb reboot edl
fastboot oem edl
cls
echo %[LMAGENTA]%ANA MENUYE YONLENDIRILECEKSINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%TECHNODEVS.ORG%[WHITE]% | cmdcolor
pause
goto start
:factoryreset
cls
title SIFIRLAMA MENUSU @ BARISMIZRAKLI
echo %[LRED]%CIHAZI FASTBOOT MODE ALINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%OEM KILIDI ACIK OLMALIDIR%[WHITE]% | cmdcolor
echo %[LCYAN]%SIFIRLAMAK ISTEDIGINIZ PARTITIONU SECINIZ%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  SYSTEM %[WHITE]%                 | cmdcolor
echo     %[LGREEN]%2.  RECOVERY %[WHITE]%                 | cmdcolor
echo     %[LCYAN]%3.  KULLANICI VERISI %[WHITE]%                 | cmdcolor
echo     %[LRED]%4.  CACHE %[WHITE]%                 | cmdcolor
echo     %[LBLUE]%5.  OEM %[WHITE]%                 | cmdcolor
echo     %[LGREEN]%6.  PERSIST %[WHITE]%                 | cmdcolor
echo     %[LMAGENTA]%7.  KENDIM PARTITION GIRERIM %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 8.  FASTBOOT MODE AL %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 9.  CIHAZI YENIDEN BASLAT%[WHITE]%         | cmdcolor
echo    %[LCYAN]% 10.  ANA MENU'YE DON    %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-10] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto systemsifirla
if /I %option%==2 goto recoveryreboot
if /I %option%==3 goto factoryreset
if /I %option%==4 goto cachesifirla
if /I %option%==5 goto oemsifirla
if /I %option%==6 goto persistsifirla
if /I %option%==7 goto kendimpartitiongirerim
if /I %option%==8 goto fastbootmode
if /I %option%==9 goto rebootsystem
if /I %option%==10 goto menu
goto start
:oemsifirla
cls
fastboot erase oem
echo %[LCYAN]%BASARI%[WHITE]% | cmdcolor
pause
goto menu
:persistsifirla
cls
fastboot erase persist
echo %[LCYAN]%BASARI%[WHITE]% | cmdcolor
pause
goto menu
:kendimpartitiongirerim
cls
set /p kendimpartitiongirerimm=SIFIRLAMAK ISTEDIGINIZ PARTITION'UN SADECE ADINI GIRINIZ: SYSTEM GIBI ? :
fastboot erase %kendimpartitiongirerimm%
echo %[LCYAN]%BASARILI%[WHITE]% | cmdcolor
pause
goto start
:cachesifirla
cls
fastboot erase cache
echo %[LCYAN]%BASARI%[WHITE]% | cmdcolor
pause
goto menu
:systemsifirla
cls
fastboot erase system
goto menu
:recoveryisifirla
cls
fastboot erase recovery
echo %[LCYAN]%BASARILI%[WHITE]% | cmdcolor
echo %[LMAGENTA]%ANA MENUYE YONLENDIRILECEKSINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%TECHNODEVS.ORG%[WHITE]% | cmdcolor
pause
goto start
:adbdendosyacek
cls
title CIHAZDAN DOSYA CEK @ BARISMIZRAKLI
@echo off
echo %[LMAGENTA]%CIHAZI ADB MOD'A ALINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%CEKMEK ISTEDIGINIZ DOSYANIN YOLUNU BILMENIZ GEREKIYOR%[WHITE]% | cmdcolor
echo %[LCYAN]%SYSTEM DISI DOSYALAR ROOT GEREKTIRIR%[WHITE]% | cmdcolor
echo %[LRED]%BIR ORNEK : /system/framework/framework.apk%[WHITE]% | cmdcolor
set /p dosyacek=HANGI DOSYAYI CEKMEK ISTIYORSUNUZ ? :
adb pull %dosyacek%
cls
echo %[LMAGENTA]%DOSYA TOOL'UN BULUNDUGU KLASORDE OLACAKTIR%[WHITE]% | cmdcolor
echo %[LYELLOW]%EGER YOKSA VEYA HATA ALDIYSANIZ UYARILARI TEKRAR OKUYUN.%[WHITE]% | cmdcolor
pause
goto start
:nvramdosyasinicek
cls
title NVRAM DOSYASINI CEK @ BARISMIZRAKLI
@echo off
echo %[LMAGENTA]%CIHAZI ADB MOD'A ALINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%ROOT GEREKLIDIR. MTK ICIN GECERLIDIR%[WHITE]% | cmdcolor
echo %[LCYAN]%TOOL'U KULLANDIGINIZ ICIN TESEKKUR EDERIZ%[WHITE]% | cmdcolor
echo %[LRED]%DOSYA CEKILIYOR%[WHITE]% | cmdcolor
adb pull /system/etc/mddb/
pause
cls
echo %[LMAGENTA]%DOSYA TOOL'UN BULUNDUGU KLASORDE OLACAKTIR%[WHITE]% | cmdcolor
echo %[LYELLOW]%EGER DOSYA YOKSA VEYA HATA ALDIYSANIZ UYARILARI TEKRAR OKUYUN.%[WHITE]% | cmdcolor
pause
goto start
:diagacma
cls
title DIAG AC @ BARISMIZRAKLI
echo %[LRED]%DIAG ICIN CIHAZI ADB MOD'A ALIN / ROOT GEREKLIDIR%[WHITE]% | cmdcolor
echo %[LCYAN]%ASAGIDA ADB SHELL EKRANINA ILK OLARAK%[LRED]% su YAZIN %[WHITE]% | cmdcolor
echo %[LYELLOW]%setprop sys.usb.config diag,adb  // BU KOMUTU KOPYALAYIP SHELL EKRANINA YAPISTIRIN.%[WHITE]% | cmdcolor
pause
adb shell

goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:rootzip
cls
title ROOT @ BARISMIZRAKLI
echo %[LRED]%ROOT ATMAK ICIN CIHAZI ADB SIDELOAD MOD'A ALIN%[WHITE]% | cmdcolor
echo %[LCYAN]%TWRP'DE GELISMIS MENUSUNDEN ADB SIDELOAD'A TIKLAYIP ASAGIDAKI CUBUGU KAYDIRIN%[WHITE]% | cmdcolor
echo %[LYELLOW]%DIKKAT ! BAZI CIHAZLARLA UYUMSUZ OLABILIR. BRICK OLMA IHTIMALI VARDIR.%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  ROOT AT / SUPERSU V2.82 %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  RECOVERY MODE AL %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  CIHAZI YENIDEN BASLAT%[WHITE]%         | cmdcolor
echo    %[LCYAN]% 4.  ANA MENU'YE DON    %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-4] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto supersu
if /I %option%==2 goto recoveryreboot
if /I %option%==3 goto rebootsystem
if /I %option%==4 goto start
goto start
:supersu
adb sideload supersu.zip
goto start
:miaccountsifirla
cls
title XIAOMI MI ACCOUNT SIFIRLAMA
echo(
echo %[LRED]%CIHAZI ADB MOD'A ALIN%[WHITE]% | cmdcolor
echo %[LCYAN]%ARDINDAN ASAGIDAN ISLEM SECIN%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  KILIDI KALDIR %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  CIHAZI YENIDEN BASLAT %[WHITE]%         | cmdcolor
echo    %[LCYAN]% 3.  ANA MENU'YE DON      %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto miaccountsil
if /I %option%==2 goto rebootsystem
if /I %option%==3 goto start
goto start
:miaccountsil
adb shell pm uninstall -k --user 0 com.xiaomi.finddevice
goto start
:testekrani
cls
@echo off
title TEST MENUSU
pause
start cmd-here.exe
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
cls
title IMAJ OLUSTUR @ BARISMIZRAKLI
@echo off
echo %[LYELLOW]%BU ISLEMI MANUEL YAPACAKSINIZ%[WHITE]% | cmdcolor
echo %[LMAGENTA]%ADB SHELL EKRANINA ILK ONCE%[LRED]% su %[LGREEN]%YAZARAK ROOT YETKISINI VERIN%[WHITE]% | cmdcolor
echo %[LCYAN]%SIMDI ASAGIDA ACILAN ADB SHELL EKRANINA ASAGIDAKI KOMUTLARI YAZIN. PARTITIONLAR TAM CIKANA HEPSINI TEK TEK DENEYIN.%[WHITE]% | cmdcolor
echo %[LRED]%ls -la /dev/block  veya ls -la /dev/block/platform/soc/7824900.sdhci/by-name %[WHITE]% | cmdcolor
echo %[LYELLOW]%PARTITIONLAR CIKINCA ASAGIDAKI KODU KULLANIN./ ILE BASLAR PARTITION.%[WHITE]% | cmdcolor
echo %[LMAGENTA]%dd if=cihazin/partitionu of=/sdcard/dosyaninadi.img bs=4096%[WHITE]% | cmdcolor
echo %[LCYAN]%YUKARIDAKI KODI YAZDIKTAN SONRA BEKLEYIN. BIR SURE SONRA CIHAZ HAFIZINDA ISTEDIGINIZ DOSYA .IMG SEKLINDE BELIRECEK. TOOLU KAPATABILIRSINIZ%[WHITE]% | cmdcolor
adb shell
pause
echo %[LCYAN]%/dev/block/boot-device/boot%[WHITE]% | cmdcolor
set /p imaj=ISTEDIGINIZ IMAJIN PARTITIONUNU GIRINIZ.ORNEK YUKARDA.  :
set /p isim=IMAJ ISMI NE OLSUN?  : 
adb shell dd if=%imaj% of=/sdcard/%isim%.img bs=4096
cls
echo %[LMAGENTA]%TELEFON HAFIZASIDA %isim%.img SEKLINDE BELIRECEKTIR. %[WHITE]% | cmdcolor
pause
goto start
:aramayaptirma
cls
title ARAMA YAPTIR @ BARISMIZRAKLI
@echo off
echo %[LMAGENTA]%ADB UZERINDEN ARAMA YAPTIRMA FRP FAST CALL%[WHITE]% | cmdcolor
echo %[LYELLOW]%SIM KARTIN TAKILI OLDUGUNDAN EMIN OLUN.%[WHITE]% | cmdcolor
echo %[LCYAN]%EKRAN KILITLI OLSA BILE ARAMA YAPABILIR%[WHITE]% | cmdcolor
echo %[LRED]%TEK SART ADB BAGLI OLMASI GEREKLIDIR%[WHITE]% | cmdcolor
pause
cls
set /p tel=Hangi Numarayi Aratmak Istiyorsunuz  : 
cls
adb shell am start -a android.intent.action.CALL -d tel:%tel%
cls
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:trdil
cls
title TURKCE DIL EKLE @ BARISMIZRAKLI
echo %[LCYAN]%DOSYALAR LISTELENDI%[WHITE]% | cmdcolor
dir
echo %[LYELLOW]%APK DOSYASININ ADINI YUKARIDAN BAKINIZ%[WHITE]% | cmdcolor
set /p tr= Apk Dosyasinin Adini Giriniz. Sonuna .apk Ekleyin :
pause
cls
adb devices
adb install %tr%
cls
adb shell pm grant jp.co.c_lis.ccl.morelocale android.permission.CHANGE_CONFIGURATION
pause
goto start
:adbpull
cls
title ANDROID UYGULAMA PAKETI KURMA @ BARISMIZRAKLI
echo %[LCYAN]%DOSYALAR LISTELENDI%[WHITE]% | cmdcolor
dir
echo %[LYELLOW]%APK DOSYASININ ADINI YUKARIDAN BAKINIZ%[WHITE]% | cmdcolor
set /p apk= Apk Dosyasinin Adini Giriniz. Sonuna .apk Ekleyin :
pause
cls
adb devices
adb install %apk%
pause
goto start
:readinfo
cls
title READ INFO @ BARISMIZRAKLI
echo %[LRED]%Android Surumu%[WHITE]% | cmdcolor
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
title CIKIS@ BARISMIZRAKLI
echo %[LGREEN]%Bu Tool Baris MIZRAKLI tarafindan kodlandi%[WHITE]% | cmdcolor
echo %[LCYAN]%TechnoDevs.Org.%[WHITE]% | cmdcolor
echo %[LYELLOW]%GsmTurkey.Net.%[WHITE]% | cmdcolor
echo %[LRED]%Retzh.Xyz%[WHITE]% | cmdcolor
echo %[LBLUE]%Bizi Tercih Ettiginiz Icin Tesekkurler.%[WHITE]% | cmdcolor
pause
exit
echo(
echo %[LRED]%%option% ge‡erli bir se‡enek de§il. Ltfen tekrar deneyin! %[WHITE]% | cmdcolor
pause
goto MAIN_TR
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:bir
cls
title RECOVERY ISLEMLERI @ BARISMIZRAKLI
echo(
echo %[LRED]%GSMTURKEY.NET.%[WHITE]% | cmdcolor
echo %[LCYAN]%TECHNODEVS.ORG.%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  RECOVERY TEK SEFERLIK YUKLE%[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  RECOVERY KALICI YUKLE%[WHITE]%         | cmdcolor
echo     %[LGREEN]%3.  ANA MENU'YE GIT%[WHITE]%         | cmdcolor
echo %[LYELLOW]%RECOVERY'I ANA DIZINE ATIP ADINI %[LRED]% "recovery.img YAPINIZ" .%[WHITE]% | cmdcolor
set /p option=Se‡iminizi yazn [1,2,3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto recoverytek
if /I %option%==2 goto recoverykalici
if /I %option%==3 goto start
goto start
:recoverytek
title TEK SEFERLIK RECOVERY YUKLE @ BARISMIZRAKLI
cls
echo %[LYELLOW]%RECOVERY'I TEK SEFERLIK YUKLEMEYI SECTINIZ%[WHITE]% | cmdcolor
fastboot devices
fastboot boot recovery.img
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:recoverykalici
cls
title KALICI RECOVERY YUKLE @ BARISMIZRAKLI
fastboot devices
echo %[LYELLOW]%ESKI RECOVERY SILINIYOR%[WHITE]% | cmdcolor
fastboot erase recovery
cls
echo %[LRED]%RECOVERY KALICI OLARAK YUKLENIYOR%[WHITE]% | cmdcolor
cls
fastboot flash recovery recovery.img
cls
echo %[LCYAN]%RECOVERY BASARILI BIR SEKILDE YUKLENI%[WHITE]% | cmdcolor
echo  %[LMAGENTA]%1.  RECOVERY ACILSIN %[WHITE]%        | cmdcolor
echo  %[LRED]%    2.  UST MENU'YE GIT %[WHITE]%         | cmdcolor
echo  %[LGREEN]%  3.  ANA MENU'YE GIT%[WHITE]%         | cmdcolor
set/p input=Sec:
if /I %option%==1 goto evet
if /I %option%==2 goto bir
if /I %option%==3 goto start
goto start
:evet
cls
fastboot boot recovery.img
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:menu
cls
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:iki
cls
title OEM KIDILI ISLEMLERI @ BARISMIZRAKLI
echo  %[LMAGENTA]%1.  OEM KILIDINI AC %[WHITE]%         | cmdcolor
echo  %[LYELLOW]%2.  OEM KILIDINI KAPAT %[WHITE]%         | cmdcolor
echo  %[LGREEN]%3.  ANA MENUYE GIT%[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1,2,3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto ac
if /I %option%==2 goto kapat
if /I %option%==3 goto start
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:ac
title OEM KILIDI ACMA @ BARISMIZRAKLI
cls
echo %[LRED]%AYARLARDAN GELISTIRICI SECENEKLERINDEN OEM KIDILINI ACMA VE USB HATA AYIKLAMA MOD'UNU ACIN%[WHITE]% | cmdcolor
echo %[LBLUE]%OEM KILIDINI ACILIYOR%[WHITE]% | cmdcolor
fastboot oem unlock-go
echo %[LCYAN]%BASARILI BIR SEKILDE ACILDI%[WHITE]% | cmdcolor
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:kapat
cls
title OEM KILIDI KAPATMA @ BARISMIZRAKLI
echo %[LCYAN]%DIKKAT! BAZI CIHAZLAR STOCK RECOVERY OLMADIGI ZAMANLARDA OEM KILIDINI KAPATMANIZ HALINDE HARDBRICK OLUR%[WHITE]% | cmdcolor
echo  %[LBLUE]%1.  STOCK RECOVERY KURULU DEGIL %[WHITE]%         | cmdcolor
echo  %[LGREEN]%2.  STOCK RECOVERY KURULU %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]%3. ANA MENUYE GIT%[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1,2] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto bir
if /I %option%==2 goto 3
if /I %option%==3 goto start
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:3
cls
title OEM KILIDI KAPATMA @ BARISMIZRAKLI
fastboot oem lock
echo %[LCYAN]%OEM KILIDI KAPATILDI%[WHITE]% | cmdcolor
echo  %[LBLUE]%1.  CIHAZI AC %[WHITE]%         | cmdcolor
echo  %[LBLUE]%2.  ANA MENU'YE DON %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1,2] ve ENTER'a basn: || set option="0"
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
title FASTBOOT MODE AL @ BARISMIZRAKLI
echo %[LCYAN]%CIHAZ ADB BAGLI OLMAK ZORUNDADIR%[WHITE]% | cmdcolor
echo %[LYELLOW]%ADB DRIVER'LERI KURULU OLMALIDIR%[WHITE]% | cmdcolor
echo %[LRED]%USB BAGLAYIN VE YALNIZCA SARJ MOD'UNA ALIN.%[WHITE]% | cmdcolor
echo %[LBLUE]%HER SEY HAZIR ISE:%[WHITE]% | cmdcolor
pause
adb reboot bootloader
pause
goto menu
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:logislemleri
cls
title LOG ISLEMLERI
echo %[LCYAN]%2 CESIT LOG ALABILIRSINIZ%[WHITE]% | cmdcolor
echo %[LRED]%1.  ADB LOGCAT %[WHITE]%         | cmdcolor
echo %[LMAGENTA]%2.  ADB DMESG %[WHITE]%         | cmdcolor
echo %[LGREEN]%3.  ANA MENU'YE DON%[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1,2,3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto adblogcat
if /I %option%==2 goto adbdmesg
if /I %option%==3 goto start
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:adblogcat
title ADB LOGCAT @ BARISMIZRAKLI
cls
echo %[LCYAN]%CIHAZ ADB BAGLI OLMAK ZORUNDADIR%[WHITE]% | cmdcolor
echo %[LYELLOW]%ADB DRIVER'LERI KURULU OLMALIDIR%[WHITE]% | cmdcolor
echo %[LRED]%USB BAGLAYIN VE YALNIZCA SARJ MOD'UNA ALIN.%[WHITE]% | cmdcolor
echo %[LCYAN]%TOOL'U YONETICI OLARAK CALISTIRDIGINIZDAN EMIN ISENIZ:%[WHITE]% | cmdcolor
echo %[LBLUE]%HER SEY HAZIR ISE:%[WHITE]% | cmdcolor
pause
echo %[LBLUE]%LOG ALINACAKTIR. BUNUN SONU GELMEZ. 2 DAKIKA SONRA KAPATIN. %[WHITE]% | cmdcolor
adb logcat > logcat.txt
pause
goto menu
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:adbdmesg
cls
echo %[LCYAN]%CIHAZ ADB BAGLI OLMAK ZORUNDADIR%[WHITE]% | cmdcolor
echo %[LYELLOW]%ADB DRIVER'LERI KURULU OLMALIDIR%[WHITE]% | cmdcolor
echo %[LRED]%USB BAGLAYIN VE YALNIZCA SARJ MOD'UNA ALIN.%[WHITE]% | cmdcolor
echo %[LCYAN]%TOOL'U YONETICI OLARAK CALISTIRDIGINIZDAN EMIN ISENIZ:%[WHITE]% | cmdcolor
echo %[LBLUE]%HER SEY HAZIR ISE:%[WHITE]% | cmdcolor
echo %[LBLUE]%LOG ALINACAKTIR. BUNUN SONU GELMEZ. 2 DAKIKA SONRA KAPATIN. %[WHITE]% | cmdcolor
pause
adb shell dmesg > dmesg.txt
pause
goto menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:stockrom
cls
echo %[LCYAN]%EKLENECEK%[WHITE]% | cmdcolor
echo %[LCYAN]% EKLENECEK%[WHITE]% | cmdcolor
echo %[LYELLOW]%EKLENECEK%[WHITE]% | cmdcolor
echo %[LRED]%EKLENECEK%[WHITE]% | cmdcolor
pause
cls
start FastBootStockRom.exe
pause
goto menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:adbdriver2
cls
echo  %[LMAGENTA]%1. 32 BIT DRIVER %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]%2. 64 BIT DRIVER %[WHITE]%         | cmdcolor
echo  %[LGREEN]%  3. ANA MENU'YE DON%[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1,2,3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto 32bit
if /I %option%==2 goto 64bit
if /I %option%==3 goto start
goto start
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
echo  %[LRED]% FRP KILIDINI KIRMAK ICIN SECENEKLERI INCELEYINIZ%[WHITE]%         | cmdcolor
echo  %[LGREEN]% FASTBOOT BAGLI OLMALIDIR %[WHITE]%         | cmdcolor
echo  %[LMAGENTA]%1. FASTBOOT MODE AL %[WHITE]%         | cmdcolor
echo  %[LCYAN]%2. KILIDI KIR %[WHITE]%         | cmdcolor
echo  %[LGREEN]%3. ANA MENU'YE DON%[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1,2,3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto fastbootmode
if /I %option%==2 goto kilidikir
if /I %option%==3 goto start
pause
cls
goto start
:kilidikir
cls
echo %[LRED]%ISLEMI IPTAL ETMEK ICIN CTRL+C TUS KOMBINASYONLARI KULLANIN ARDINDAN N SECINIZ%[WHITE]% | cmdcolor
fastboot erase config
pause
echo %[LRED]%ISLEM TAMAMLANDI%[WHITE]% | cmdcolor
pause
goto menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:customrom
cls
title Rom Yukle
echo %[LRED]% ROM KURMAK CIHAZI ADB SIDELOAD MOD'A ALIN%[WHITE]% | cmdcolor
echo %[LCYAN]%TWRP'DEN GEREKLI SIFIRLAMALARI YAPIN%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.   ROM'U YUKLE %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  RECOVERY MODE AL %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  CIHAZI YENIDEN BASLAT%[WHITE]%         | cmdcolor
echo    %[LCYAN]% 4.  ANA MENU'YE DON    %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-4] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto customromukur
if /I %option%==2 goto recoveryreboot
if /I %option%==3 goto rebootsystem
if /I %option%==4 goto start
goto start
:customromukur
set /p customromadi=CUSTOM ROM DOSYANIN ADINI .ZIP YAZMADAN GIRINIZ ? :
adb sideload %customromadi%.zip
pause
goto start
:desenkilidikir
cls
title DESEN KILIDI KIR @ BARISMIZRAKLI
echo(
echo %[LRED]%DESEN KILIDINI KIRMAK ICIN CIHAZI ADB SIDELOAD MOD'A ALIN%[WHITE]% | cmdcolor
echo %[LCYAN]%TWRP'DE GELISMIS MENUSUNDEN ADB SIDELOAD'A TIKLAYIP ASAGIDAKI CUBUGU KAYDIRIN%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  DESEN KILIDINI KIR %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  RECOVERY MODE AL %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  CIHAZI YENIDEN BASLAT%[WHITE]%         | cmdcolor
echo    %[LCYAN]% 4.  ANA MENU'YE DON    %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-4] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto desenikir
if /I %option%==2 goto recoveryreboot
if /I %option%==3 goto rebootsystem
if /I %option%==4 goto start
goto start
:desenikir
adb sideload sifreyikir.zip
goto start
:rebootmenu
cls
title REBOOT MENU @ BARISMIZRAKLI
echo(
echo %[LRED]%REBOOT MENUSU%[WHITE]% | cmdcolor
echo %[LCYAN]%ADB BAGLI OLMALIDIR FASTBOOT'TA SADECE EDL MODE GECIS SAGLANMAKTADIR.%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  RECOVERY %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  FASTBOOT %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  EDL MODE%[WHITE]%         | cmdcolor
echo    %[LCYAN]% 4.  SISTEM %[WHITE]%         | cmdcolor
echo    %[LRED]% 5.  ANA MENU'YE DON %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-4] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto recoveryreboot
if /I %option%==2 goto fastbootmode
if /I %option%==3 goto rebootedl
if /I %option%==4 goto rebootsystem
if /I %option%==5 goto start
goto start
:recoveryreboot
adb reboot recovery
goto menu
:rebootsystem
adb reboot
goto start
:adbdendosyayukle
cls
@echo off
echo %[LMAGENTA]%DOSYAYI TOOL'UN BULUNDUGU KLASORE ATINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%YUKLEMEK ISTEDIGINIZ DOSYANIN YOLUNU BILMENIZ GEREKIYOR%[WHITE]% | cmdcolor
echo %[LCYAN]%ROOT GEREKTIRIR%[WHITE]% | cmdcolor
echo %[LRED]%YUKLEYECEGINIZ DOSYANIN ADININ SYSTEM'DEKI ADINI MUTLAKA BILIN%[WHITE]% | cmdcolor
echo %[LBLUE]%ONCE DOSYANIN ADINI SONRA ATACAGINIZ YERI YAZIN%[WHITE]% | cmdcolor
echo %[LGREEN]%CIHAZI ADB MOD'A ALINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%BIR ORNEK :framework-res.apk /system/framework%[WHITE]% | cmdcolor
set /p dosyaat=HANGI DOSYAYI YUKLEMEK ISTIYORSUNUZ ? :
adb pull %dosyaat%
cls
echo %[LMAGENTA]%BARIS MIZRAKLI%[WHITE]% | cmdcolor
echo %[LYELLOW]% TEHNODEVS.ORG%[WHITE]% | cmdcolor
pause
goto start
:rebootedl
cls
@echo off
echo %[LMAGENTA]%DIKKAT EDINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%YAPILACAK ISLEMLERDEN SORUMLU SIZSINIZ%[WHITE]% | cmdcolor
echo %[LCYAN]%CIHAZI ADB MOD'A ALINIZ.%[WHITE]% | cmdcolor
echo %[LRED]%EDL MODE ALINIYOR%[WHITE]% | cmdcolor
pause
adb devices
fastboot devices
adb reboot edl
fastboot oem edl
cls
echo %[LMAGENTA]%ANA MENUYE YONLENDIRILECEKSINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%TECHNODEVS.ORG%[WHITE]% | cmdcolor
pause
goto start
:factoryreset
cls
@echo off
echo %[LMAGENTA]%VERILERINIZ SILINECEKTIR%[WHITE]% | cmdcolor
echo %[LYELLOW]%YAPILACAK ISLEMLERDEN SORUMLU SIZSINIZ%[WHITE]% | cmdcolor
echo %[LCYAN]%CIHAZI FASTBOOT MOD'A ALINIZ.%[WHITE]% | cmdcolor
echo %[LRED]%OEM KILIDININ ACIK OLMASI GEREKLIDIR. BUNA DIKKAT EDINIZ%[WHITE]% | cmdcolor
pause
adb reboot bootloader
fastboot devices
fastboot erase userdata
cls
echo %[LMAGENTA]%ANA MENUYE YONLENDIRILECEKSINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%TECHNODEVS.ORG%[WHITE]% | cmdcolor
pause
goto start
:adbdendosyacek
cls
@echo off
echo %[LMAGENTA]%CIHAZI ADB MOD'A ALINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%CEKMEK ISTEDIGINIZ DOSYANIN YOLUNU BILMENIZ GEREKIYOR%[WHITE]% | cmdcolor
echo %[LCYAN]%SYSTEM DISI DOSYALAR ROOT GEREKTIRIR%[WHITE]% | cmdcolor
echo %[LRED]%BIR ORNEK : /system/framework/framework.apk%[WHITE]% | cmdcolor
set /p dosyacek=HANGI DOSYAYI CEKMEK ISTIYORSUNUZ ? :
adb pull %dosyacek%
cls
echo %[LMAGENTA]%DOSYA TOOL'UN BULUNDUGU KLASORDE OLACAKTIR%[WHITE]% | cmdcolor
echo %[LYELLOW]%EGER YOKSA VEYA HATA ALDIYSANIZ UYARILARI TEKRAR OKUYUN.%[WHITE]% | cmdcolor
pause
goto start
:rootlucihaz
cls
echo(
echo %[LRED]%GSMTURKEY.NET.%[WHITE]% | cmdcolor
echo %[LCYAN]%TECHNODEVS.ORG.%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  IMAJ OLUSTUR %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  TEST MENUSU %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  XIAOMI MI ACCOUNT SIFIRLAMA %[WHITE]%         | cmdcolor
echo    %[LCYAN]% 4.  CIHAZA ROOT AT %[WHITE]%         | cmdcolor
echo    %[LRED]% 5.  ANA MENU'YE DON %[WHITE]%         | cmdcolor
echo %[LYELLOW]%"V2 SURUMUNDE%[LRED]% DEHSET OZELLIKLERIN %[LGREEN]%EKLENMESI PLANLANDI"%[WHITE]% | cmdcolor
set /p option=Se‡iminizi yazn [1-5] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto imajolustur
if /I %option%==2 goto testekrani
if /I %option%==3 goto miaccountsifirla
if /I %option%==4 goto rootzip
if /I %option%==5 goto start
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:rootzip
cls
title ROOT@SUPERSU
echo %[LRED]%ROOT ATMAK ICIN CIHAZI ADB SIDELOAD MOD'A ALIN%[WHITE]% | cmdcolor
echo %[LCYAN]%TWRP'DE GELISMIS MENUSUNDEN ADB SIDELOAD'A TIKLAYIP ASAGIDAKI CUBUGU KAYDIRIN%[WHITE]% | cmdcolor
echo %[LYELLOW]%DIKKAT ! BAZI CIHAZLARLA UYUMSUZ OLABILIR. BRICK OLMA IHTIMALI VARDIR.%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  ROOT AT / SUPERSU V2.82 %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  RECOVERY MODE AL %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  CIHAZI YENIDEN BASLAT%[WHITE]%         | cmdcolor
echo    %[LCYAN]% 4.  ANA MENU'YE DON    %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-4] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto supersu
if /I %option%==2 goto recoveryreboot
if /I %option%==3 goto rebootsystem
if /I %option%==4 goto start
goto start
:supersu
adb sideload supersu.zip
goto start
:miaccountsifirla
cls
title XIAOMI MI ACCOUNT SIFIRLAMA
echo(
echo %[LRED]%CIHAZI ADB MOD'A ALIN%[WHITE]% | cmdcolor
echo %[LCYAN]%ARDINDAN ASAGIDAN ISLEM SECIN%[WHITE]% | cmdcolor
echo     %[LMAGENTA]%1.  KILIDI KALDIR %[WHITE]%                 | cmdcolor
echo    %[LYELLOW]% 2.  CIHAZI YENIDEN BASLAT %[WHITE]%         | cmdcolor
echo    %[LCYAN]% 3.  ANA MENU'YE DON      %[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1-3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto miaccountsil
if /I %option%==2 goto rebootsystem
if /I %option%==3 goto start
goto start
:miaccountsil
adb shell pm uninstall -k --user 0 com.xiaomi.finddevice
goto start
:testekrani
cls
@echo off
title TEST MENUSU
pause
start cmd-here.exe
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:imajolustur
cls
@echo off
echo %[LYELLOW]%BU ISLEMI MANUEL YAPACAKSINIZ%[WHITE]% | cmdcolor
echo %[LMAGENTA]%ADB SHELL EKRANINA ILK ONCE%[LRED]% su %[LGREEN]%YAZARAK ROOT YETKISINI VERIN%[WHITE]% | cmdcolor
echo %[LCYAN]%SIMDI ASAGIDA ACILAN ADB SHELL EKRANINA ASAGIDAKI KOMUTLARI YAZIN. PARTITIONLAR TAM CIKANA HEPSINI TEK TEK DENEYIN.%[WHITE]% | cmdcolor
echo %[LRED]%ls -la /dev/block  veya ls -la /dev/block/platform/soc/7824900.sdhci/by-name %[WHITE]% | cmdcolor
echo %[LYELLOW]%PARTITIONLAR CIKINCA ASAGIDAKI KODU KULLANIN./ ILE BASLAR PARTITION.%[WHITE]% | cmdcolor
echo %[LMAGENTA]%dd if=cihazin/partitionu of=/sdcard/dosyaninadi.img bs=4096%[WHITE]% | cmdcolor
echo %[LCYAN]%YUKARIDAKI KODI YAZDIKTAN SONRA BEKLEYIN. BIR SURE SONRA CIHAZ HAFIZINDA ISTEDIGINIZ DOSYA .IMG SEKLINDE BELIRECEK. TOOLU KAPATABILIRSINIZ%[WHITE]% | cmdcolor
pause
adb shell
pause
echo %[LCYAN]%/dev/block/boot-device/boot%[WHITE]% | cmdcolor
set /p imaj=ISTEDIGINIZ IMAJIN PARTITIONUNU GIRINIZ.ORNEK YUKARDA.  :
set /p isim=IMAJ ISMI NE OLSUN?  : 
adb shell dd if=%imaj% of=/sdcard/%isim%.img bs=4096
cls
echo %[LMAGENTA]%TELEFON HAFIZASIDA %isim%.img SEKLINDE BELIRECEKTIR. %[WHITE]% | cmdcolor
pause
goto start
:aramayaptirma
cls
@echo off
echo %[LMAGENTA]%Adb Uzerinden Arama Yaptirma FRP Fast Call.%[WHITE]% | cmdcolor
echo %[LYELLOW]%SIM KARTIN TAKILI OLDUGUNDAN EMIN OLUN.%[WHITE]% | cmdcolor
echo %[LCYAN]%Ekran Kilitli Olsa Bile Arama Yapar.%[WHITE]% | cmdcolor
echo %[LRED]%Tek Sart Adb Bagli Olmasi Gereklidir..%[WHITE]% | cmdcolor
pause
cls
set /p tel=Hangi Numarayi Aratmak Istiyorsunuz  : 
cls
adb shell am start -a android.intent.action.CALL -d tel:%tel%
cls
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:trdil
cls
echo %[LCYAN]%Dosyalar Listelendi%[WHITE]% | cmdcolor
dir
echo %[LYELLOW]%Apk Dosyanin Adini Yukaridan Bakiniz%[WHITE]% | cmdcolor
set /p tr= Apk Dosyasinin Adini Giriniz. Sonuna .apk Ekleyin :
pause
cls
adb devices
adb install %tr%
cls
adb shell pm grant jp.co.c_lis.ccl.morelocale android.permission.CHANGE_CONFIGURATION
pause
goto start
:adbpull
cls
echo %[LCYAN]%Dosyalar Listelendi%[WHITE]% | cmdcolor
dir
echo %[LYELLOW]%Apk Dosyanin Adini Yukaridan Bakiniz%[WHITE]% | cmdcolor
set /p apk= Apk Dosyasinin Adini Giriniz. Sonuna .apk Ekleyin :
pause
cls
adb devices
adb install %apk%
pause
goto start
:readinfo
cls
echo %[LRED]%Android Surumu%[WHITE]% | cmdcolor
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
echo %[LBLUE]%Bizi Tercih Ettiginiz Icin Tesekkurler.%[WHITE]% | cmdcolor
pause
exit
echo(
echo %[LRED]%%option% ge‡erli bir se‡enek de§il. Ltfen tekrar deneyin! %[WHITE]% | cmdcolor
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
set /p option=Se‡iminizi yazn [1,2,3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto recoverytek
if /I %option%==2 goto recoverykalici
if /I %option%==3 goto start
goto start
:recoverytek
cls
echo %[LYELLOW]%Recovery'i Tek Seferlik Yuklemeyi Sectiniz.%[WHITE]% | cmdcolor
fastboot devices
fastboot boot recovery.img
pause
goto start
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
echo  %[LRED]%    2.  Kendim Hallederim. %[WHITE]%         | cmdcolor
echo  %[LGREEN]%  3.  Ust Menuye Git%[WHITE]%         | cmdcolor
set/p input=Sec:
if /I %option%==1 goto evet
if /I %option%==2 goto hayir
if /I %option%==3 goto start
goto start
:evet
cls
fastboot boot recovery.img
pause
goto start
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
echo  %[LGREEN]%3.  Ust Menuye Git%[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1,2,3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto ac
if /I %option%==2 goto kapat
if /I %option%==3 goto start
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
set /p option=Se‡iminizi yazn [1,2] ve ENTER'a basn: || set option="0"
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
set /p option=Se‡iminizi yazn [1,2] ve ENTER'a basn: || set option="0"
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
echo %[LRED]%1.  Adb LogCat %[WHITE]%         | cmdcolor
echo %[LMAGENTA]%2.  Adb Dmesg Logu %[WHITE]%         | cmdcolor
echo %[LGREEN]%3.  Ust Menuye Git%[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1,2,3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto adblogcat
if /I %option%==2 goto adbdmesg
if /I %option%==3 goto start
pause
goto start
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
echo  %[LGREEN]%  3. Ust Menuye Git%[WHITE]%         | cmdcolor
set /p option=Se‡iminizi yazn [1,2,3] ve ENTER'a basn: || set option="0"
if /I %option%==1 goto 32bit
if /I %option%==2 goto 64bit
if /I %option%==3 goto start
goto start
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












































:carliv
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:::                                                    :::
:::          Carliv Image Kitchen for Android          :::
:::   boot+recovery images copyright-2016 carliv@xda   :::
:::   including support for MTK powered phones images  :::
:::                                                    :::
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
@echo off
cd "%~dp0"
IF EXIST "%~dp0\bin" SET PATH=%PATH%;"%~dp0\bin"
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Setlocal EnableDelayedExpansion
attrib +h "bin" >nul
attrib +h "scripts" >nul
attrib +h "working" >nul
ufind "%~dp0\bin" "%~dp0\scripts" -regex ".*\.\(exe\|bat\)" -exec chmod +x {} ;
if %errorlevel% neq 0 goto error
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:main
cls
echo( 
echo ***************************************************
echo *                                                 *
cecho *      {0B}Carliv Image Kitchen for Android{#} v1.3      *{\n}
cecho *     boot+recovery images (c)2016 {0B}carliv@xda{#}     *{\n}
cecho * including support for {0E}MTK powered {#}phones images *{\n}
cecho *               {0A}WINDOWS x64 {#}version               *{\n}
echo *                                                 *
echo ***************************************************
echo(
echo  Choose what kind of image you need to work on.
echo(
echo ][**********************][
cecho ][ {0B}B.  BOOT {#}            ][{\n}
echo ][**********************][
cecho ][ {0E}R.  RECOVERY {#}        ][{\n}
echo ][**********************][
cecho ][ {0A}C.  CLEAR FOLDER {#}    ][{\n}
echo ][**********************][
cecho ][ {0D}O.  CLEAR OUTPUT {#}    ][{\n}
echo ][**********************][
echo ][ P.  SEE INSTRUCTIONS ][
echo ][**********************][
cecho ][ {0C}E.  EXIT {#}            ][{\n}
echo ][**********************][
echo(
set /p env=Type your option [B,R,C,O,P,E] then press ENTER: || set env="0"
if /I %env%==B goto boot
if /I %env%==R goto recovery
if /I %env%==C goto delete_all
if /I %env%==O goto delete_output
if /I %env%==P goto instructions
if /I %env%==E goto end
echo(
cecho {0C}%env% is not a valid option. Please try again! {#}{\n}
PING -n 3 127.0.0.1>nul
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:imgmenu
cls
echo(
cecho BU IMAJ DOSYASI SECILIDIR {0A}%workfile%{#}.{\n}
for %%i in ("%workfile%") do set "workfolder=%%~ni"
if %filetype%==bootimage goto setbootfolder
if %filetype%==recoveryimage goto setrecfolder
:setbootfolder
if "%workfolder%"=="%workfolder:boot=%" set "workfolder=boot-%workfolder%"
goto cleanfoldername
:setrecfolder
if "%workfolder%"=="%workfolder:recovery=%" set "workfolder=recovery-%workfolder%"
:cleanfoldername
set workfolder=%workfolder: =_%
if not exist "%workfolder%" goto imgmenulist
cecho ONCELIKLE AYIKLAMA ISINI 1'E BASARAK YAPIN. AYIKLAMA YAPTIYSANIZ EGER UCUNCU ADIMA GECIN {0A}%workfolder%{#}.{\n}
echo SON ADIMDA ISENIZ 2 ^ YE BASARAK PAKETLEMEYI YAPIN
:imgmenulist
cls
echo(
echo.
echo  %[LGREEN]% 1. AYIKLA (ILK OLARAK BUNU SEC)%[WHITE]%| cmdcolor
echo.
echo  %[LYELLOW]% AYIKLADIKTAN SONRA%[WHITE]%| cmdcolor
echo.
echo  %[LGREEN]% 2. BASKA RECOVERY SEC VE AYIKLA %[WHITE]%| cmdcolor
echo.
echo  %[LRED]% BASKA RECOVERY SECIP AYIKLADIKTAN SONRA %[WHITE]%| cmdcolor
echo.
echo  %[LCYAN]% 3. UCUNCU ADIMA GEC %[WHITE]%| cmdcolor
echo.
echo  %[LYELLOW]% P. PAKETLE / TOPLA ( DORDUNCU ADIM )  %[WHITE]%         | cmdcolor
echo.
echo  %[LMAGENTA]% T: DILERSEN TWRP PORTLAYICIYA DON %[WHITE]%| cmdcolor
echo.
echo  %[LRED]% R: SAYFAYI YENILE %[WHITE]%| cmdcolor



echo(
set /p imgenv=Type your option [1,2,3,P,T,R] then press ENTER: || set imgenv="0"
if /I %imgenv%==1 goto img_unpack
if /I %imgenv%==P goto img_repack
if /I %imgenv%==T goto twrpportlayici
if /I %imgenv%==2 goto recovery
if /I %imgenv%==I goto img_info
if /I %imgenv%==R goto imgmenulist
if /I %imgenv%==3 goto ucuncuadim
echo(
echo %[LGREEN]%LUTFEN BIR SECIM YAPINIZ %[WHITE]%| cmdcolor
PING -n 3 127.0.0.1>nul
goto imgmenu
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:boot
set workfile=
set filetype=
set workfolder=
cls
echo ***************************************************
echo *                                                 *
cecho *      {0B}Carliv Image Kitchen for Android{#} v1.3      *{\n}
cecho *     boot+recovery images (c)2016 {0B}carliv@xda{#}     *{\n}
cecho * including support for {0E}MTK powered {#}phones images *{\n}
cecho *               {0A}WINDOWS x64 {#}version               *{\n}
echo *                                                 *
echo ***************************************************
cecho *                {0B}BOOT images{#} section              *{\n}
echo ***************************************************
echo(
for /f %%g in ('dir /b "boot-resources\*.img"') do (
   goto loadboots
)
set /p noboot=LUTFEN BIRINCI ADIMA DONUP STOCK VE PORT RECOVERY DOSYASINI ACILAN KLASORE KOPYALAYINIZ || set noboot="0"
if %noboot%=="0" goto booterror
if /I %noboot%==B goto boot
if /I %noboot%==Q goto start
:loadboots
echo(
set j=0
set maxb=0
echo ---------------------------------------------------
echo -  R. - Refresh.
echo ---------------------------------------------------
echo -  E. - Go to Main menu.
for /r %%h in ("boot-resources\*.img") do (
	set /a j+=1
	echo ---------------------------------------------------
	echo -  !j!. - %%~nxh
	set bootlist!j!=%%~nxh
	if !j! gtr !maxb! set maxb=!j!
)
echo ---------------------------------------------------
echo(
set /p bootopt=Type an image number then press ENTER: || set bootopt="0"
if %bootopt%=="0" goto booterror
if /I %bootopt%==R goto boot
if /I %bootopt%==E goto start
if %bootopt% gtr %maxb% goto booterror
set bootlist=!bootlist%bootopt%!
set workfile=%bootlist%
set filetype=bootimage
copy "boot-resources\%bootlist%" "working\%workfile%" >nul
goto imgmenu
:booterror
echo(
cecho {0C}That is not a valid option. Please try again! {#}{\n}
PING -n 3 127.0.0.1>nul
goto boot
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:recovery
cd "%~dp0"
IF EXIST "%~dp0\bin" SET PATH=%PATH%;"%~dp0\bin"
Setlocal EnableDelayedExpansion
attrib +h "bin" >nul
attrib +h "scripts" >nul
attrib +h "working" >nul
ufind "%~dp0\bin" "%~dp0\scripts" -regex ".*\.\(exe\|bat\)" -exec chmod +x {} ;
if %errorlevel% neq 0 goto error
set workfile=
set filetype=
set workfolder=
cls
echo  %[LGREEN]% ILK ONCE KOPYALADIGINIZ STOCK RECOVERY'I AYIKLAYIN               %[WHITE]%         | cmdcolor
echo  %[LCYAN]% IKINCI OLARAK PORT RECOVERY'I AYIKLAYIN               %[WHITE]%         | cmdcolor
echo  %[LRED]% ARDINDAN "T" HARFINE BASARAK TWRP PORTLAYICIYA GERI DONUN               %[WHITE]%         | cmdcolor
echo(
for /f %%a in ('dir /b "recovery-resources\*.img"') do (
   goto loadrec
)
set /p norec=LUTFEN BIRINCI ADIMA DONUP STOCK VE PORT RECOVERY DOSYASINI ACILAN KLASORE KOPYALAYINIZ 
pause
goto twrpportlayici
if /I %norec%==R goto recovery
if /I %norec%==Q goto twrpportlayici
:loadrec
set i=0
set maxa=0
echo ---------------------------------------------------
echo  %[LRED]% R. - SAYFAYI YENILE               %[WHITE]%         | cmdcolor
echo ---------------------------------------------------
echo  %[LGREEN]% E. - ANA MENUYE DON               %[WHITE]%         | cmdcolor
echo ---------------------------------------------------
echo  %[LMAGENTA]% T. - TWRP PORTLAYICIYA GERI DON               %[WHITE]%         | cmdcolor
echo ---------------------------------------------------
echo.
for /r %%b in ("recovery-resources\*.img") do (
	set /a i+=1
	echo ---------------------------------------------------
	echo -  !i!. - %%~nxb
	set reclist!i!=%%~nxb
	if !i! gtr !maxa! set maxa=!i!
)
echo ---------------------------------------------------
echo(
set /p recopt=ONCE 1 NUMARA SONRA 2 NUMARAYI SECEREK AYIKLAMAYI YAPINIZ!  SECIMINIZ : || set recopt="0"
if %recopt%=="0" goto recerror
if /I %recopt%==R goto recovery
if /I %recopt%==E goto start
if /I %recopt%==T goto twrpportlayici
if %recopt% gtr %maxa% goto recerror
set reclist=!reclist%recopt%!
set workfile=%reclist%
set filetype=recoveryimage
copy "recovery-resources\%reclist%" "working\%workfile%" >nul
goto imgmenu
:recerror
echo(
cecho {0C}LUTFEN BIR SECIM YAPINIZ {#}{\n}
PING -n 3 127.0.0.1>nul
goto recovery
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:img_unpack
cls
copy "scripts\unpack_img.bat" "unpack_img.bat" >nul
if %filetype%==bootimage goto unpackboot
if %filetype%==recoveryimage goto unpackrecovery
:unpackboot
copy "working\%workfile%" boot.img >nul
call unpack_img.bat boot.img %workfolder%
goto endunpack
:unpackrecovery
copy "working\%workfile%" recovery.img >nul
call unpack_img.bat recovery.img %workfolder%
:endunpack
if exist boot.img del boot.img >nul
if exist recovery.img del recovery.img >nul
if exist unpack_img.bat del unpack_img.bat >nul
pause
goto imgmenu
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:img_repack
cls
copy "scripts\repack_img.bat" "repack_img.bat" >nul
call repack_img.bat "%workfolder%"
cecho You can find it in {0E}[output]{#} folder.{\n}
if exist repack_img.bat del repack_img.bat >nul
pause
start explorer.exe "C:\windows\TechnoDevsTool\output"
goto imgmenu
:img_info
cls
copy "scripts\image_info.bat" "image_info.bat" >nul
copy "working\%workfile%" "%workfile%" >nul
call image_info.bat "%workfile%"
if exist "%workfile%" del "%workfile%" >nul
if exist image_info.bat del image_info.bat >nul
pause
goto imgmenu
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:instructions
cls
type "scripts\Instructions.txt"
pause
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:delete_all
cls
copy "scripts\clean_all.bat" "clean_all.bat" >nul
call clean_all.bat
if exist clean_all.bat del clean_all.bat >nul
PING -n 3 127.0.0.1>nul
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:delete_output
cls
copy "scripts\clean_output.bat" "clean_output.bat" >nul
call clean_output.bat
if exist clean_output.bat del clean_output.bat >nul
PING -n 3 127.0.0.1>nul
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:error
echo(
cecho {0C}The scripts and executables can't get execution permissions! The kitchen won't run this way. {#}{\n}
PING -n 3 127.0.0.1>nul
goto end
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:end
echo(
for /f %%a in ("%~dp0\working\*") do del /q "%%a" >nul
PING -n 1 127.0.0.1>nul