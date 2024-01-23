; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "beta access analyze"
#define MyAppVersion "7.1.1.0"
#define MyAppPublisher "Beta Systems DCI Software AG"
#define MyAppExeName "beta access analyze.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{EF566282-CDF7-4381-9448-1022509E7993}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
VersionInfoVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppCopyright=Copyright �  2018 Beta Systems DCI Software AG
DefaultDirName={pf}
DefaultGroupName="Beta Systems DCI\beta access analyze V7.1\{#MyAppName}"
;DisableDirPage=No
DisableProgramGroupPage=yes
OutputDir=E:\Setup\BetaSetup\Output
OutputBaseFilename=beta access analyze
Compression=lzma
SolidCompression=yes
PrivilegesRequired=admin
CreateUninstallRegKey=yes
UninstallFilesDir={app}\{#MyAppName}
AppendDefaultDirName=no
SetupIconFile=E:\Setup\BetaSetup\KeyIcon.ico
UninstallDisplayIcon=E:\Setup\BetaSetup\KeyIcon.ico

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "E:\Setup\BetaSetup\Input\*"; DestDir: "{app}\{#MyAppName}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files


[Icons]
Name: "{group}\beta access analyze"; Filename: "{app}\{#MyAppName}\beta access analyze.exe"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\beta access analyze"; Filename: "{app}\{#MyAppName}\beta access analyze.exe"; Tasks: desktopicon

;[Run]
;Filename: "{app}\{#MyAppName}\beta access analyze.exe"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[code]

function GetUninstallString: string;
var
  sUnInstPath: string;
  sUnInstallString: String;
begin
  Result := '';
  sUnInstPath := ExpandConstant('Software\Microsoft\Windows\CurrentVersion\Uninstall\{{EF566282-CDF7-4381-9448-1022509E7993}_is1'); { Your App GUID/ID }
  sUnInstallString := '';
  if not RegQueryStringValue(HKLM, sUnInstPath, 'UninstallString', sUnInstallString) then
    RegQueryStringValue(HKCU, sUnInstPath, 'UninstallString', sUnInstallString);
  Result := sUnInstallString;
end;

function IsUpgrade: Boolean;
begin
  Result := (GetUninstallString() <> '');
end;

function InitializeSetup: Boolean;
var
  V: Integer;
  iResultCode: Integer;
  sUnInstallString: string;
  
begin
  Result := True; { in case when no previous version is found }
  if RegValueExists(HKEY_LOCAL_MACHINE,'Software\Microsoft\Windows\CurrentVersion\Uninstall\{EF566282-CDF7-4381-9448-1022509E7993}_is1', 'UninstallString') then  { Your App GUID/ID }
  begin
    V := MsgBox(ExpandConstant('An old version of '+ExpandConstant('{#MyAppName}')+' was detected. Do you want to uninstall it?'), mbInformation, MB_YESNO); { Custom Message if App installed }
    if V = IDYES then
    begin
      sUnInstallString := GetUninstallString();
      sUnInstallString :=  RemoveQuotes(sUnInstallString);
      Exec(ExpandConstant(sUnInstallString), '', '', SW_SHOW, ewWaitUntilTerminated, iResultCode);
      Result := True; { if you want to proceed after uninstall }
      { Exit; //if you want to quit after uninstall }
    end
    else
      Result := False; { when older version present and not uninstalled }
  end;
  
	begin  
        if not RegValueExists(HKEY_LOCAL_MACHINE,'Software\Microsoft\Windows\CurrentVersion\Uninstall\{30CFEB84-E0EC-407D-BBCA-97E4AAD27523}_is1', 'UninstallString') then
		begin
			  MsgBox('Please install beta access prerequisites setup .', mbInformation, MB_OK);
			  Result := False;
		end
      end; 
end;

procedure InitializeWizard;
  begin
   WizardForm.DirEdit.Enabled := False;
   WizardForm.DirEdit.Text:=WizardDirValue+'\Beta Systems DCI\beta access analyze V7.1';
   // WizardForm.DirBrowseButton.Enabled := False;      
  end;