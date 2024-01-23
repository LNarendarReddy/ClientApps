@ECHO OFF

echo Installing AMS Win Service...
echo ---------------------------------------------------
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe "G:\Projects\AMSService\AMSService\bin\Debug\AMSService.exe"
NET START AMSService
echo ---------------------------------------------------
pause
echo Done.