VERSION 5.00
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "VideoCap.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{C99E4EFC-CCD5-4F78-B574-EB2CF6CE842C}#1.0#0"; "WMVProfileEditor.ocx"
Begin VB.Form Form1 
   Caption         =   "Picture in Picture Video Capture + Image"
   ClientHeight    =   9495
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   11805
   LinkTopic       =   "Form1"
   ScaleHeight     =   9495
   ScaleWidth      =   11805
   StartUpPosition =   3  'Windows Default
   Begin VB.CheckBox chkimageback 
      Caption         =   "Image on background, video capture foreground"
      Height          =   375
      Left            =   7320
      TabIndex        =   22
      Top             =   3480
      Value           =   1  'Checked
      Width           =   3975
   End
   Begin WMVPROFILEEDITORLib.WMVProfileEditor WMVProfileEditor1 
      Height          =   495
      Left            =   10920
      TabIndex        =   21
      Top             =   3960
      Width           =   495
      _Version        =   65536
      _ExtentX        =   873
      _ExtentY        =   873
      _StockProps     =   0
   End
   Begin VB.CheckBox chkcapturetowmv 
      Caption         =   "Capture to WMV 9"
      Height          =   255
      Left            =   7320
      TabIndex        =   20
      Top             =   3120
      Width           =   2055
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Stop"
      Height          =   615
      Left            =   7200
      TabIndex        =   19
      Top             =   5040
      Width           =   2055
   End
   Begin VB.Frame Frame2 
      Height          =   2655
      Left            =   5040
      TabIndex        =   13
      Top             =   120
      Width           =   6735
      Begin VB.TextBox txtalphaimage 
         Height          =   285
         Left            =   1680
         TabIndex        =   18
         Text            =   "255"
         Top             =   1080
         Width           =   975
      End
      Begin VB.TextBox txtImage 
         Height          =   375
         Left            =   120
         TabIndex        =   15
         Top             =   600
         Width           =   5415
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Select Image"
         Height          =   375
         Left            =   5640
         TabIndex        =   14
         Top             =   600
         Width           =   1095
      End
      Begin VB.Label Label7 
         Caption         =   "Alpha Value(0-255)"
         Height          =   375
         Left            =   120
         TabIndex        =   17
         Top             =   1080
         Width           =   1455
      End
      Begin VB.Label Label5 
         Caption         =   "Image"
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   240
         Width           =   1215
      End
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   10440
      Top             =   3000
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Start Picture in Picture"
      Height          =   615
      Left            =   7200
      TabIndex        =   1
      Top             =   4200
      Width           =   2055
   End
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   5655
      Left            =   120
      TabIndex        =   0
      Top             =   2880
      Width           =   6975
      _Version        =   65536
      _ExtentX        =   12303
      _ExtentY        =   9975
      _StockProps     =   0
   End
   Begin VB.Frame Frame1 
      Height          =   2655
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   4815
      Begin VB.ComboBox cboDevice 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   7
         Top             =   240
         Width           =   3135
      End
      Begin VB.ComboBox cbovideoformat 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   6
         Top             =   720
         Width           =   3135
      End
      Begin VB.ComboBox cboAudioDevice 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   5
         Top             =   1200
         Width           =   3135
      End
      Begin VB.ComboBox cboaudioinput 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   4
         Top             =   1680
         Width           =   3135
      End
      Begin VB.TextBox txtalphavideo 
         Height          =   285
         Left            =   1800
         TabIndex        =   3
         Text            =   "255"
         Top             =   2160
         Width           =   975
      End
      Begin VB.Label Label1 
         Caption         =   "Video Device"
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   240
         Width           =   1215
      End
      Begin VB.Label Label2 
         Caption         =   "Video Format"
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label3 
         Caption         =   "Audio Device"
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   1200
         Width           =   1095
      End
      Begin VB.Label Label4 
         Caption         =   "Audio Input"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   1680
         Width           =   1095
      End
      Begin VB.Label Label6 
         Caption         =   "Alpha Value(0-255)"
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   2160
         Width           =   1455
      End
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

    cbovideoformat.Clear
    
   
   VideoCap1.RefreshVideoDevice cboDevice.ListIndex
    
    For Each myVideoInput In Me.VideoCap1.VideoInputs
        cboVideoInput.AddItem myVideoInput.Name
    Next

  
 
    For Each myVideoformat In Me.VideoCap1.VideoFormats
        cbovideoformat.AddItem myVideoformat.Name
    Next

    If cbovideoformat.ListCount > 0 Then
        cbovideoformat.ListIndex = 0
    End If

