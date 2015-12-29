VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "VideoCap.ocx"
Object = "{C99E4EFC-CCD5-4F78-B574-EB2CF6CE842C}#1.0#0"; "WMVProfileEditor.ocx"
Begin VB.Form Form1 
   Caption         =   "Capture to WMV file"
   ClientHeight    =   8850
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   12105
   LinkTopic       =   "Form1"
   ScaleHeight     =   8850
   ScaleWidth      =   12105
   StartUpPosition =   3  'Windows Default
   Begin WMVPROFILEEDITORLib.WMVProfileEditor WMVProfileEditor1 
      Height          =   375
      Left            =   6120
      TabIndex        =   47
      Top             =   3360
      Width           =   495
      _Version        =   65536
      _ExtentX        =   873
      _ExtentY        =   661
      _StockProps     =   0
   End
   Begin VB.Frame Frame4 
      Height          =   975
      Left            =   120
      TabIndex        =   43
      Top             =   2280
      Width           =   6255
      Begin VB.ComboBox cbowmv8 
         Height          =   315
         Left            =   1320
         Style           =   2  'Dropdown List
         TabIndex        =   46
         Top             =   240
         Width           =   4815
      End
      Begin VB.OptionButton Option4 
         Caption         =   "WMV 9 (Profile Created from WMV Profile Editor ActiveX)"
         Height          =   255
         Left            =   120
         TabIndex        =   45
         Top             =   600
         Width           =   4815
      End
      Begin VB.OptionButton optwmv8 
         Caption         =   "WMV 8"
         Height          =   255
         Left            =   120
         TabIndex        =   44
         Top             =   240
         Value           =   -1  'True
         Width           =   1095
      End
   End
   Begin VB.CommandButton Command8 
      Caption         =   "Close video/audio device"
      Height          =   375
      Left            =   6360
      TabIndex        =   42
      Top             =   120
      Width           =   2055
   End
   Begin VB.Frame Frame2 
      Caption         =   "Size"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3495
      Left            =   8040
      TabIndex        =   29
      Top             =   4800
      Width           =   3855
      Begin VB.CommandButton Command7 
         Caption         =   "Resize"
         Height          =   375
         Left            =   2760
         TabIndex        =   41
         Top             =   3000
         Width           =   975
      End
      Begin VB.TextBox txtRWidth 
         Height          =   285
         Left            =   720
         TabIndex        =   37
         Text            =   "100"
         Top             =   3000
         Width           =   615
      End
      Begin VB.TextBox txtRHeight 
         Height          =   285
         Left            =   2040
         TabIndex        =   36
         Text            =   "100"
         Top             =   3000
         Width           =   615
      End
      Begin VB.Frame Frame3 
         Caption         =   "Clear Full Screen Type when Full screen mode"
         BeginProperty Font 
            Name            =   "Verdana"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1215
         Left            =   120
         TabIndex        =   31
         Top             =   1200
         Width           =   3615
         Begin VB.ComboBox cbomousebutton 
            Height          =   315
            Left            =   1680
            Style           =   2  'Dropdown List
            TabIndex        =   35
            Top             =   840
            Width           =   1815
         End
         Begin VB.ComboBox cbokey 
            Height          =   315
            Left            =   1680
            Style           =   2  'Dropdown List
            TabIndex        =   34
            Top             =   360
            Width           =   1815
         End
         Begin VB.OptionButton Option2 
            Caption         =   "Mouse Button"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   6.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   240
            TabIndex        =   33
            Top             =   840
            Width           =   1335
         End
         Begin VB.OptionButton Option1 
            Caption         =   "Key"
            BeginProperty Font 
               Name            =   "Verdana"
               Size            =   6.75
               Charset         =   0
               Weight          =   400
               Underline       =   0   'False
               Italic          =   0   'False
               Strikethrough   =   0   'False
            EndProperty
            Height          =   255
            Left            =   240
            TabIndex        =   32
            Top             =   360
            Value           =   -1  'True
            Width           =   1095
         End
      End
      Begin VB.CommandButton Command9 
         Caption         =   "Full Screen"
         Height          =   375
         Left            =   120
         TabIndex        =   30
         Top             =   360
         Width           =   1455
      End
      Begin VB.Label Label7 
         Caption         =   "Resize"
         Height          =   255
         Left            =   120
         TabIndex        =   40
         Top             =   2640
         Width           =   615
      End
      Begin VB.Label Label8 
         Caption         =   "Width"
         Height          =   255
         Left            =   120
         TabIndex        =   39
         Top             =   3000
         Width           =   495
      End
      Begin VB.Label Label9 
         Caption         =   "Height"
         Height          =   255
         Left            =   1440
         TabIndex        =   38
         Top             =   3000
         Width           =   495
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Sync Mode"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   120
      TabIndex        =   24
      Top             =   3360
      Width           =   3135
      Begin VB.TextBox txtoffset 
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   1320
         TabIndex        =   27
         Text            =   "1"
         Top             =   600
         Width           =   615
      End
      Begin VB.ComboBox cbosync 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   300
         Left            =   120
         Style           =   2  'Dropdown List
         TabIndex        =   25
         Top             =   240
         Width           =   2895
      End
      Begin VB.Label Label14 
         Caption         =   "ms"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   2160
         TabIndex        =   28
         Top             =   600
         Width           =   495
      End
      Begin VB.Label Label13 
         Caption         =   "Audio Offset"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   26
         Top             =   600
         Width           =   1095
      End
   End
   Begin VB.ComboBox cbovideostand 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   23
      Top             =   1200
      Width           =   4575
   End
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   3615
      Left            =   3360
      TabIndex        =   21
      Top             =   4800
      Width           =   4335
      _Version        =   65536
      _ExtentX        =   7646
      _ExtentY        =   6376
      _StockProps     =   0
   End
   Begin VB.ComboBox cboaudioinput 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   20
      Top             =   1920
      Width           =   4575
   End
   Begin VB.CommandButton Command6 
      Caption         =   "Resume"
      Height          =   375
      Left            =   8280
      TabIndex        =   18
      Top             =   4080
      Width           =   1095
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Pause"
      Height          =   375
      Left            =   7080
      TabIndex        =   17
      Top             =   4080
      Width           =   1095
   End
   Begin VB.CheckBox ChkTVMute 
      Caption         =   "TV Mute"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   16
      Top             =   6480
      Value           =   1  'Checked
      Width           =   1695
   End
   Begin VB.ComboBox cboVideoInput 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   15
      Top             =   840
      Width           =   4575
   End
   Begin MSComDlg.CommonDialog CommonDialog2 
      Left            =   7800
      Top             =   3480
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton cmdBackgroundColor 
      Caption         =   "Background Color"
      Height          =   375
      Left            =   480
      TabIndex        =   13
      Top             =   7080
      Width           =   1575
   End
   Begin VB.CheckBox chkaspectratio 
      Caption         =   "Aspect Ratio"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   12
      Top             =   6000
      Value           =   1  'Checked
      Width           =   1695
   End
   Begin VB.CheckBox chkCaptureVideo 
      Caption         =   "Capture Video"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   11
      Top             =   5520
      Value           =   1  'Checked
      Width           =   1695
   End
   Begin VB.CheckBox ChkCaptureAudio 
      Caption         =   "Capture Audio"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   10
      Top             =   5040
      Value           =   1  'Checked
      Width           =   2535
   End
   Begin VB.CheckBox chkShowPreview 
      Caption         =   "Show Preview when Capture"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   9
      Top             =   4680
      Value           =   1  'Checked
      Width           =   2535
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Stop Capture"
      Enabled         =   0   'False
      Height          =   375
      Left            =   5760
      TabIndex        =   8
      Top             =   4080
      Width           =   1095
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   8280
      Top             =   3480
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Capture"
      Height          =   375
      Left            =   4440
      TabIndex        =   7
      Top             =   4080
      Width           =   1095
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Preview"
      Height          =   375
      Left            =   3360
      TabIndex        =   6
      Top             =   4080
      Width           =   975
   End
   Begin VB.ComboBox cboAudioDevice 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   5
      Top             =   1560
      Width           =   4575
   End
   Begin VB.ComboBox cboVideoFormat 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   3
      Top             =   480
      Width           =   4575
   End
   Begin VB.ComboBox cboDevice 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   0
      Top             =   120
      Width           =   4575
   End
   Begin VB.Label Label11 
      Caption         =   "Video Stand"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   22
      Top             =   1200
      Width           =   1095
   End
   Begin VB.Label Label10 
      Caption         =   "Audio Input"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   19
      Top             =   1920
      Width           =   1095
   End
   Begin VB.Label Label6 
      Caption         =   "Video Input"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   14
      Top             =   840
      Width           =   1095
   End
   Begin VB.Label Label4 
      Caption         =   "Audio Device"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   4
      Top             =   1560
      Width           =   1095
   End
   Begin VB.Label Label2 
      Caption         =   "Video Format"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Top             =   480
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Device"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   855
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim tmpWMVFilePath As String

