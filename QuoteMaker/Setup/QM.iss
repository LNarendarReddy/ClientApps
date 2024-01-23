; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "QuoteMaker"
#define MyAppVersion "1.0.0(17-06-2023)"
#define MyAppPublisher "N SOFT SOLUTIONS"
#define MyAppURL "http://www.nsoftsol.com/"
#define MyAppExeName "QuoteMaker.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{9C684E60-D548-41F9-8E18-FE1C00C9C3C0}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={win}\QuoteMaker
; DisableDirPage=yes
AlwaysShowDirOnReadyPage=yes
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputBaseFilename=QuoteMakerInstaller
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
source: "..\QuoteMaker\bin\Release\*"; destdir: "{win}\QuoteMaker"; flags: ignoreversion recursesubdirs createallsubdirs

[Dirs]

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{win}\QuoteMaker\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{win}\QuoteMaker\{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{win}\QuoteMaker\{#MyAppExeName}"; Tasks: desktopicon
[Run]
Filename: "{win}\QuoteMaker\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: shellexec postinstall skipifsilent