; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "PMS"
#define MyAppVersion "1.7 15-11-2020"
#define MyAppPublisher "GyanaSoft"
#define MyAppURL "http://www.GyanaSoft.com/"
#define MyAppExeName "PMS.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{E3E92DFD-156F-4ADF-8A5F-9E680E2A7E64}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={win}\PMS
; DisableDirPage=yes
AlwaysShowDirOnReadyPage=yes
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputBaseFilename=PMS
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
source: "E:\Setup\PMS\Input\*"; destdir: "{win}\PMS"; flags: ignoreversion recursesubdirs createallsubdirs

[Dirs]

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{win}\PMS\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{win}\PMS\{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{win}\PMS\{#MyAppExeName}"; Tasks: desktopicon

[Registry]


[Run]
Filename: "{win}\PMS\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: shellexec postinstall skipifsilent