Sub WMV9ProfileSetting()

iVideoCodecIndex = WMVProfileEditor1.FindVideoCodec("Windows Media Video 9")



If iVideoCodecIndex = -1 Then
   iVideoCodecIndex = 0
End If



iAudioCodecIndex = WMVProfileEditor1.FindAudioCodec("Windows Media Audio 9.2")



If iAudioCodecIndex = -1 Then
    iAudioCodecIndex = 0
End If


iAudioFormatIndex = WMVProfileEditor1.FindAudioFormat("160 kbps, 44 kHz, stereo CBR")


If iAudioFormatIndex = -1 Then
    iAudioFormatIndex = 0
End If

'english
iLangIndex = 34

'2500kbps
WMVProfileEditor1.AddVideoStream iVideoCodecIndex, 500000, 100, 720, 480, 15, 1, 0, 0, 0, 500000, 0, False, iLangIndex

If cboAudioDevice.ListCount > 0 Then
    WMVProfileEditor1.AddAudioStream iAudioCodecIndex, iAudioFormatIndex, 3000, False, iLangIndex
End If


tmpWMVFilePath = WMVProfileEditor1.GetTempPath

tmpWMVFilePath = tmpWMVFilePath + "\temp.prx"

WMVProfileEditor1.Save "test", "", tmpWMVFilePath





