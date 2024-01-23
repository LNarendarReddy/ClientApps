@ECHO OFF

echo Installing AMS Win Service...
echo ---------------------------------------------------
NET STOP AMSService
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe "G:\Projects\AMSService\AMSService\bin\Debug\AMSService.exe" -u
echo ---------------------------------------------------
pause
echo Done.