End Sub

Private Sub Command1_Click()

Me.CommonDialog1.Filter = "Bitmap File (*.bmp)|*.bmp|JPEG File (*.jpg)|*.jpg|TGA File (*.tga)|*.tga"
Me.CommonDialog1.ShowSave
txtImage = CommonDialog1.FileName

End Sub

Private Sub Command2_Click()




If txtImage = "" Then

    MsgBox "Please input image file"
    Exit Sub
    
End If

If chkcapturetowmv.Value = 1 Then

    Me.VideoCap1.AudioDevice = cbovideoformat.ListIndex
    Me.VideoCap1.AudioInputPin = cboaudioinput.ListIndex
    
    Me.CommonDialog1.Filter = "WMV File (*.wmv)|*.wmv"
    Me.CommonDialog1.ShowSave
    
    Me.VideoCap1.CaptureMode = True
    WMV9ProfileSetting
    Me.VideoCap1.OutputWMV = True
    
    Me.VideoCap1.CaptureFileName = Me.CommonDialog1.FileName
    Me.VideoCap1.WMVCustomFileName = tmpWMVFilePath

Else
    Me.VideoCap1.CaptureMode = False

End If


Me.VideoCap1.PIPInitDisplayArea 640, 480


If chkimageback.Value = 1 Then


    bresult = Me.VideoCap1.PIPAddImage(txtImage, 0, txtalphaimage)
    If bresult <> True Then
        MsgBox "failed"
    End If


    Me.VideoCap1.PIPAddPIPEffect 0, 9999, 0, 0, 640, 480

    bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice.ListIndex, cbovideoformat.ListIndex, 0, txtalphavideo)

    If bresult <> True Then
        MsgBox "failed"
    End If
    
    Me.VideoCap1.PIPAddPIPEffect 0, 9999, 0, 0, 320, 240


Else

   bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice.ListIndex, cbovideoformat.ListIndex, 0, txtalphavideo)
    If bresult <> True Then
        MsgBox "failed"
    End If

    Me.VideoCap1.PIPAddPIPEffect 0, 9999, 0, 0, 640, 480
    
        bresult = Me.VideoCap1.PIPAddImage(txtImage, 0, txtalphaimage)
    If bresult <> True Then
        MsgBox "failed"
    End If
    
    Me.VideoCap1.PIPAddPIPEffect 0, 9999, 0, 0, 320, 240


End If



Me.VideoCap1.PIPStart


End Sub

Private Sub Command3_Click()
VideoCap1.PIPStop
End Sub

Private Sub Form_Load()

For Each mydevice In Me.VideoCap1.Devices
    cboDevice.AddItem mydevice.Name
Next


If cboDevice.ListCount > 0 Then
    cboDevice.ListIndex = 0
End If

For Each myAudioDevice In Me.VideoCap1.AudioDevices
    cboAudioDevice.AddItem myAudioDevice.Name

Next


cboAudioDevice.ListIndex = 0

       

For Each myVideoformat In Me.VideoCap1.VideoFormats
   Me.cbovideoformat.AddItem myVideoformat.Name
Next

If cbovideoformat.ListCount > 0 Then
    cbovideoformat.ListIndex = 0
End If

For Each myAudioInput In VideoCap1.AudioInputPins
        cboaudioinput.AddItem myAudioInput.Name
Next

If cboaudioinput.ListCount > 0 Then
        cboaudioinput.ListIndex = 0
 End If


End Sub

Private Sub Form_Unload(Cancel As Integer)
Me.WMVProfileEditor1.DeleteTempFile tmpWMVFilePath
End Sub
