VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "videocap.ocx"
Begin VB.Form Form1 
   Caption         =   "Capture to MP4 file"
   ClientHeight    =   8385
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
   ScaleHeight     =   8385
   ScaleWidth      =   14505
   StartUpPosition =   3  'Windows Default
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
      Left            =   6120
      TabIndex        =   22
      Top             =   2640
      Width           =   1575
   End
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   4935
      Left            =   240
      TabIndex        =   21
      Top             =   3240
      Width           =   6495
      _Version        =   65536
      _ExtentX        =   11456
      _ExtentY        =   8705
      _StockProps     =   0
   End
   Begin VB.Frame Frame2 
      Height          =   2415
      Left            =   0
      TabIndex        =   5
      Top             =   0
      Width           =   14295
      Begin VB.TextBox txtmp4audiochannels 
         Height          =   315
         Left            =   11280
         TabIndex        =   31
         Text            =   "2"
         Top             =   1320
         Width           =   735
      End
      Begin VB.TextBox txtmp4framerate 
         Height          =   315
         Left            =   13200
         TabIndex        =   29
         Text            =   "25"
         Top             =   360
         Width           =   615
      End
      Begin VB.TextBox txtmp4audiobitrate 
         Height          =   315
         Left            =   10320
         TabIndex        =   27
         Text            =   "224000"
         Top             =   360
         Width           =   1095
      End
      Begin VB.TextBox txtmp4height 
         Height          =   315
         Left            =   9960
         TabIndex        =   26
         Text            =   "480"
         Top             =   840
         Width           =   735
      End
      Begin VB.TextBox txtmp4width 
         Height          =   315
         Left            =   7680
         TabIndex        =   24
         Text            =   "720"
         Top             =   840
         Width           =   975
      End
      Begin VB.ComboBox cboaudiosamplerate 
         Height          =   330
         Left            =   7680
         Style           =   2  'Dropdown List
         TabIndex        =   20
         Top             =   1320
         Width           =   1575
      End
      Begin VB.TextBox txtmp4videobitrate 
         Height          =   315
         Left            =   7680
         TabIndex        =   17
         Text            =   "4600000"
         Top             =   360
         Width           =   1455
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
         TabIndex        =   9
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
         TabIndex        =   8
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
         TabIndex        =   7
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
         TabIndex        =   6
         Top             =   960
         Width           =   3855
      End
      Begin VB.Label Label8 
         Caption         =   "Audio Channels"
         Height          =   375
         Left            =   9720
         TabIndex        =   30
         Top             =   1320
         Width           =   1215
      End
      Begin VB.Label Label7 
         Caption         =   "Video Frame Rate"
         Height          =   375
         Left            =   11640
         TabIndex        =   28
         Top             =   360
         Width           =   1455
      End
      Begin VB.Label Label5 
         Caption         =   "Height"
         Height          =   255
         Left            =   9240
         TabIndex        =   25
         Top             =   840
         Width           =   615
      End
      Begin VB.Label Label3 
         Caption         =   "Width"
         Height          =   255
         Left            =   6480
         TabIndex        =   23
         Top             =   840
         Width           =   975
      End
      Begin VB.Label Label40 
         Caption         =   "Audio Sample Rate"
         Height          =   255
         Left            =   6480
         TabIndex        =   19
         Top             =   1320
         Width           =   1095
      End
      Begin VB.Label Label38 
         Caption         =   "Audio Bitrate"
         Height          =   375
         Left            =   9240
         TabIndex        =   18
         Top             =   360
         Width           =   1095
      End
      Begin VB.Label Label37 
         Caption         =   "Video Bitrate"
         Height          =   375
         Left            =   6480
         TabIndex        =   16
         Top             =   360
         Width           =   1095
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
         Height          =   375
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
         TabIndex        =   13
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
         TabIndex        =   12
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
         TabIndex        =   11
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
         TabIndex        =   10
         Top             =   960
         Width           =   1095
      End
   End
   Begin VB.CommandButton Command7 
      Caption         =   "Resume"
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
      Left            =   4920
      TabIndex        =   4
      Top             =   2640
      Width           =   1095
   End
   Begin VB.CommandButton Command6 
      Caption         =   "Pause"
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
      Left            =   3600
      TabIndex        =   3
      Top             =   2640
      Width           =   1215
   End
   Begin MSComDlg.CommonDialog CommonDialog2 
      Left            =   12360
      Top             =   2520
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Stop Capture"
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
      Height          =   375
      Left            =   2400
      TabIndex        =   2
      Top             =   2640
      Width           =   1095
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   12240
      Top             =   3120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Capture"
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
      Left            =   1200
      TabIndex        =   1
      Top             =   2640
      Width           =   1095
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
      Width           =   975
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim clrTranColor
Dim clrHashBrushForeColor
Dim clrHashBrushBackColor
Dim clrDateColor

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

