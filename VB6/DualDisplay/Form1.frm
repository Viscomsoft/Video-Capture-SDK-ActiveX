VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "videocap.ocx"
Begin VB.Form Form1 
   ClientHeight    =   11010
   ClientLeft      =   165
   ClientTop       =   555
   ClientWidth     =   14505
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   11010
   ScaleWidth      =   14505
   StartUpPosition =   3  'Windows Default
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   4575
      Left            =   240
      TabIndex        =   31
      Top             =   3360
      Width           =   6255
      _Version        =   65536
      _ExtentX        =   11033
      _ExtentY        =   8070
      _StockProps     =   0
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Show Monitor 2 Screen"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4560
      TabIndex        =   30
      Top             =   2880
      Width           =   1935
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Hide Monitor 2 Screen"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4560
      TabIndex        =   28
      Top             =   2400
      Width           =   1935
   End
   Begin VB.CheckBox chkdualdisplay 
      Caption         =   "Dual Display"
      Height          =   375
      Left            =   2400
      TabIndex        =   27
      Top             =   2640
      Value           =   1  'Checked
      Width           =   1815
   End
   Begin VB.Frame Frame12 
      Caption         =   "Size                                   Clear Full Screen Type when Full screen mode"
      Height          =   975
      Left            =   0
      TabIndex        =   21
      Top             =   8160
      Width           =   6855
      Begin VB.ComboBox cbomousebutton 
         Height          =   330
         Left            =   3720
         Style           =   2  'Dropdown List
         TabIndex        =   26
         Top             =   600
         Width           =   1455
      End
      Begin VB.ComboBox cbokey 
         Height          =   330
         Left            =   3720
         Style           =   2  'Dropdown List
         TabIndex        =   25
         Top             =   240
         Width           =   1455
      End
      Begin VB.OptionButton Option2 
         Caption         =   "Mouse button"
         Height          =   210
         Left            =   2040
         TabIndex        =   24
         Top             =   720
         Width           =   1575
      End
      Begin VB.OptionButton Option1 
         Caption         =   "Key"
         Height          =   255
         Left            =   2040
         TabIndex        =   23
         Top             =   360
         Value           =   -1  'True
         Width           =   1335
      End
      Begin VB.CommandButton Command8 
         Caption         =   "Full Screen"
         Height          =   375
         Left            =   120
         TabIndex        =   22
         Top             =   360
         Width           =   1575
      End
   End
   Begin VB.Frame Frame3 
      Height          =   2415
      Left            =   11520
      TabIndex        =   10
      Top             =   0
      Width           =   2895
      Begin VB.CheckBox chkaspectratio 
         Caption         =   "Aspect Ratio"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   13
         Top             =   1560
         Value           =   1  'Checked
         Width           =   1695
      End
      Begin VB.CommandButton cmdBackgroundColor 
         Caption         =   "Background Color"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   1080
         TabIndex        =   12
         Top             =   1920
         Width           =   1575
      End
      Begin VB.CheckBox ChkTVMute 
         Caption         =   "TV Mute"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   11
         Top             =   1920
         Value           =   1  'Checked
         Width           =   1695
      End
   End
   Begin VB.Frame Frame2 
      Height          =   2175
      Left            =   0
      TabIndex        =   1
      Top             =   0
      Width           =   11415
      Begin VB.TextBox txtcustomheight 
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
         Height          =   315
         Left            =   10440
         TabIndex        =   20
         Text            =   "240"
         Top             =   720
         Width           =   615
      End
      Begin VB.TextBox txtcustomwidth 
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
         Height          =   315
         Left            =   9000
         TabIndex        =   18
         Text            =   "320"
         Top             =   720
         Width           =   495
      End
      Begin VB.CheckBox chkusecustomvideoformat 
         Caption         =   "Use Custom Video Format"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   210
         Left            =   6120
         TabIndex        =   16
         Top             =   720
         Width           =   2055
      End
      Begin VB.ComboBox cboaudioinput 
         Height          =   330
         Left            =   2280
         Style           =   2  'Dropdown List
         TabIndex        =   15
         Top             =   1800
         Width           =   3855
      End
      Begin VB.ComboBox cboDevice 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   2280
         Style           =   2  'Dropdown List
         TabIndex        =   5
         Top             =   240
         Width           =   3855
      End
      Begin VB.ComboBox cboVideoFormat 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   2280
         Style           =   2  'Dropdown List
         TabIndex        =   4
         Top             =   600
         Width           =   3855
      End
      Begin VB.ComboBox cboAudioDevice 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   2280
         Style           =   2  'Dropdown List
         TabIndex        =   3
         Top             =   1440
         Width           =   3855
      End
      Begin VB.ComboBox cboVideoInput 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   315
         Left            =   2280
         Style           =   2  'Dropdown List
         TabIndex        =   2
         Top             =   960
         Width           =   3855
      End
      Begin VB.Label Label38 
         Caption         =   "Height"
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
         Left            =   9600
         TabIndex        =   19
         Top             =   720
         Width           =   615
      End
      Begin VB.Label Label37 
         Caption         =   "Width"
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
         Left            =   8280
         TabIndex        =   17
         Top             =   720
         Width           =   495
      End
      Begin VB.Label Label32 
         Caption         =   "Audio Input"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   135
         Left            =   120
         TabIndex        =   14
         Top             =   1800
         Width           =   1095
      End
      Begin VB.Label Label1 
         Caption         =   "Device"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   9
         Top             =   240
         Width           =   855
      End
      Begin VB.Label Label2 
         Caption         =   "Video Format"
         BeginProperty Font 
            Name            =   "Arial"
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
         Top             =   600
         Width           =   1095
      End
      Begin VB.Label Label4 
         Caption         =   "Audio Device"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   6.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   120
         TabIndex        =   7
         Top             =   1440
         Width           =   1095
      End
      Begin VB.Label Label6 
         Caption         =   "Video Input"
         BeginProperty Font 
            Name            =   "Arial"
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
         Top             =   960
         Width           =   1095
      End
   End
   Begin MSComDlg.CommonDialog CommonDialog2 
      Left            =   13680
      Top             =   2640
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   13680
      Top             =   3120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Preview"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   2640
      Width           =   1935
   End
   Begin VB.Label Label40 
      Caption         =   "Make sure you have multimonitor display card and selected extend my Window Desktop onto monitor 2 in Display Properties"
      Height          =   255
      Left            =   120
      TabIndex        =   29
      Top             =   2160
      Width           =   9015
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


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


