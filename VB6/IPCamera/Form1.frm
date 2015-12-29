VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "videocap.ocx"
Begin VB.Form Form1 
   Caption         =   "IP Camera"
   ClientHeight    =   8610
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   10095
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
   ScaleHeight     =   8610
   ScaleWidth      =   10095
   StartUpPosition =   3  'Windows Default
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   4455
      Left            =   240
      TabIndex        =   9
      Top             =   1560
      Width           =   5415
      _Version        =   65536
      _ExtentX        =   9551
      _ExtentY        =   7858
      _StockProps     =   0
   End
   Begin VB.TextBox txtPass 
      Height          =   270
      Left            =   3960
      TabIndex        =   8
      Top             =   1080
      Width           =   1095
   End
   Begin VB.TextBox txtUserID 
      Height          =   270
      Left            =   1560
      TabIndex        =   6
      Top             =   1080
      Width           =   1095
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Snapshot"
      Height          =   495
      Left            =   4560
      TabIndex        =   4
      Top             =   6480
      Width           =   1935
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   8760
      Top             =   360
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Stop"
      Height          =   495
      Left            =   2640
      TabIndex        =   2
      Top             =   6480
      Width           =   1695
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Start Capture IP Camera"
      Height          =   495
      Left            =   240
      TabIndex        =   1
      Top             =   6480
      Width           =   2295
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
      Height          =   375
      Left            =   480
      TabIndex        =   0
      Text            =   "http://146.176.65.10/axis-cgi/mjpg/video.cgi"
      Top             =   480
      Width           =   6135
   End
   Begin VB.Label Label4 
      Caption         =   "Password"
      Height          =   255
      Left            =   2880
      TabIndex        =   7
      Top             =   1080
      Width           =   855
   End
   Begin VB.Label Label3 
      Caption         =   "User Name"
      Height          =   255
      Left            =   480
      TabIndex        =   5
      Top             =   1080
      Width           =   855
   End
   Begin VB.Label Label1 
      Caption         =   "URL of IP Camera"
      Height          =   255
      Left            =   480
      TabIndex        =   3
      Top             =   120
      Width           =   2895
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub chkusevideocomp_Click()

If chkusevideocomp.Value = 1 Then
    Me.cboVideoCompressor.Enabled = True
    
Else
   Me.cboVideoCompressor.Enabled = False
 
End If

End Sub

Private Sub Command1_Click()
VideoCap1.StopIPCamera

VideoCap1.CaptureMode = False

iresult = VideoCap1.StartIPCamera(Text1, txtUserID, txtPass)



If iresult <> 1 Then

    If iresult = -8 Then MsgBox "The URL is empty"
    
    If iresult = -7 Then MsgBox "Video Compressor cannot use, please select another one"
    
    If iresult = -6 Then MsgBox "Capture Filename empty"
    
    If iresult = -5 Then MsgBox "General network error"
    
    If iresult = -4 Then MsgBox "Authentication failure"
    
    If iresult = -3 Then MsgBox "Invalid Stream, not support this stream"
    
    If iresult = -2 Then MsgBox "Filter failure"
    
     If iresult = -1 Then MsgBox "Create Graph failure"
    
End If


End Sub

Private Sub Command2_Click()
VideoCap1.StopIPCamera
End Sub

Private Sub Command3_Click()


End Sub

Private Sub Command4_Click()

VideoCap1.SnapShotJPEG "c:\test.jpg", 90

MsgBox "save to c:\test.jpg"

End Sub

Private Sub Command5_Click()
End Sub