End Sub


Private Sub cboAudioDevice_Click()

cboaudioinput.Clear

VideoCap1.RefreshAudioInputPin cboAudioDevice.ListIndex

For Each myAudioInput In VideoCap1.AudioInputPins
        cboaudioinput.AddItem myAudioInput.Name
Next

If cboaudioinput.ListCount > 0 Then
        cboaudioinput.ListIndex = 0
 End If

End Sub

Private Sub cboDevice_Click()
  
    cboVideoInput.Clear
    cboVideoFormat.Clear
    
   
   VideoCap1.RefreshVideoDevice cboDevice.ListIndex
    
  For Each myVideoInput In Me.VideoCap1.VideoInputs
        cboVideoInput.AddItem myVideoInput.Name
    Next

    If cboVideoInput.ListCount > 0 Then
        cboVideoInput.ListIndex = 0
    End If
 
    For Each myVideoformat In Me.VideoCap1.VideoFormats
        cboVideoFormat.AddItem myVideoformat.Name
    Next

    If cboVideoFormat.ListCount > 0 Then
        cboVideoFormat.ListIndex = 0
    End If
    
End Sub

Private Sub cbokey_Click()
Control_Clearfullscreenkey
End Sub

Private Sub cbomousebutton_Click()
Control_Clearfullscreenkey
End Sub

