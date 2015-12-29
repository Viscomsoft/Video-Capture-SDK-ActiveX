VERSION 5.00
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "VideoCap.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form Form1 
   Caption         =   "TV Tuner Demo"
   ClientHeight    =   8040
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9720
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   6.75
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   8040
   ScaleWidth      =   9720
   StartUpPosition =   3  'Windows Default
   Begin VB.ComboBox cboTunerMode 
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
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   25
      Top             =   2520
      Width           =   2295
   End
   Begin VB.ComboBox cbotunerinput 
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
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   23
      Top             =   2040
      Width           =   1335
   End
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   4215
      Left            =   120
      TabIndex        =   21
      Top             =   3000
      Width           =   5655
      _Version        =   65536
      _ExtentX        =   9975
      _ExtentY        =   7435
      _StockProps     =   0
   End
   Begin VB.CommandButton cmdChange 
      Caption         =   "Change"
      Height          =   375
      Left            =   4200
      TabIndex        =   20
      Top             =   480
      Width           =   1095
   End
   Begin VB.ComboBox cbovideostand 
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
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   19
      Top             =   1200
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
      Left            =   1680
      TabIndex        =   16
      Top             =   840
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
      Left            =   1680
      TabIndex        =   14
      Top             =   480
      Width           =   2415
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      Left            =   1680
      TabIndex        =   11
      Text            =   "1"
      Top             =   1560
      Width           =   1455
   End
   Begin VB.CommandButton Command5 
      Caption         =   "VideoCapture Property Page"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5880
      TabIndex        =   10
      Top             =   6600
      Width           =   2295
   End
   Begin VB.CheckBox Check1 
      Caption         =   "Mute"
      Height          =   375
      Left            =   7800
      TabIndex        =   9
      Top             =   2520
      Width           =   975
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Stop Capture"
      Enabled         =   0   'False
      Height          =   375
      Left            =   7800
      TabIndex        =   8
      Top             =   0
      Width           =   1095
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   8760
      Top             =   960
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Capture"
      Enabled         =   0   'False
      Height          =   375
      Left            =   6600
      TabIndex        =   6
      Top             =   0
      Width           =   1095
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
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   5
      Top             =   120
      Width           =   2415
   End
   Begin VB.PictureBox Picture1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   975
      Left            =   7200
      ScaleHeight     =   915
      ScaleWidth      =   1035
      TabIndex        =   3
      Top             =   480
      Width           =   1095
   End
   Begin VB.CommandButton Command2 
      Caption         =   "SnapShot"
      Enabled         =   0   'False
      Height          =   375
      Left            =   5400
      TabIndex        =   2
      Top             =   0
      Width           =   1095
   End
   Begin VB.ListBox List1 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2205
      Left            =   5880
      TabIndex        =   1
      Top             =   3000
      Width           =   3255
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Start"
      Height          =   375
      Left            =   4200
      TabIndex        =   0
      Top             =   0
      Width           =   1095
   End
   Begin VB.Label Label9 
      Caption         =   "Tuner Mode"
      Height          =   255
      Left            =   120
      TabIndex        =   24
      Top             =   2520
      Width           =   1215
   End
   Begin VB.Label Label8 
      Caption         =   "Tuner Input"
      Height          =   255
      Left            =   120
      TabIndex        =   22
      Top             =   2040
      Width           =   1215
   End
   Begin VB.Label Label7 
      Caption         =   "Video Standard"
      Height          =   375
      Left            =   120
      TabIndex        =   18
      Top             =   1200
      Width           =   1455
   End
   Begin VB.Label Label5 
      Caption         =   "Video Format"
      Height          =   375
      Left            =   120
      TabIndex        =   17
      Top             =   840
      Width           =   1335
   End
   Begin VB.Label Label6 
      Caption         =   "Video Input"
      Height          =   375
      Left            =   120
      TabIndex        =   15
      Top             =   480
      Width           =   1095
   End
   Begin VB.Label Label4 
      Caption         =   "if you do not know your country code ,see the help file"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   3360
      TabIndex        =   13
      Top             =   1560
      Width           =   4455
   End
   Begin VB.Label Label3 
      Caption         =   "Country Code"
      Height          =   255
      Left            =   120
      TabIndex        =   12
      Top             =   1560
      Width           =   1215
   End
   Begin VB.Label Label2 
      Caption         =   "TV Channel No."
      Height          =   255
      Left            =   5880
      TabIndex        =   7
      Top             =   2640
      Width           =   1335
   End
   Begin VB.Label Label1 
      Caption         =   "Video Device"
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   1215
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub cboVideoFormat_Click()
strVideoFormat = cboVideoFormat.List(cboVideoFormat.ListIndex)
videoFormatIndex = Me.VideoCap1.VideoFormats.FindVideoFormat(strVideoFormat)

If videoFormatIndex <> -1 Then
        VideoCap1.VideoFormat = videoFormatIndex
End If

