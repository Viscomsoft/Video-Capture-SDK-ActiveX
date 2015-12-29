VERSION 5.00
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "videocap.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{C99E4EFC-CCD5-4F78-B574-EB2CF6CE842C}#1.0#0"; "WMVProfileEditor.ocx"
Begin VB.Form Form1 
   Caption         =   "4 cams Picture in Picture Video Capture"
   ClientHeight    =   9495
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   17100
   LinkTopic       =   "Form1"
   ScaleHeight     =   9495
   ScaleWidth      =   17100
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame4 
      Height          =   2655
      Left            =   10200
      TabIndex        =   30
      Top             =   2880
      Width           =   4815
      Begin VB.TextBox txtalphavideo4 
         Height          =   285
         Left            =   1560
         TabIndex        =   33
         Text            =   "255"
         Top             =   1200
         Width           =   975
      End
      Begin VB.ComboBox cbovideoformat4 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   32
         Top             =   720
         Width           =   3135
      End
      Begin VB.ComboBox cboDevice4 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   31
         Top             =   240
         Width           =   3135
      End
      Begin VB.Label Label14 
         Caption         =   "Alpha Value(0-255)"
         Height          =   255
         Left            =   120
         TabIndex        =   36
         Top             =   1200
         Width           =   1455
      End
      Begin VB.Label Label13 
         Caption         =   "Video Format"
         Height          =   255
         Left            =   120
         TabIndex        =   35
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label12 
         Caption         =   "Video Device"
         Height          =   255
         Left            =   120
         TabIndex        =   34
         Top             =   240
         Width           =   1215
      End
   End
   Begin VB.Frame Frame3 
      Height          =   2655
      Left            =   10200
      TabIndex        =   23
      Top             =   120
      Width           =   4815
      Begin VB.ComboBox cboDevice3 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   26
         Top             =   240
         Width           =   3135
      End
      Begin VB.ComboBox cbovideoformat3 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   25
         Top             =   720
         Width           =   3135
      End
      Begin VB.TextBox txtalphavideo3 
         Height          =   285
         Left            =   1560
         TabIndex        =   24
         Text            =   "255"
         Top             =   1200
         Width           =   975
      End
      Begin VB.Label Label11 
         Caption         =   "Video Device"
         Height          =   255
         Left            =   120
         TabIndex        =   29
         Top             =   240
         Width           =   1215
      End
      Begin VB.Label Label9 
         Caption         =   "Video Format"
         Height          =   255
         Left            =   120
         TabIndex        =   28
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label8 
         Caption         =   "Alpha Value(0-255)"
         Height          =   255
         Left            =   120
         TabIndex        =   27
         Top             =   1200
         Width           =   1455
      End
   End
   Begin VB.Frame Frame2 
      Height          =   2655
      Left            =   5160
      TabIndex        =   16
      Top             =   120
      Width           =   4815
      Begin VB.TextBox txtalphavideo2 
         Height          =   285
         Left            =   1560
         TabIndex        =   19
         Text            =   "255"
         Top             =   1200
         Width           =   975
      End
      Begin VB.ComboBox cbovideoformat2 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   18
         Top             =   720
         Width           =   3135
      End
      Begin VB.ComboBox cboDevice2 
         Height          =   315
         Left            =   1560
         Style           =   2  'Dropdown List
         TabIndex        =   17
         Top             =   240
         Width           =   3135
      End
      Begin VB.Label Label10 
         Caption         =   "Alpha Value(0-255)"
         Height          =   255
         Left            =   120
         TabIndex        =   22
         Top             =   1200
         Width           =   1455
      End
      Begin VB.Label Label7 
         Caption         =   "Video Format"
         Height          =   255
         Left            =   120
         TabIndex        =   21
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label5 
         Caption         =   "Video Device"
         Height          =   255
         Left            =   120
         TabIndex        =   20
         Top             =   240
         Width           =   1215
      End
   End
   Begin WMVPROFILEEDITORLib.WMVProfileEditor WMVProfileEditor1 
      Height          =   495
      Left            =   9120
      TabIndex        =   15
      Top             =   3600
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
      TabIndex        =   14
      Top             =   3120
      Width           =   2055
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Stop"
      Height          =   615
      Left            =   7200
      TabIndex        =   13
      Top             =   5040
      Width           =   2055
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   9240
      Top             =   2880
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

Private Sub cboAudioDevice2_Click()
cboaudioinput2.Clear

VideoCap1.RefreshAudioInputPin cboAudioDevice2.ListIndex

