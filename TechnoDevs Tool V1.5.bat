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
title TechnoDevs / GsmTurkey TOOL V1.5
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
echo *               %[LCYAN]%TechnoDevs / GsmTurkey Tool V1.5%[WHITE]%                 * | cmdcolor
echo *              %[LRED]%Emegimiz Kod Dolu SuperSu Sen Bizi Koru %[WHITE]%          * | cmdcolor
echo *  %[LYELLOW]%            TOOL BARIS MIZRAKLI TARAFINDAN KODLANDI         %[WHITE]%  * | cmdcolor
echo *                   %[LGREEN]%TECHNODEVS.ORG / GSMTURKEY.NET    %[WHITE]%           * | cmdcolor
echo ******************************************************************
echo(
echo  Ne yapmak istersin
echo(	
echo  %[LMAGENTA]%1. RECOVERY ISLEMLERI%[LRED]% ($)%[WHITE]%     %[LYELLOW]%       9. FACTORY RESET  %[WHITE]%         * | cmdcolor

echo  %[LYELLOW]%2. OEM KILIDI ISLEMLERI%[LRED]% ($)%[WHITE]%   %[LMAGENTA]%       10. EDL MOD'A AL           %[WHITE]%* | cmdcolor

echo  %[LCYAN]%3. CIHAZI FASTBOOT MOD'A AL%[WHITE]%   %[LGREEN]%       11. CIHAZDAN DOSYA CEK %[WHITE]%    *        | cmdcolor

echo  %[LGREEN]%4. LOG ISLEMLERI%[LRED]% ($) %[WHITE]%                12. %[LCYAN]%CIHAZA DOSYA YUKLE%[LRED]% ($)%[WHITE]% *                    | cmdcolor	

echo  %[LMAGENTA]%5. DIGER ISLEMLER %[WHITE]%                   13. %[LYELLOW]%CIHAZ BILGILERINI OKU %[WHITE]% *           | cmdcolor

echo  %[LYELLOW]%6. STOCK ROM'U KUR %[WHITE]%           %[LMAGENTA]%       14. CIHAZA APK YUKLE %[WHITE]%      *                  | cmdcolor

echo  %[LCYAN]%7. FASTBOOT DRIVER KUR %[WHITE]%             %[LRED]% 15. TR DIL EKLE %[WHITE]%           *    | cmdcolor

echo  %[LRED]%8. FRP GOOGLE KILIDINI SIL %[WHITE]%       %[LCYAN]%   16. ARAMA YAPTIRMA %[WHITE]%        *| cmdcolor


echo                   %[LYELLOW]%"CIKIS YAPMAK ICIN%[LYELLOW]% C %[LYELLOW]%SECINIZ"%[WHITE]% | cmdcolor

echo %[LYELLOW]%"BAZI SECENEKLER ROOTLU CIHAZLAR ICIN GECERLIDIR %[LRED]%$%[LGREEN]% ILE BELIRTILDI"%[WHITE]% | cmdcolor

echo ******************************************************************
echo                          %[LCYAN]%TECHNODEVS.ORG%[WHITE]%                     | cmdcolor

echo   %[LRED]%                          RETZH.XYZ                   %[WHITE]%   | cmdcolor
set /p option=Seáiminizi yazçn [1-16] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto bir
if /I %option%==2 goto iki
if /I %option%==3 goto fastbootmode
if /I %option%==4 goto logislemleri
if /I %option%==5 goto rootlucihaz
if /I %option%==6 goto stockrom
if /I %option%==7 goto adbdriver2
if /I %option%==8 goto frpsil
if /I %option%==C goto exit
if /I %option%==9 goto factoryreset
if /I %option%==10 goto rebootedl
if /I %option%==11 goto adbdendosyacek
if /I %option%==12 goto adbdendosyayukle
if /I %option%==13 goto readinfo
if /I %option%==14 goto adbpull 
if /I %option%==r goto yenile
if /I %option%==15 goto trdil
if /I %option%==16 goto aramayaptirma
if /I %option%==19 goto start
if /I %option%==20 goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
goto start
:adbdendosyayukle
cls
@echo off
echo %[LMAGENTA]%DOSYAYI TOOL'UN BULUNDUGU KLASORE ATINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%YUKLEMEK ISTEDIGINIZ DOSYANIN YOLUNU BILMENIZ GEREKIYOR%[WHITE]% | cmdcolor
echo %[LCYAN]%ROOT GEREKTIRIR%[WHITE]% | cmdcolor
echo %[LRED]%YUKLEYECEGINIZ DOSYANIN ADININ SYSTEM'DEK› ADINI MUTLAKA BILIN%[WHITE]% | cmdcolor
echo %[LBLUE]%ONCE DOSYANIN ADINI SONRA ATACAGINIZ YERI YAZIN%[WHITE]% | cmdcolor
echo %[LGREEN]%CIHAZI ADB MOD'A ALINIZ%[WHITE]% | cmdcolor
echo %[LYELLOW]%BIR ORNEK :framework-res.apk /system/framework%[WHITE]% | cmdcolor
set /p dosyaat=HANGI DOSYAYI YUKLEMEK ISTIYORSUNUZ ? :
adb pull %dosyaat%
cls
echo %[LMAGENTA]%BARIS MIZRAKLI%[WHITE]% | cmdcolor
echo %[LYELLOW]%TEHNODEVS.ORG%[WHITE]% | cmdcolor
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
adb reboot edl
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
echo    %[LYELLOW]% 2.  EKLENECEK %[WHITE]%         | cmdcolor
echo    %[LGREEN]% 3.  EKLENECEK %[WHITE]%         | cmdcolor
echo    %[LCYAN]% 4.  EKLENECEK %[WHITE]%         | cmdcolor
echo    %[LRED]% 5.  Ana Menu'ye Don %[WHITE]%         | cmdcolor
echo %[LYELLOW]%"V2 SURUMUNDE%[LRED]% DEHSET OZELLIKLERIN %[LGREEN]%EKLENMESI PLANLANDI"%[WHITE]% | cmdcolor
set /p option=Seáiminizi yazçn [1-5] ve ENTER'a basçn: || set option="0"
if /I %option%==1 goto imajolustur
if /I %option%==2 goto start
if /I %option%==3 goto start
if /I %option%==4 goto start
if /I %option%==5 goto start
goto start
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:imajolustur
cls
@echo off
echo %[LMAGENTA]%ROOT SARTTIR.%[WHITE]% | cmdcolor
echo %[LYELLOW]%PARTITIONLAR EKRANDA BELIRECEKTIR..%[WHITE]% | cmdcolor
echo %[LCYAN]%SIZ PARTITIONU ASAGIYA YAZACAKSINIZ.%[WHITE]% | cmdcolor
echo %[LRED]%BEN BOOT YEDEGI ALACAGIM: /dev/block/boot-device/boot SIZIN PARTITION FARKLI OLABILIR%[WHITE]% | cmdcolor
pause
adb devices
adb shell su
pause
adb shell ls -al /dev/block/
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
set /p option=Seáiminizi yazçn [1,2,3] ve ENTER'a basçn: || set option="0"
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
echo %[LRED]%1.  Adb LogCat %[WHITE]%         | cmdcolor
echo %[LMAGENTA]%2.  Adb Dmesg Logu %[WHITE]%         | cmdcolor
echo %[LGREEN]%3.  Ust Menuye Git%[WHITE]%         | cmdcolor
set /p option=Seáiminizi yazçn [1,2,3] ve ENTER'a basçn: || set option="0"
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
set /p option=Seáiminizi yazçn [1,2,3] ve ENTER'a basçn: || set option="0"
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
echo     %[LGREEN]%3.  DIKKAT BIR TUSA BASARSANIZ SILECEKTIR %[WHITE]%         | cmdcolor
pause
cls
fastboot erase config
pause
echo %[LRED]%FRP SILINDI.%[WHITE]% | cmdcolor
pause
goto menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::