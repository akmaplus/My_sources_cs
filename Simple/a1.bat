echo off
csc.exe /out:"test program2.exe" /t:exe /codepage:866 /nologo a2.cs
csc.exe /out:"test program1.exe" /t:exe /codepage:866 /nologo a1.cs
csc.exe /out:"test program3.exe" /t:exe /codepage:866 /nologo a3.cs

REM /out:appl   - ��� ����筮� �ணࠬ��
REM /t:exe - ���᮫쭮�   /t:winexe  - ������� �ਫ������
REM /codepage:866 - ������� ��࠭�� ��室����

