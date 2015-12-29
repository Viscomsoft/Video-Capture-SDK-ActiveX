VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "videocap.ocx"
Begin VB.Form Form1 
   Caption         =   "Capture File Sample"
   ClientHeight    =   8850
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   12105
   LinkTopic       =   "Form1"
   ScaleHeight     =   8850
   ScaleWidth      =   12105
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command8 
      Caption         =   "Close video/audio device"
      Height          =   375
      Left            =   5640
      TabIndex        =   49
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
      TabIndex        =   36
      Top             =   4800
      Width           =   3855
      Begin VB.CommandButton Command7 
         Caption         =   "Resize"
         Height          =   375
         Left            =   2760
         TabIndex        =   48
         Top             =   3000
         Width           =   975
      End
      Begin VB.TextBox txtRWidth 
         Height          =   285
         Left            =   720
         TabIndex        =   44
         Text            =   "100"
         Top             =   3000
         Width           =   615
      End
      Begin VB.TextBox txtRHeight 
         Height          =   285
         Left            =   2040
         TabIndex        =   43
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
         TabIndex        =   38
         Top             =   1200
         Width           =   3615
         Begin VB.ComboBox cbomousebutton 
            Height          =   315
            Left            =   1680
            Style           =   2  'Dropdown List
            TabIndex        =   42
            Top             =   840
            Width           =   1815
         End
         Begin VB.ComboBox cbokey 
            Height          =   315
            Left            =   1680
            Style           =   2  'Dropdown List
            TabIndex        =   41
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
            TabIndex        =   40
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
            TabIndex        =   39
            Top             =   360
            Value           =   -1  'True
            Width           =   1095
         End
      End
      Begin VB.CommandButton Command9 
         Caption         =   "Full Screen"
         Height          =   375
         Left            =   120
         TabIndex        =   37
         Top             =   360
         Width           =   1455
      End
      Begin VB.Label Label7 
         Caption         =   "Resize"
         Height          =   255
         Left            =   120
         TabIndex        =   47
         Top             =   2640
         Width           =   615
      End
      Begin VB.Label Label8 
         Caption         =   "Width"
         Height          =   255
         Left            =   120
         TabIndex        =   46
         Top             =   3000
         Width           =   495
      End
      Begin VB.Label Label9 
         Caption         =   "Height"
         Height          =   255
         Left            =   1440
         TabIndex        =   45
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
      TabIndex        =   31
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
         TabIndex        =   34
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
         TabIndex        =   32
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
         TabIndex        =   35
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
         TabIndex        =   33
         Top             =   600
         Width           =   1095
      End
   End
   Begin VB.ComboBox cbovideostand 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   30
      Top             =   1200
      Width           =   3855
   End
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   3615
      Left            =   3360
      TabIndex        =   28
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
      TabIndex        =   27
      Top             =   1920
      Width           =   3855
   End
   Begin VB.CommandButton Command6 
      Caption         =   "Resume"
      Height          =   375
      Left            =   8280
      TabIndex        =   25
      Top             =   4080
      Width           =   1095
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Pause"
      Height          =   375
      Left            =   7080
      TabIndex        =   24
      Top             =   4080
      Width           =   1095
   End
   Begin VB.CommandButton Command5 
      Caption         =   "Setting"
      Enabled         =   0   'False
      Height          =   375
      Left            =   3960
      TabIndex        =   23
      Top             =   3240
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
      TabIndex        =   22
      Top             =   6480
      Value           =   1  'Checked
      Width           =   1695
   End
   Begin VB.ComboBox cboVideoInput 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   21
      Top             =   840
      Width           =   3855
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
      TabIndex        =   19
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
      TabIndex        =   18
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
      TabIndex        =   17
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
      TabIndex        =   16
      Top             =   5040
      Value           =   1  'Checked
      Width           =   2535
   End
   Begin VB.CheckBox ChkUseAudioCap 
      Caption         =   "Use Audio Compressor when Capture"
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
      Left            =   5640
      TabIndex        =   15
      Top             =   2400
      Value           =   1  'Checked
      Width           =   2535
   End
   Begin VB.CheckBox ChkUseVideoCap 
      Caption         =   "Use Video Compressor when Capture"
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
      Left            =   5640
      TabIndex        =   14
      Top             =   2880
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
      TabIndex        =   13
      Top             =   4680
      Value           =   1  'Checked
      Width           =   2535
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Stop Capture"
      Enabled         =   0   'False
      Height          =   375
      Left            =   5760
      TabIndex        =   12
      Top             =   4080
      Width           =   1095
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   6960
      Top             =   3120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Capture"
      Height          =   375
      Left            =   4440
      TabIndex        =   11
      Top             =   4080
      Width           =   1095
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Preview"
      Height          =   375
      Left            =   3360
      TabIndex        =   10
      Top             =   4080
      Width           =   975
   End
   Begin VB.ComboBox cboVideoCompressor 
      Height          =   315
      Left            =   1680
      TabIndex        =   9
      Top             =   2880
      Width           =   3855
   End
   Begin VB.ComboBox cboAudioDevice 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   7
      Top             =   1560
      Width           =   3855
   End
   Begin VB.ComboBox cboAudioCompressor 
      Height          =   315
      Left            =   1680
      TabIndex        =   5
      Top             =   2400
      Width           =   3855
   End
   Begin VB.ComboBox cboVideoFormat 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   3
      Top             =   480
      Width           =   3855
   End
   Begin VB.ComboBox cboDevice 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   0
      Top             =   120
      Width           =   3855
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
      TabIndex        =   29
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
      TabIndex        =   26
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
      TabIndex        =   20
      Top             =   840
      Width           =   1095
   End
   Begin VB.Label Label5 
      Caption         =   "Video Compressor"
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
      TabIndex        =   8
      Top             =   2880
      Width           =   1575
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
      TabIndex        =   6
      Top             =   1560
      Width           =   1095
   End
   Begin VB.Label Label3 
      Caption         =   "Audio Compressor"
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
      Top             =   2400
      Width           =   1575
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