Private Sub cbodatefontname_Click()
VideoCap1.DateFontName = cbodatefontname.List(cbodatefontname.ListIndex)
VideoCap1.DateFontSize = Val(cbodatefontsize.List(cbodatefontsize.ListIndex))
End Sub



Private Sub cbodatefontsize_Click()
VideoCap1.DateFontName = cbodatefontname.List(cbodatefontname.ListIndex)
VideoCap1.DateFontSize = Val(cbodatefontsize.List(cbodatefontsize.ListIndex))
End Sub

Private Sub cbodatefontstyle_Click()
Me.VideoCap1.DateFontStyle = cbodatefontstyle.ListIndex
End Sub



Private Sub cboDateFormat_Click()
iDateFormat = cboDateFormat.ListIndex
Me.VideoCap1.DrawTime txtdateleft, txtdatetop, iDateFormat
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

Private Sub cbofontname_Click()
VideoCap1.TextFontName 0, cbofontname.List(cbofontname.ListIndex)
VideoCap1.TextFontSize 0, Val(cbofontsize.List(cbofontsize.ListIndex))
End Sub



Private Sub cbofontsize_Click()
VideoCap1.TextFontName 0, cbofontname.List(cbofontname.ListIndex)
VideoCap1.TextFontSize 0, Val(cbofontsize.List(cbofontsize.ListIndex))
End Sub

Private Sub cbofontstyle_Click()
Me.VideoCap1.TextFontStyle 0, cbofontstyle.ListIndex
End Sub

Private Sub cbohashbrushstyle_Click()

'Me.CommonDialog1.ShowColor
'clrHashBrushForeColor = Me.CommonDialog1.Color
VideoCap1.SetHashBrushValue 0, cbohashbrushstyle.ListIndex, clrHashBrushForeColor, clrHashBrushBackColor

End Sub

Private Sub cbokey_Click()
Control_Clearfullscreenkey
End Sub

Private Sub cbomousebutton_Click()
Control_Clearfullscreenkey
End Sub

Private Sub cborotate_Click()


VideoCap1.Rotate cborotate.ListIndex


If cborotate.ListIndex = 1 Or cborotate.ListIndex = 3 Or cborotate.ListIndex = 5 Or cborotate.ListIndex = 7 Or cborotate.ListIndex = 9 Or cborotate.ListIndex = 11 Then

    If chkinvertcolor.Value = 1 Then
    
        MsgBox "You selected rotate value that cannot support invert color"
    End If
    
    If chkgrayscale.Value = 1 Then
    
        MsgBox "You selected rotate value that cannot support grayscale color"
    End If
    
End If

End Sub

Private Sub cbosync_Click()
If cbosync.ListIndex = 2 Then
    txtoffset.Enabled = True
Else
    txtoffset.Enabled = False
End If

End Sub

Private Sub cbotextstyle_Click()
Me.VideoCap1.TextStyle 0, cbotextstyle.ListIndex


Select Case cbotextstyle.ListIndex
    
    
Case 0
    cmdsolidfontcolor.Enabled = True
    cbohashbrushstyle.Enabled = False
    cmdhashforecolor.Enabled = False
    cmdhashbackcolor.Enabled = False
    cmdtextureselimage.Enabled = False
    txttextureimage.Enabled = False
    cmdoutlineborder.Enabled = False
    cmdoutlineback.Enabled = False