Private Sub cbosync_Click()


If cbosync.ListIndex = 2 Then
    txtoffset.Enabled = True
Else
    txtoffset.Enabled = False
End If


End Sub

Private Sub chkaspectratio_Click()

If chkaspectratio.Value = 1 Then
    Me.VideoCap1.AspectRatio = True
Else

    Me.VideoCap1.AspectRatio = False
End If




End Sub

Private Sub ChkTVMute_Click()
If ChkTVMute.Value = 0 Then
    VideoCap1.TVMute = False
Else
    VideoCap1.TVMute = True
End If


End Sub

Private Sub ChkUseAudioCap_Click()

If ChkUseAudioCap.Value = 0 Then
    cboAudioCompressor.Enabled = False
Else
    cboAudioCompressor.Enabled = True
End If


End Sub

Private Sub chkusecustomvideoformat_Click()


End Sub

Private Sub ChkUseVideoCap_Click()

If ChkUseVideoCap.Value = 0 Then
    cboVideoCompressor.Enabled = False
    Command5.Enabled = False
Else
    cboVideoCompressor.Enabled = True
    Command5.Enabled = True
End If

End Sub

Private Sub cmdBackgroundColor_Click()

CommonDialog2.ShowColor

VideoCap1.BackgroundColor = CommonDialog2.Color
End Sub

Private Sub Combo1_Change()

End Sub

Private Sub Command1_Click()


ControlCap

Me.VideoCap1.VideoStandard = cbovideostand.ListIndex

Me.VideoCap1.AudioInputPin = cboaudioinput.ListIndex

Me.VideoCap1.SyncMode = cbosync.ListIndex

Me.VideoCap1.SyncStreamOffset = txtoffset



Me.VideoCap1.Start



End Sub

Private Sub Command2_Click()


ControlCap

Me.VideoCap1.VideoStandard = cbovideostand.ListIndex

Me.VideoCap1.AudioInputPin = cboaudioinput.ListIndex

Me.CommonDialog1.Filter = "WMV File (*.wmv)|*.wmv"

Me.CommonDialog1.ShowSave

Me.VideoCap1.CaptureVideo = Me.chkCaptureVideo.Value
Me.VideoCap1.CaptureAudio = Me.ChkCaptureAudio.Value

Me.VideoCap1.ShowPreview = Me.chkShowPreview.Value

Me.VideoCap1.CaptureMode = True
Me.VideoCap1.OutputWMV = True
Me.VideoCap1.CaptureFileName = Me.CommonDialog1.FileName



If optwmv8.Value = True Then
    Me.VideoCap1.WMVProfile = cbowmv8.ListIndex
Else
    MsgBox "wmv9"
    WMV9ProfileSetting
    Me.VideoCap1.WMVCustomFileName = tmpWMVFilePath
End If


Me.VideoCap1.SyncMode = cbosync.ListIndex

Me.VideoCap1.SyncStreamOffset = txtoffset


result = Me.VideoCap1.Start

If result = -1 Then
    MsgBox "Capture Failure,Video, Audio Compressor not correct or capture file opening"
    Exit Sub
End If

If result = -2 Then
    MsgBox "Capture file not found"
    Exit Sub
End If
Command1.Enabled = False
Command2.Enabled = False
Command3.Enabled = True
End Sub

Private Sub Command3_Click()
Me.VideoCap1.ShowPreview = True
Me.VideoCap1.CaptureMode = False
Me.VideoCap1.Stop
Me.VideoCap1.Start


Command1.Enabled = True
Command2.Enabled = True
Command3.Enabled = False

End Sub


Private Sub Command4_Click()
Me.VideoCap1.Pause

End Sub

Private Sub Command5_Click()



End Sub



Private Sub Command6_Click()
Me.VideoCap1.Resume
End Sub