For Each myAudioInput2 In VideoCap1.AudioInputPins
        cboaudioinput2.AddItem myAudioInput2.Name
Next

If cboaudioinput2.ListCount > 0 Then
        cboaudioinput2.ListIndex = 0
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

End Sub

Private Sub cboDevice2_Click()

    cbovideoformat2.Clear
    
   
   VideoCap1.RefreshVideoDevice cboDevice2.ListIndex
    
    For Each myVideoInput2 In Me.VideoCap1.VideoInputs
        cboVideoInput2.AddItem myVideoInput2.Name
    Next

  
 
    For Each myVideoformat2 In Me.VideoCap1.VideoFormats
        cbovideoformat2.AddItem myVideoformat2.Name
    Next

    If cbovideoformat2.ListCount > 0 Then
        cbovideoformat2.ListIndex = 0
    End If

End Sub

Private Sub cboDevice3_Click()
  cbovideoformat3.Clear
    
   
   VideoCap1.RefreshVideoDevice cboDevice3.ListIndex
    
    For Each myVideoInput3 In Me.VideoCap1.VideoInputs
        cboVideoInput3.AddItem myVideoInput3.Name
    Next

  
 
    For Each myVideoformat3 In Me.VideoCap1.VideoFormats
        cbovideoformat3.AddItem myVideoformat3.Name
    Next

    If cbovideoformat3.ListCount > 0 Then
        cbovideoformat3.ListIndex = 0
    End If

End Sub

Private Sub cboDevice4_Click()
  cbovideoformat4.Clear
    
   
   VideoCap1.RefreshVideoDevice cboDevice4.ListIndex
    
    For Each myVideoInput3 In Me.VideoCap1.VideoInputs
        cboVideoInput4.AddItem myVideoInput4.Name
    Next

  
 
    For Each myVideoformat4 In Me.VideoCap1.VideoFormats
        cbovideoformat4.AddItem myVideoformat4.Name
    Next

    If cbovideoformat4.ListCount > 0 Then
        cbovideoformat4.ListIndex = 0
    End If
End Sub

Private Sub chktwozone_Click()

End Sub

Private Sub Command2_Click()

If cboDevice.ListIndex = cboDevice2.ListIndex Then

    MsgBox "You cannot select same video device"
    Exit Sub
End If


If chkcapturetowmv.Value = 1 Then

    Me.VideoCap1.AudioDevice = cboAudioDevice.ListIndex
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



    bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice.ListIndex, cbovideoformat.ListIndex, 0, txtalphavideo)
    If bresult <> True Then
        MsgBox "Video device 1 failed"
    End If

   
      Me.VideoCap1.PIPAddPIPEffect 0, 99999, 0, 0, 320, 240
    
   
   
    
       bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice2.ListIndex, cbovideoformat2.ListIndex, 0, txtalphavideo2)
    If bresult <> True Then
        MsgBox "Video device 2 failed"
    End If
    
   
           Me.VideoCap1.PIPAddPIPEffect 0, 99999, 320, 0, 320, 240

   
    

        bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice3.ListIndex, cbovideoformat3.ListIndex, 0, txtalphavideo3)
    If bresult <> True Then
        MsgBox "video device 3 failed"
    End If
    
        
        Me.VideoCap1.PIPAddPIPEffect 0, 99999, 0, 240, 320, 240
    

    bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice4.ListIndex, cbovideoformat4.ListIndex, 0, txtalphavideo4)
   If bresult <> True Then
        MsgBox "video device 4 failed"
    End If
    
        
        Me.VideoCap1.PIPAddPIPEffect 0, 99999, 320, 240, 320, 240
    




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


If cboAudioDevice.ListCount > 0 Then
cboAudioDevice.ListIndex = 0
End If

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

'''''''''''''''''''''''''''''''''''''''''''

For Each mydevice2 In Me.VideoCap1.Devices
    cboDevice2.AddItem mydevice2.Name
Next


If cboDevice2.ListCount > 0 Then
    cboDevice2.ListIndex = 0
End If


For Each mydevice3 In Me.VideoCap1.Devices
    cboDevice3.AddItem mydevice3.Name
Next


If cboDevice3.ListCount > 0 Then
    cboDevice3.ListIndex = 0
End If


For Each mydevice4 In Me.VideoCap1.Devices
    cboDevice4.AddItem mydevice4.Name
Next


If cboDevice4.ListCount > 0 Then
    cboDevice4.ListIndex = 0
End If


End Sub

Private Sub Form_Unload(Cancel As Integer)
Me.WMVProfileEditor1.DeleteTempFile tmpWMVFilePath
End Sub
