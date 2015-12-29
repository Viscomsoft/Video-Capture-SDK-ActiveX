VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "VideoCap.ocx"
Begin VB.Form Form1 
   Caption         =   "Multiple instance for multiple video device"
   ClientHeight    =   6765
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
   ScaleHeight     =   6765
   ScaleWidth      =   14505
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Height          =   6615
      Left            =   7200
      TabIndex        =   9
      Top             =   0
      Width           =   7095
      Begin VB.ComboBox cboVideoInput2 
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
         TabIndex        =   13
         Top             =   960
         Width           =   3855
      End
      Begin VB.ComboBox cboVideoFormat2 
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
         TabIndex        =   12
         Top             =   600
         Width           =   3855
      End
      Begin VB.ComboBox cboDevice2 
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
         TabIndex        =   11
         Top             =   240
         Width           =   3855
      End
      Begin VB.CommandButton Command2 
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
         Left            =   4320
         TabIndex        =   10
         Top             =   1320
         Width           =   1935
      End
      Begin VIDEOCAPLib.VideoCap VideoCap2 
         Height          =   4575
         Left            =   0
         TabIndex        =   17
         Top             =   1920
         Width           =   6255
         _Version        =   65536
         _ExtentX        =   11033
         _ExtentY        =   8070
         _StockProps     =   0
      End
      Begin VB.Label Label9 
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
         TabIndex        =   16
         Top             =   960
         Width           =   1095
      End
      Begin VB.Label Label7 
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
         TabIndex        =   15
         Top             =   600
         Width           =   1095
      End
      Begin VB.Label Label5 
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
         TabIndex        =   14
         Top             =   240
         Width           =   855
      End
   End
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   4575
      Left            =   120
      TabIndex        =   7
      Top             =   1920
      Width           =   6255
      _Version        =   65536
      _ExtentX        =   11033
      _ExtentY        =   8070
      _StockProps     =   0
   End
   Begin VB.Frame Frame2 
      Height          =   6615
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   7095
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
         Left            =   4320
         TabIndex        =   8
         Top             =   1440
         Width           =   1935
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
         TabIndex        =   3
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
         TabIndex        =   2
         Top             =   600
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
         TabIndex        =   1
         Top             =   960
         Width           =   3855
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
         TabIndex        =   6
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
         TabIndex        =   5
         Top             =   600
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
         TabIndex        =   4
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
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False






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





Private Sub cboDevice2_Click()
  If cboDevice2.ListIndex = cboDevice.ListIndex Then
    MsgBox "You cannot select same video device, try another video device"
  End If
  
    cboVideoInput2.Clear
    cboVideoFormat2.Clear
    
   
   
   VideoCap2.RefreshVideoDevice cboDevice2.ListIndex
    
    For Each myVideoInput2 In Me.VideoCap2.VideoInputs
        cboVideoInput2.AddItem myVideoInput2.Name
    Next

    If cboVideoInput2.ListCount > 0 Then
        cboVideoInput2.ListIndex = 0
    End If
 
    For Each myVideoformat2 In Me.VideoCap2.VideoFormats
        cboVideoFormat2.AddItem myVideoformat2.Name
    Next

    If cboVideoFormat2.ListCount > 0 Then
        cboVideoFormat2.ListIndex = 0
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


ControlCap


VideoCap1.Start


End Sub


Private Sub Command6_Click()
Me.VideoCap1.Pause
End Sub

Private Sub Command7_Click()

End Sub

Private Sub Command2_Click()

ControlCap2


VideoCap2.Start

End Sub

Private Sub Command8_Click()

VideoCap1.ShowFullScreen True

End Sub


Private Sub Form_Load()
Dim mydevice As Device
Dim myVideoformat As VideoFormat
Dim myVideoInput As VideoInput

Dim mydevice2 As Device
Dim myVideoformat2 As VideoFormat
Dim myVideoInput2 As VideoInput




For Each mydevice In Me.VideoCap1.Devices
    cboDevice.AddItem mydevice.Name
Next


If cboDevice.ListCount > 0 Then
    cboDevice.ListIndex = 0
End If

If cboDevice.ListCount < 2 Then
    MsgBox "You should have two video devices when you want to testing this sample"
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


        
        
        
For Each mydevice2 In Me.VideoCap2.Devices
    cboDevice2.AddItem mydevice2.Name
Next


If cboDevice2.ListCount > 0 Then
    cboDevice2.ListIndex = 1
End If
        
        
For Each myVideoInput2 In Me.VideoCap2.VideoInputs
        cboVideoInput2.AddItem myVideoInput2.Name
Next

If cboVideoInput2.ListCount > 0 Then
        cboVideoInput2.ListIndex = 0
End If

For Each myVideoformat2 In Me.VideoCap2.VideoFormats

   Me.cboVideoFormat2.AddItem myVideoformat2.Name

Next

If cboVideoFormat2.ListCount > 0 Then
    cboVideoFormat2.ListIndex = 0
End If



         
        





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





End Sub


Sub ControlCap2()

strDevice = cboDevice2.List(cboDevice2.ListIndex)


deviceIndex = Me.VideoCap2.Devices.FindDevice(strDevice)



If deviceIndex <> -1 Then
        VideoCap2.Device = deviceIndex
End If


strVideoInput = cboVideoInput2.List(cboVideoInput2.ListIndex)
videoinputindex = Me.VideoCap2.VideoInputs.FindVideoInput(strVideoInput)

If videoinputindex <> -1 Then
        VideoCap2.VideoInput = videoinputindex
End If


'Select VideoFormat
strVideoFormat = cboVideoFormat.List(cboVideoFormat.ListIndex)
VideoFormatIndex = Me.VideoCap2.VideoFormats.FindVideoFormat(strVideoFormat)

If VideoFormatIndex <> -1 Then
        VideoCap2.VideoFormat = VideoFormatIndex
End If






End Sub


Private Sub txtText3_Change()
End Sub




Private Sub VideoCap1_DeviceChange()
     RefreshVideoDevice
End Sub

Sub RefreshVideoDevice()

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