Private Sub Command7_Click()
VideoCap1.ResizeControl txtRWidth, txtRHeight
End Sub

Private Sub Command8_Click()
VideoCap1.Unload
End Sub


Private Sub Command9_Click()

 VideoCap1.ShowFullScreen True
End Sub

Sub Control_Clearfullscreenkey()

If Option1.Value = True Then
   Me.VideoCap1.ClearFullScreenType = 0
   
   Select Case Me.cbokey.ListIndex
    Case 0
            Me.VideoCap1.ClearFullScreenKey = 27 'esc
    Case 1
            Me.VideoCap1.ClearFullScreenKey = 13  'enter
    Case 2
            Me.VideoCap1.ClearFullScreenKey = 32 'space bar
     Case 3
            Me.VideoCap1.ClearFullScreenKey = 81 'q key
   End Select
 
    
Else
   Me.VideoCap1.ClearFullScreenType = 1
   Me.VideoCap1.ClearFullScreenMouseButton = cbomousebutton.ListIndex
End If


End Sub





Private Sub Form_Load()


Dim profile As WMVProfile

For Each profile In Me.VideoCap1.WMVProfiles

    Me.cbowmv8.AddItem profile.Name
Next


If Me.cbowmv8.ListCount > 0 Then

    Me.cbowmv8.ListIndex = 0
End If



VideoCap1.RegisterMsg

cbokey.AddItem "Esc Key"
cbokey.AddItem "Enter Key"
cbokey.AddItem "SpaceBar Key"
cbokey.AddItem "Q Key"
cbokey.ListIndex = 0

cbomousebutton.AddItem "Left ButtonDown"
cbomousebutton.AddItem "Left ButtonDblClk"
cbomousebutton.AddItem "Right ButtonDown"
cbomousebutton.AddItem "Right ButtonDblClk"
cbomousebutton.ListIndex = 0


Dim mydevice As Device
Dim myVideoformat As VideoFormat
Dim myAudioCompressor As AudioCompressor
Dim myAudioDevice As AudioDevice
Dim myVideoCompressor As VideoCompressor
Dim myVideoInput As VideoInput


cbosync.AddItem "No Sync"
cbosync.AddItem "Sync with stream offset (Auto Mode)"
cbosync.AddItem "Sync with stream offset (Manual Mode)"
cbosync.ListIndex = 1

VideoCap1.TVMute = True


For Each mydevice In Me.VideoCap1.Devices
    cboDevice.AddItem mydevice.Name
Next


If cboDevice.ListCount > 0 Then
    cboDevice.ListIndex = 0
End If



For Each myVideoInput In Me.VideoCap1.VideoInputs
        cboVideoInput.AddItem myVideoInput.Name
Next

If cboVideoInput.ListCount > 0 Then
        cboVideoInput.ListIndex = 0
 End If
 
        

For Each myVideoformat In Me.VideoCap1.VideoFormats
   Me.cboVideoFormat.AddItem myVideoformat.Name
Next

If cboVideoFormat.ListCount > 0 Then
    cboVideoFormat.ListIndex = 0
End If



For Each myAudioDevice In Me.VideoCap1.AudioDevices
    cboAudioDevice.AddItem myAudioDevice.Name

Next

If cboAudioDevice.ListCount > 0 Then
    cboAudioDevice.ListIndex = 0
End If


'For Each myAudioInput In VideoCap1.AudioInputPins
 '       cboaudioinput.AddItem myAudioInput.Name
'Next

'If cboaudioinput.ListCount > 0 Then
 '       cboaudioinput.ListIndex = 0
 'End If





