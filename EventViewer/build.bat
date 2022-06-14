@echo off

rem C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe -target:winexe -reference:Microsoft.VisualBasic.dll %~dp0\FindFiles.cs -win32icon:%~dp0\shell32_55_4.ico
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe %~dp0\EventViewer.cs
if %ERRORLEVEL% equ 0 (
    .\EventViewer.exe
)
echo Press Any Key...
set /P input=
exit