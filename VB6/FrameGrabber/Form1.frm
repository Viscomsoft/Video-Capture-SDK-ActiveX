VERSION 5.00
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "videocap.ocx"
Begin VB.Form Form1 
   Caption         =   "Frame Grabber"
   ClientHeight    =   10785
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   11970
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
   ScaleHeight     =   10785
   ScaleWidth      =   11970
   StartUpPosition =   3  'Windows Default
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   3255
      Left            =   7920
      TabIndex        =   14
      Top             =   240
      Width           =   3735
      _Version        =   65536
      _ExtentX        =   6588
      _ExtentY        =   5741
      _StockProps     =   0
   End
   Begin VB.CommandButton cmdgetRGBbuffer 
      Caption         =   "Get RGB Buffer"
      Enabled         =   0   'False
      Height          =   375
      Left            =   240
      TabIndex        =   13
      Top             =   3600
      Width           =   1935
   End
   Begin VB.PictureBox Picture1 
      Height          =   5295
      Left            =   240
      ScaleHeight     =   349
      ScaleMode       =   3  'Pixel
      ScaleWidth      =   573
      TabIndex        =   12
      Top             =   4560
      Width           =   8655
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Stop"
      Enabled         =   0   'False
      Height          =   495
      Left            =   6600
      TabIndex        =   10
      Top             =   360
      Width           =   1215
   End
   Begin VB.ListBox List1 
      Height          =   1500
      Left            =   4560
      TabIndex        =   8
      Top             =   1800
      Width           =   3135
   End
   Begin VB.Frame Frame1 
      Caption         =   "frame grabber"
      Height          =   2055
      Left            =   240
      TabIndex        =   5
      Top             =   1320
      Width           =   3975
      Begin VB.OptionButton Option4 
         Caption         =   "RGB Buffer"
         Height          =   255
         Left            =   360
         TabIndex        =   11
         Top             =   1200
         Width           =   1335
      End
      Begin VB.OptionButton Option3 
         Caption         =   "To Clipboard"
         Height          =   255
         Left            =   360
         TabIndex        =   7
         Top             =   720
         Width           =   1455
      End
      Begin VB.OptionButton Option1 
         Caption         =   "To PictureBox"
         Height          =   375
         Left            =   360
         TabIndex        =   6
         Top             =   240
         Value           =   -1  'True
         Width           =   1575
      End
   End
   Begin VB.ComboBox cbovideoformat 
      Height          =   300
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   4
      Top             =   720
      Width           =   3375
   End
   Begin VB.ComboBox cbovideodevice 
      Height          =   300
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   2
      Top             =   240
      Width           =   3375
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Start"
      Height          =   495
      Left            =   5280
      TabIndex        =   0
      Top             =   360
      Width           =   1215
   End
   Begin VB.Label Label3 
      Caption         =   "Recieved Sample from Memory"
      Height          =   255
      Left            =   4560
      TabIndex        =   9
      Top             =   1440
      Width           =   2655
   End
   Begin VB.Label Label2 
      Caption         =   "Video Format"
      Height          =   375
      Left            =   240
      TabIndex        =   3
      Top             =   720
      Width           =   1335
   End
   Begin VB.Label Label1 
      Caption         =   "Video Device"
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   240
      Width           =   1335
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Type mRGB
    R As Long
    G As Long
    B As Long
End Type

Private Sub cmdgetRGBbuffer_Click()
 Dim ImageArray As Variant
    Dim MyRGB As mRGB
    
    Dim x As Long
    Dim y As Long
    
    Dim iwidth As Long
    Dim iheight As Long

    ImageArray = VideoCap1.GetSampleBufferRGB(iwidth, iheight)

   
    'Exit Sub
    For x = 0 To iwidth - 1
        For y = 0 To iheight - 1
            MyRGB = GetRGBFromRef(ImageArray(x, y))
            With MyRGB
                'Me.Print "R,G,B " & .R & "," & .G & "," & .B
                Picture1.PSet (10 + x, 10 + y), RGB(.R, .G, .B)
            End With
        Next y
    Next x

End Sub

Private Sub Command1_Click()
VideoCap1.Device = cbovideodevice.ListIndex
VideoCap1.VideoFormat = cbovideoformat.ListIndex


If Option1.Value = True Then

    VideoCap1.SampleBufferMode = 4
End If


If Option3.Value = True Then
    VideoCap1.SampleBufferMode = 2
End If

If Option4.Value = True Then
    VideoCap1.SampleBufferMode = 3
End If





VideoCap1.Start

Command2.Enabled = True
Command1.Enabled = False

End Sub

Private Sub Command2_Click()
VideoCap1.SampleBufferMode = 0
VideoCap1.Stop
Command2.Enabled = False
Command1.Enabled = True

 Picture1.Picture = Nothing
       
End Sub

Private Sub Form_Load()
Dim mydevice As Device
Dim myVideoFormat As VideoFormat

VideoCap1.SampleBufferMode = 4

For Each mydevice In Me.VideoCap1.Devices
    cbovideodevice.AddItem mydevice.Name
Next


If cbovideodevice.ListCount > 0 Then
    cbovideodevice.ListIndex = 0
End If

For Each myVideoFormat In Me.VideoCap1.VideoFormats

   Me.cbovideoformat.AddItem myVideoFormat.Name

Next

If cbovideoformat.ListCount > 0 Then
    cbovideoformat.ListIndex = 0
End If





End Sub

Private Sub Option1_Click()
cmdgetRGBbuffer.Enabled = False
List1.Enabled = True

End Sub

Private Sub Option2_Click()
VideoCap1.SampleBufferMode = 5
cmdgetRGBbuffer.Enabled = False
List1.Enabled = True

End Sub

Private Sub Option3_Click()
cmdgetRGBbuffer.Enabled = False


End Sub

Private Sub Option4_Click()
cmdgetRGBbuffer.Enabled = True
List1.Enabled = False

End Sub



Private Function GetRGBFromRef(ByVal MyColor As Long) As mRGB
    Dim CurrColor As Long
    Dim RedShade As Long
    Dim GreenShade As Long
    Dim BlueShade As Long
    Dim ret As mRGB
    
    CurrColor = MyColor
    RedShade = (CurrColor And 255)
    GreenShade = (CurrColor And 65280) / 256
    BlueShade = (CurrColor And 16711680) / 65536
    ret.R = RedShade
    ret.G = GreenShade
    ret.B = BlueShade
    GetRGBFromRef = ret
End Function

Private Sub VideoCap1_SampleBuffer2(ByVal iwidth As Integer, ByVal iheight As Integer, ByVal iSampleTime As Double, ByVal iBufferLen As Long)

On Error Resume Next

If VideoCap1.SampleBufferMode = 4 Then
       
       Picture1.Picture = VideoCap1.SampleBuffer2Picture
        VideoCap1.ReleasePictureBox Picture1.Picture
        
       
End If
List1.AddItem Str(iwidth) + "x" + Str(iheight) + " resolution sample received"


End Sub
