echo off
csc.exe /out:"test program2.exe" /t:exe /codepage:866 /nologo a2.cs
csc.exe /out:"test program1.exe" /t:exe /codepage:866 /nologo a1.cs
csc.exe /out:"test program3.exe" /t:exe /codepage:866 /nologo a3.cs

REM /out:appl   - имя конечной программы
REM /t:exe - консольное   /t:winexe  - оконное приложение
REM /codepage:866 - кодовая страница исходника

