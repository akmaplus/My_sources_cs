echo off
rem ��� 楫���� �������� ��� app.exe
set AppName=a2
rem �ᯮ��㥬� ��室���� �� ������ ᮡ�ࠥ��� ���������
set Src=a2.cs
rem ���� � ����� ��������� � ��⥬�� �����
set framework=C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\
rem ���⠢�塞 �ࠢ���� ���� � ���������, ��� ��ଠ�쭮�� ��� ����᪠
Set PATH=%framework%;%PATH%

rem ��뫪� �� �ᯮ��㥬� ��⥬�� ������⥪�, �᫨ ����祭� ��ப� /noconfig - ��易⥫쭮!
rem set RefNET=/r:%framework%mscorlib.dll /r:%framework%System.Core.dll /r:%framework%System.dll /r:%framework%System.Xml.dll

set param=/nologo

rem ���窠 ���� - �⪫�祭�� �⠭���⭮�� 䠩�� ��뫮� csc.rsp, �� � ��⠫��� ��������
rem set param=%param%
rem /noconfig 
rem �������������� ������������ ��������� ������ - ��� �ਬ��
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

rem  ��������� ᮡ�ࠥ��� � ����� ��
rem set param=%param% /out:%OMBIN%%AppName%.exe
set param=%param% /out:%AppName%.exe

rem ��뫪� �� ����
set param=%param% /target:winexe %RefNET%

echo on
Csc.exe %param% %Src%