End Sub

Private Sub cboVideoInput_Click()
strVideoInput = cboVideoInput.List(cboVideoInput.ListIndex)
videoinputindex = Me.VideoCap1.VideoInputs.FindVideoInput(strVideoInput)

If videoinputindex <> -1 Then
        VideoCap1.VideoInput = videoinputindex
End If
End Sub

Private Sub cbovideostand_Click()
VideoCap1.VideoStandard = cbovideostand.ListIndex
End Sub

Private Sub Check1_Click()

If Check1.Value = 1 Then
    Me.VideoCap1.TVMute = True
Else
    Me.VideoCap1.TVMute = False
End If


End Sub

Private Sub cmdChange_Click()
Me.VideoCap1.Start

End Sub

Private Sub Command1_Click()

Dim myTVChannel As TVChannel





strVideoInput = cboVideoInput.List(cboVideoInput.ListIndex)
videoinputindex = Me.VideoCap1.VideoInputs.FindVideoInput(strVideoInput)

If videoinputindex <> -1 Then
        VideoCap1.VideoInput = videoinputindex
End If

Me.VideoCap1.TunerInput = cbotunerinput.ListIndex

If cboTunerMode.ListIndex = 0 Then
    Me.VideoCap1.TunerMode = -1
Else
    Me.VideoCap1.TunerMode = cboTunerMode.ListIndex - 1
End If


Me.VideoCap1.CountryCode = Val(Text1.Text)
Me.VideoCap1.Start



VideoCap1.VideoStandard = cbovideostand.ListIndex


IsTVDevice = VideoCap1.ScanTVChannels

If IsTVDevice = False Then
    MsgBox "No TV Tuner found"
End If


cmdChange.Enabled = True






For Each myTVChannel In VideoCap1.TVChannels

        If myTVChannel.SignalStatus <> 0 Then
        
            Me.List1.AddItem myTVChannel.ChannelNo
        End If
        

Next

 


Me.Command1.Enabled = False
Me.cboDevice.Enabled = False

Me.Command2.Enabled = True
Me.Command3.Enabled = True



End Sub

Private Sub Command2_Click()
strFileName = App.Path + "\" + "test" + ".bmp"



result = Me.VideoCap1.SnapShot(strFileName)




Me.Picture1.Picture = LoadPicture(strFileName, vbLPLarge, vbLPColor)

End Sub

Private Sub Command3_Click()

Me.CommonDialog1.Filter = "Avi File (*.avi)|*.avi"

Me.CommonDialog1.ShowSave

Me.VideoCap1.CaptureVideo = True
Me.VideoCap1.CaptureAudio = True
Me.VideoCap1.ShowPreview = True
Me.VideoCap1.UseVideoCompressor = False
Me.VideoCap1.UseAudioCompressor = False
Me.VideoCap1.CaptureMode = True
Me.VideoCap1.CaptureFileName = Me.CommonDialog1.FileName
Me.VideoCap1.Start


Me.Command3.Enabled = False
Me.Command4.Enabled = True


End Sub

Private Sub Command4_Click()

Me.Command1.Enabled = True
Me.cboDevice.Enabled = True

Me.VideoCap1.Stop

Me.VideoCap1.CaptureMode = False
Me.VideoCap1.Start

Me.Command4.Enabled = False
Me.Command3.Enabled = True

End Sub

Private Sub Command5_Click()
Me.VideoCap1.ShowVideoCapturePropertyPage Me.hWnd
End Sub

Private Sub Command6_Click()
Me.VideoCap1.Start
End Sub

Private Sub Form_Load()
Dim mydevice As Device

cbotunerinput.AddItem "Cable"
cbotunerinput.AddItem "Antenna"
cbotunerinput.ListIndex = 0

cboTunerMode.AddItem "Default"
cboTunerMode.AddItem "TV"
cboTunerMode.AddItem "FM Radio"
cboTunerMode.AddItem "AM Radio"
cboTunerMode.AddItem "Digital Satellite Service"
cboTunerMode.ListIndex = 0

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


cmdChange.Enabled = False






For Each myVideoInput In Me.VideoCap1.VideoInputs
        cboVideoInput.AddItem myVideoInput.Name
Next

If cboVideoInput.ListCount > 0 Then
        cboVideoInput.ListIndex = 0
 End If

For Each mydevice In Me.VideoCap1.Devices

    cboDevice.AddItem mydevice.Name
Next


If cboDevice.ListCount > 0 Then
    cboDevice.ListIndex = 0
End If


For Each myVideoFormat In Me.VideoCap1.VideoFormats
        cboVideoFormat.AddItem myVideoFormat.Name
Next

If cboVideoFormat.ListCount > 0 Then
        cboVideoFormat.ListIndex = 0
 End If


End Sub

Private Sub List1_Click()
 strNO = List1.List(List1.ListIndex)
 Me.VideoCap1.Channel = Val(strNO)
 

End Sub

