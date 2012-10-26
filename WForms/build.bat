echo off
rem имя целевой аппликаци аля app.exe
set AppName=a2
rem используемые исходники из которых собирается аппликация
set Src=a2.cs
rem путь к папке компилятора и системным либам
set framework=C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\
rem выставляем правильный путь к компилеру, для нормального его запуска
Set PATH=%framework%;%PATH%

rem ссылки на используемые системные библиотеки, если включена строка /noconfig - обязательно!
rem set RefNET=/r:%framework%mscorlib.dll /r:%framework%System.Core.dll /r:%framework%System.dll /r:%framework%System.Xml.dll

set param=/nologo

rem строчка ниже - отключение стандартного файла ссылок csc.rsp, он в каталоге компилера
rem set param=%param%
rem /noconfig 
rem ДОПОЛНИТЕЛЬНЫЕ ОПЦИОНАЛЬНЫЕ ПАРАМЕТРЫ СБОРКИ - для примера
rem set param=%param% /nowarn:1701,1702,1591,1574,0419,0618
rem set param=%param% /nostdlib+
rem set param=%param% /platform:x86
rem set param=%param% /errorreport:prompt
rem set param=%param% /warn:4
rem set param=%param% /define:TRACE
rem set param=%param% /unsafe+ 
rem set param=%param% /checked- 
rem set param=%param% /baseaddress:285212672 
rem set param=%param% /debug+
rem set param=%param% /filealign:4096
rem set param=%param% /optimize-

rem  аппликация собирается в папку ОМ
rem set param=%param% /out:%OMBIN%%AppName%.exe
set param=%param% /out:%AppName%.exe

rem ссылки на либы
set param=%param% /target:winexe %RefNET%

echo on
Csc.exe %param% %Src%