Case 1
    cmdsolidfontcolor.Enabled = False
    cbohashbrushstyle.Enabled = False
    cmdhashforecolor.Enabled = False
    cmdhashbackcolor.Enabled = False
    cmdtextureselimage.Enabled = False
    txttextureimage.Enabled = False
    cmdoutlineborder.Enabled = True
    cmdoutlineback.Enabled = False

Case 2
    cmdsolidfontcolor.Enabled = False
    cbohashbrushstyle.Enabled = False
    cmdhashforecolor.Enabled = False
    cmdhashbackcolor.Enabled = False
    cmdtextureselimage.Enabled = False
    txttextureimage.Enabled = False
    cmdoutlineborder.Enabled = True
    cmdoutlineback.Enabled = True

Case 3
    cmdsolidfontcolor.Enabled = False
    cbohashbrushstyle.Enabled = True
    cmdhashforecolor.Enabled = True
    cmdhashbackcolor.Enabled = True
    cmdtextureselimage.Enabled = False
    txttextureimage.Enabled = False
    cmdoutlineborder.Enabled = False
    cmdoutlineback.Enabled = False

Case 4

    cmdsolidfontcolor.Enabled = False
    
    cbohashbrushstyle.Enabled = False
    cmdhashforecolor.Enabled = False
    cmdhashbackcolor.Enabled = False
    
    cmdtextureselimage.Enabled = True
    txttextureimage.Enabled = True
    
    If txttextureimage = "" Then
        MsgBox "Please select Texture Brush image "
    End If
    
End Select




End Sub

Private Sub chkaspectratio_Click()

If chkaspectratio.Value = 1 Then
    Me.VideoCap1.AspectRatio = True
Else

    Me.VideoCap1.AspectRatio = False
End If




End Sub

Private Sub chkBgTransparent_Click()

If chkBgTransparent.Value = 1 Then

    Me.VideoCap1.TextBgTransparent = True
Else
    Me.VideoCap1.TextBgTransparent = False

End If


End Sub


Private Sub chkFontBold_Click()

End Sub

Private Sub chkFontItalic_Click()



End Sub

Private Sub chkFontUnderline_Click()





End Sub



Private Sub chkinvert_Click()
If chkinvert.Value = 1 Then
    VideoCap1.InvertColor True
Else
    VideoCap1.InvertColor False
End If


End Sub

Private Sub chkgrayscale_Click()
If chkgrayscale.Value = 1 Then
    
    If cborotate.ListIndex = 1 Or cborotate.ListIndex = 3 Or cborotate.ListIndex = 5 Or cborotate.ListIndex = 7 Or cborotate.ListIndex = 9 Or cborotate.ListIndex = 11 Then
        MsgBox "You selected rotate value cannot support grayscale"
    End If
    
    VideoCap1.GrayScale True
Else
    VideoCap1.GrayScale False
End If
End Sub

Private Sub chkhue_Click()

If chkhue.Value = 1 Then

    txthuer.Enabled = True
    txthueg.Enabled = True
    txthueb.Enabled = True


Else
    txthuer.Enabled = False
    txthueg.Enabled = False
    txthueb.Enabled = False
End If


End Sub

Private Sub chkinvertcolor_Click()
If chkinvertcolor.Value = 1 Then
    
    If cborotate.ListIndex = 1 Or cborotate.ListIndex = 3 Or cborotate.ListIndex = 5 Or cborotate.ListIndex = 7 Or cborotate.ListIndex = 9 Or cborotate.ListIndex = 11 Then
        MsgBox "You selected rotate value cannot support invert color"
    End If
    
    VideoCap1.InvertColor True
Else
    VideoCap1.InvertColor False
End If


End Sub

Private Sub chklightness_Click()

If chklightness.Value = 1 Then

    txlightnessr.Enabled = True
    txlightnessg.Enabled = True
    txlightnessb.Enabled = True


Else
    txlightnessr.Enabled = False
    txlightnessg.Enabled = False
    txlightnessb.Enabled = False
End If

End Sub

Private Sub chkshowdatetime_Click()


