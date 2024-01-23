; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "EHR"
#define MyAppVersion "1.8.2(29-12-2021)"
#define MyAppPublisher "Categis Software Pvt Ltd."
#define MyAppURL "http://www.softwaretogo.de/"
#define MyAppExeName "EHR.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{E3E92DFD-156F-4ADF-8A5F-9E680E2A7E25}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={win}\EHR
; DisableDirPage=yes
AlwaysShowDirOnReadyPage=yes
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputBaseFilename=EHR
Compression=lzma
SolidCompression=yes
DisableProgramGroupPage=yes
UsePreviousTasks=Yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
source: "E:\Setup\AMSSetup\input\*"; destdir: "{win}\EHR"; flags: ignoreversion recursesubdirs createallsubdirs

[Dirs]

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{win}\EHR\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{win}\EHR\{uninstallexe}"
Name: "{commonstartup}\{#MyAppName}"; Filename: "{win}\EHR\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{win}\EHR\{#MyAppExeName}"; Tasks: desktopicon
[Run]
Filename: "{win}\EHR\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: shellexec postinstall skipifsilent