cbovideostand.AddItem ("Digital sensor")
cbovideostand.AddItem ("NTSC (M) standard, 7.5 IRE black")
cbovideostand.AddItem ("NTSC (M) standard, 0 IRE black (Japan)")
cbovideostand.AddItem ("NTSC-433")
cbovideostand.AddItem ("PAL -B standard")
cbovideostand.AddItem ("PAL (D) standard")
cbovideostand.AddItem ("PAL (H) standard")
cbovideostand.AddItem ("PAL (I) standard")
cbovideostand.AddItem ("PAL (M) standard")
cbovideostand.AddItem ("PAL (N) standard")
cbovideostand.AddItem ("PAL-60 standard")
cbovideostand.AddItem ("SECAM (B) standard")
cbovideostand.AddItem ("SECAM (D) standard")
cbovideostand.AddItem ("SECAM (G) standard")
cbovideostand.AddItem ("SECAM (H) standard")
cbovideostand.AddItem ("SECAM (K) standard")
cbovideostand.AddItem ("SECAM (K1) standard")
cbovideostand.AddItem ("SECAM (L) standard")
cbovideostand.AddItem ("SECAM (L1) standard")
cbovideostand.AddItem ("Combination (N) PAL standard (Argentina) ")

cbovideostand.ListIndex = 0


End Sub

Sub ControlCap()

strDevice = cboDevice.List(cboDevice.ListIndex)
deviceIndex = Me.VideoCap1.Devices.FindDevice(strDevice)

If deviceIndex <> -1 Then
        VideoCap1.Device = deviceIndex
End If


strVideoInput = cboVideoInput.List(cboVideoInput.ListIndex)
videoinputindex = Me.VideoCap1.VideoInputs.FindVideoInput(strVideoInput)

If videoinputindex <> -1 Then
        VideoCap1.VideoInput = videoinputindex
End If


'Select VideoFormat
strVideoFormat = cboVideoFormat.List(cboVideoFormat.ListIndex)
VideoFormatIndex = Me.VideoCap1.VideoFormats.FindVideoFormat(strVideoFormat)

If VideoFormatIndex <> -1 Then
        VideoCap1.VideoFormat = VideoFormatIndex
End If

'Audio Device
strAudioDevice = cboAudioDevice.List(cboAudioDevice.ListIndex)
AudioIndex = Me.VideoCap1.AudioDevices.FindDevice(strAudioDevice)

If AudioIndex <> -1 Then
            VideoCap1.AudioDevice = AudioIndex
End If




End Sub

Sub RefreshVideoDevice()

   ' VideoCap1.Device = cboDevice.ListIndex
    VideoCap1.RefreshVideoDevice cboDevice.ListIndex
    
    
    cboDevice.Clear
    cboVideoInput.Clear
    cboVideoFormat.Clear
    
    
    For Each mydevice In Me.VideoCap1.Devices
        cboDevice.AddItem mydevice.Name
    Next

     If cboDevice.ListCount > 0 Then
        cboDevice.ListIndex = VideoCap1.Device
     End If
     
    
    For Each myVideoInput In Me.VideoCap1.VideoInputs
        cboVideoInput.AddItem myVideoInput.Name
    Next

    If cboVideoInput.ListCount > 0 Then
        cboVideoInput.ListIndex = 0
    End If
 
    For Each myVideoformat In Me.VideoCap1.VideoFormats
        cboVideoFormat.AddItem myVideoformat.Name
    Next

    If cboVideoFormat.ListCount > 0 Then
        cboVideoFormat.ListIndex = 0
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
VideoCap1.UnRegisterMsg
Me.WMVProfileEditor1.DeleteTempFile tmpWMVFilePath
End Sub

Private Sub Option1_Click()
cbokey.Enabled = True
cbomousebutton.Enabled = False

Control_Clearfullscreenkey
End Sub

Private Sub Option2_Click()
cbokey.Enabled = False
cbomousebutton.Enabled = True
Control_Clearfullscreenkey
End Sub

Private Sub VideoCap1_CustomVideoFormatError()
MsgBox "Custom video format failed, it does not support this custom resolution"
End Sub

Private Sub VideoCap1_DeviceChange()
    RefreshVideoDevice
End Sub