If chkshowdatetime.Value = 1 Then
    VideoCap1.ShowDateTime = True
Else
    VideoCap1.ShowDateTime = False
End If


End Sub

Private Sub chkshowimage_Click()

If chkshowimage.Value = 1 Then
    Me.VideoCap1.ShowImage 0, True
Else
    Me.VideoCap1.ShowImage 0, False

End If


End Sub

Private Sub chkshowtext_Click()


If chkshowtext.Value = 1 Then

    VideoCap1.ShowText 0, True
Else
    VideoCap1.ShowText 0, False

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

End Sub

Private Sub cmdBackgroundColor_Click()

CommonDialog2.ShowColor

VideoCap1.BackgroundColor = CommonDialog2.Color
End Sub

Private Sub cmddrawimage_Click()

Me.VideoCap1.DrawImage 0, txtimageleft, txtimagetop, txtimage, clrTranColor, Slider1.Value
End Sub



Private Sub cmdhashbackcolor_Click()
Me.CommonDialog1.ShowColor
clrHashBrushBackColor = Me.CommonDialog1.Color
VideoCap1.SetHashBrushValue 0, cbohashbrushstyle.ListIndex, clrHashBrushForeColor, clrHashBrushBackColor

End Sub

Private Sub cmdhashforecolor_Click()
Me.CommonDialog1.ShowColor
clrHashBrushForeColor = Me.CommonDialog1.Color
VideoCap1.SetHashBrushValue 0, cbohashbrushstyle.ListIndex, clrHashBrushForeColor, clrHashBrushBackColor

End Sub


Private Sub Command1_Click()



ControlCap


Me.VideoCap1.CaptureMode = False

VideoCap1.Start


End Sub



Private Sub Command2_Click()


ControlCap

Me.CommonDialog1.Filter = "MP4 File (*.mp4)|*.mp4"


Me.CommonDialog1.ShowSave


Me.VideoCap1.CaptureMode = True
Me.VideoCap1.CaptureFileName = Me.CommonDialog1.FileName


VideoCap1.UseMp4EncoderPlugin = True
VideoCap1.Mp4Videobitrate = Val(txtmp4videobitrate)


VideoCap1.Mp4Audiobitrate = txtmp4audiobitrate
VideoCap1.Mp4AudioSamplerate = Val(cboaudiosamplerate.List(cboaudiosamplerate.ListIndex))

VideoCap1.Mp4FrameRate = txtmp4framerate
VideoCap1.Mp4Width = Me.txtmp4width
VideoCap1.Mp4Height = Me.txtmp4height
VideoCap1.Mp4Audiochannel = txtmp4audiochannels


result = Me.VideoCap1.Start



If result = -1 Then
    MsgBox "Capture Failure"
    Exit Sub
End If

If result = -2 Then
    MsgBox "Capture file not found"
    Exit Sub
End If

If result = -3 Then
    MsgBox "MP4 Plugin supported on Windows 7 or Windows 8 above only"
    Exit Sub
End If


Command1.Enabled = False
Command2.Enabled = False
Command3.Enabled = True
End Sub













Private Sub Command3_Click()
Me.VideoCap1.Stop
Command1.Enabled = True
Command2.Enabled = True
Command3.Enabled = False
End Sub

Private Sub Command6_Click()
Me.VideoCap1.Pause
End Sub

Private Sub Command7_Click()
Me.VideoCap1.Resume
End Sub

Private Sub Command8_Click()

VideoCap1.ShowFullScreen True

End Sub



Private Sub Form_Load()
Dim mydevice As Device
Dim myVideoformat As VideoFormat
Dim myAudioCompressor As AudioCompressor
Dim myAudioDevice As AudioDevice
Dim myVideoCompressor As VideoCompressor
Dim myVideoInput As VideoInput

cboaudiosamplerate.AddItem "48000"
cboaudiosamplerate.AddItem "44100"
cboaudiosamplerate.ListIndex = 0




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

Private Sub Slider1_Change()
Me.VideoCap1.DrawImage 0, txtimageleft, txtimagetop, txtimage, clrTranColor, Slider1.Value

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