Private Sub Check1_Click()

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

Me.CommonDialog1.Filter = "Avi File (*.avi)|*.avi"

Me.CommonDialog1.ShowSave

Me.VideoCap1.CaptureVideo = Me.chkCaptureVideo.Value
Me.VideoCap1.CaptureAudio = Me.ChkCaptureAudio.Value

Me.VideoCap1.ShowPreview = Me.chkShowPreview.Value
Me.VideoCap1.UseVideoCompressor = Me.ChkUseVideoCap.Value
Me.VideoCap1.UseAudioCompressor = Me.ChkUseAudioCap.Value


Me.VideoCap1.CaptureMode = True
Me.VideoCap1.CaptureFileName = Me.CommonDialog1.FileName

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


strVideoCompressor = cboVideoCompressor.List(cboVideoCompressor.ListIndex)
VideoCompressorIndex = Me.VideoCap1.VideoCompressors.FindVideoCompressor(strVideoCompressor)


result = VideoCap1.VideoCompressors.ShowPropertyPage(VideoCompressorIndex)

If result = False Then
    MsgBox "No property page"
End If



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


iCount = 0

For Each myAudioCompressor In Me.VideoCap1.AudioCompressors
    cboAudioCompressor.AddItem myAudioCompressor.Name
    
    If myAudioCompressor.Name = "PCM" Then
            cboAudioCompressor.ListIndex = iCount
     End If
    iCount = iCount + 1
Next





iCount = 0
For Each myVideoCompressor In Me.VideoCap1.VideoCompressors
    cboVideoCompressor.AddItem myVideoCompressor.Name
     If myVideoCompressor.Name = "Microsoft Video 1" Then
            cboVideoCompressor.ListIndex = iCount
     End If
     iCount = iCount + 1
        
Next





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

'Video Compressor

strVideoCompressor = cboVideoCompressor.List(cboVideoCompressor.ListIndex)
VideoCompressorIndex = Me.VideoCap1.VideoCompressors.FindVideoCompressor(strVideoCompressor)


If VideoCompressorIndex <> -1 Then
        VideoCap1.VideoCompressor = VideoCompressorIndex
End If


strAudioCompressor = cboAudioCompressor.List(cboAudioCompressor.ListIndex)
AudioCompressorIndex = Me.VideoCap1.AudioCompressors.FindAudioCompressor(strAudioCompressor)

If AudioCompressorIndex <> -1 Then
        VideoCap1.AudioCompressor = AudioCompressorIndex
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
        cboDevice.ListIndex = 0
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