Private Sub Check1_Click()


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
      Me.VideoCap1.UseAudioCompressor = False
Else
    cboAudioCompressor.Enabled = True
      Me.VideoCap1.UseAudioCompressor = False
End If


End Sub

Private Sub chkusecustomvideoformat_Click()
If chkusecustomvideoformat.Value = 1 Then

    txtcustomwidth.Enabled = True
    txtcustomheight.Enabled = True
    
Else
    txtcustomwidth.Enabled = False
    txtcustomheight.Enabled = False


End If
End Sub

Private Sub ChkUseVideoCap_Click()

If ChkUseVideoCap.Value = 0 Then
    cboVideoCompressor.Enabled = False
    Command5.Enabled = False
    Me.VideoCap1.UseVideoCompressor = False
    
Else
    cboVideoCompressor.Enabled = True
    Command5.Enabled = True
    Me.VideoCap1.UseVideoCompressor = True
End If

End Sub

Private Sub cmdBackgroundColor_Click()

CommonDialog2.ShowColor

VideoCap1.BackgroundColor = CommonDialog2.Color
End Sub






Private Sub Command1_Click()

Me.VideoCap1.UseDualDisplay = chkdualdisplay.Value


ControlCap




If chkusecustomvideoformat.Value = 1 Then
    VideoCap1.UseCustomVideoFormat = True
    VideoCap1.CustomVideoWidth = Me.txtcustomwidth.Text
    VideoCap1.CustomVideoHeight = Me.txtcustomheight.Text
    
Else
    VideoCap1.UseCustomVideoFormat = False

End If


VideoCap1.Start


End Sub


Private Sub Command6_Click()
Me.VideoCap1.Pause
End Sub

Private Sub Command7_Click()

End Sub

Private Sub Command2_Click()
VideoCap1.ShowDualScreen False

End Sub

Private Sub Command3_Click()
VideoCap1.ShowDualScreen True

End Sub

Private Sub Command8_Click()

VideoCap1.ShowFullScreen True

End Sub


Private Sub Form_Load()
Dim mydevice As Device
Dim myVideoformat As VideoFormat
Dim myAudioDevice As AudioDevice
Dim myVideoInput As VideoInput

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

VideoCap1.TVMute = True


For Each myAudioInput In VideoCap1.AudioInputPins
        cboaudioinput.AddItem myAudioInput.Name
Next

If cboaudioinput.ListCount > 0 Then
        cboaudioinput.ListIndex = 0
 End If



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


cboAudioDevice.ListIndex = 0



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


VideoCap1.AudioInputPin = cboaudioinput.ListIndex






End Sub


Private Sub txtText3_Change()
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
