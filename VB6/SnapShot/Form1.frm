VERSION 5.00
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "VideoCap.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form Form1 
   Caption         =   "SnapShot"
   ClientHeight    =   5835
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9855
   LinkTopic       =   "Form1"
   ScaleHeight     =   5835
   ScaleWidth      =   9855
   StartUpPosition =   3  'Windows Default
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   3255
      Left            =   240
      TabIndex        =   10
      Top             =   120
      Width           =   3855
      _Version        =   65536
      _ExtentX        =   6800
      _ExtentY        =   5741
      _StockProps     =   0
   End
   Begin VB.CommandButton Command5 
      Caption         =   "SnapShot JPEG"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   7560
      Picture         =   "Form1.frx":0000
      TabIndex        =   9
      Top             =   4560
      Width           =   1695
   End
   Begin VB.CommandButton Command4 
      Caption         =   "SnapShot To HBITMAP"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5280
      Picture         =   "Form1.frx":E142
      TabIndex        =   8
      Top             =   4560
      Width           =   2175
   End
   Begin VB.CommandButton Command3 
      Caption         =   "SnapShot to Picture Box"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2880
      Picture         =   "Form1.frx":1C284
      TabIndex        =   7
      Top             =   4560
      Width           =   2295
   End
   Begin VB.ComboBox cboVideoInput 
      Height          =   315
      Left            =   1560
      TabIndex        =   5
      Top             =   3600
      Width           =   2775
   End
   Begin VB.PictureBox Picture1 
      Height          =   3735
      Left            =   4920
      ScaleHeight     =   3675
      ScaleWidth      =   4155
      TabIndex        =   4
      Top             =   120
      Width           =   4215
   End
   Begin VB.ComboBox cbovideoformat 
      Height          =   315
      Left            =   1560
      TabIndex        =   2
      Top             =   3960
      Width           =   2775
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   4320
      Top             =   1800
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command2 
      Caption         =   "SnapShot"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1560
      Picture         =   "Form1.frx":2A3C6
      TabIndex        =   1
      Top             =   4560
      Width           =   1215
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Preview"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   4560
      Width           =   1215
   End
   Begin VB.Label Label11 
      Caption         =   "Video Input"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   3600
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Video Format"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   3
      Top             =   3960
      Width           =   1215
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim temp As Integer


Private Type PictDesc
    cbSizeofStruct As Long
    picType As Long
    hImage As Long
    xExt As Long
    yExt As Long
End Type

Private Type Guid
    Data1 As Long
    Data2 As Integer
    Data3 As Integer
    Data4(0 To 7) As Byte
End Type

Private Declare Function OleCreatePictureIndirect Lib "olepro32.dll" ( _
      lpPictDesc As PictDesc, _
      riid As Guid, _
      ByVal fPictureOwnsHandle As Long, _
      ipic As IPicture _
    ) As Long





Private Sub cbovideoformat_Click()
Call Command1_Click
End Sub

Private Sub Command1_Click()


strVideoInput = cboVideoInput.List(cboVideoInput.ListIndex)
videoinputindex = Me.VideoCap1.VideoInputs.FindVideoInput(strVideoInput)

If videoinputindex <> -1 Then
        VideoCap1.VideoInput = videoinputindex
End If


strVideoFormat = cbovideoformat.List(cbovideoformat.ListIndex)
videoFormatIndex = Me.VideoCap1.VideoFormats.FindVideoFormat(strVideoFormat)

If videoFormatIndex <> -1 Then
        VideoCap1.VideoFormat = videoFormatIndex
End If

Me.VideoCap1.Start
End Sub

Private Sub Command2_Click()
strFileName = App.Path + "\" + "test" + ".bmp"
result = Me.VideoCap1.SnapShot(strFileName)
Picture1.Picture = LoadPicture(strFileName, vbLPLarge, vbLPColor)

End Sub

Sub FillVideoFormat()

    For Each myvideoformat In VideoCap1.VideoFormats

        Me.cbovideoformat.AddItem myvideoformat.Name

    Next


End Sub


Private Sub Command3_Click()


Picture1.Picture = VideoCap1.SnapShot2Picture

End Sub

Private Sub Command4_Click()

Picture1.Picture = BitmapToPicture(VideoCap1.SnapShot2HBITMAP)
End Sub

Private Sub Command5_Click()
VideoCap1.SnapShotJPEG "c:\test.jpg", 90

MsgBox "save to c:\test.jpg"


End Sub

Private Sub Form_Load()

For Each myVideoInput In Me.VideoCap1.VideoInputs
        cboVideoInput.AddItem myVideoInput.Name
Next

If cboVideoInput.ListCount > 0 Then
        cboVideoInput.ListIndex = 0
 End If


FillVideoFormat

If cbovideoformat.ListCount > 0 Then
cbovideoformat.ListIndex = 0
End If

temp = 1
End Sub

Private Sub Image1_Click()

End Sub


Public Function BitmapToPicture(ByVal hBmp As Long) As IPicture

   If (hBmp = 0) Then Exit Function

   Dim NewPic As Picture, tPicConv As PictDesc, IGuid As Guid

   
   With tPicConv
      .cbSizeofStruct = Len(tPicConv)
      .picType = vbPicTypeBitmap
      .hImage = hBmp
   End With

   ' Fill in IDispatch Interface ID
   With IGuid
      .Data1 = &H20400
      .Data4(0) = &HC0
      .Data4(7) = &H46
   End With

   ' Create a picture object:
   OleCreatePictureIndirect tPicConv, IGuid, True, NewPic
   
   ' Return it:
   Set BitmapToPicture = NewPic

End Function

