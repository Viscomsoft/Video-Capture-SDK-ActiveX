VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "videocap.ocx"
Begin VB.Form Form1 
   Caption         =   "Virtual Screen Capture Plugin Demo"
   ClientHeight    =   10515
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   17655
   LinkTopic       =   "Form1"
   ScaleHeight     =   10515
   ScaleWidth      =   17655
   StartUpPosition =   3  'Windows Default
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   7575
      Left            =   6480
      TabIndex        =   21
      Top             =   840
      Width           =   10455
      _Version        =   65536
      _ExtentX        =   18441
      _ExtentY        =   13361
      _StockProps     =   0
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Stop"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2160
      TabIndex        =   13
      Top             =   5880
      Width           =   1455
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   7560
      Top             =   9600
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Frame Frame1 
      Caption         =   "Virtual Screen Capture Area"
      Height          =   4455
      Left            =   360
      TabIndex        =   3
      Top             =   1200
      Width           =   5295
      Begin VB.CommandButton cmdselcursor 
         Caption         =   "Select"
         Height          =   255
         Left            =   4080
         TabIndex        =   20
         Top             =   4200
         Width           =   975
      End
      Begin VB.TextBox txtcursorfile 
         Height          =   285
         Left            =   240
         TabIndex        =   19
         Top             =   3840
         Width           =   4695
      End
      Begin VB.CheckBox chkusesystemcursor 
         Caption         =   "Use System Cursor"
         Height          =   375
         Left            =   240
         TabIndex        =   17
         Top             =   2880
         Value           =   1  'Checked
         Width           =   1695
      End
      Begin VB.CommandButton Command3 
         Caption         =   "Right Click Color"
         Height          =   315
         Left            =   3720
         TabIndex        =   16
         Top             =   1800
         Width           =   1335
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Left Click Color"
         Height          =   255
         Left            =   2040
         TabIndex        =   15
         Top             =   1800
         Width           =   1335
      End
      Begin VB.CommandButton cmdhighlightcolor 
         Caption         =   "Highlight Color"
         Height          =   255
         Left            =   240
         TabIndex        =   14
         Top             =   1800
         Width           =   1455
      End
      Begin VB.TextBox txtheight 
         Height          =   375
         Left            =   4200
         TabIndex        =   12
         Text            =   "480"
         Top             =   840
         Width           =   615
      End
      Begin VB.TextBox txtwidth 
         Height          =   285
         Left            =   3000
         TabIndex        =   10
         Text            =   "720"
         Top             =   840
         Width           =   495
      End
      Begin VB.TextBox txttop 
         Height          =   375
         Left            =   1800
         TabIndex        =   8
         Text            =   "0"
         Top             =   840
         Width           =   615
      End
      Begin VB.TextBox txtleft 
         Height          =   375
         Left            =   600
         TabIndex        =   6
         Text            =   "0"
         Top             =   840
         Width           =   615
      End
      Begin VB.CheckBox chkfullscreen 
         Caption         =   "Full Screen"
         Height          =   615
         Left            =   240
         TabIndex        =   4
         Top             =   240
         Value           =   1  'Checked
         Width           =   1335
      End
      Begin VB.Label Label6 
         Caption         =   "Cursor File"
         Height          =   495
         Left            =   240
         TabIndex        =   18
         Top             =   3480
         Width           =   975
      End
      Begin VB.Label Label5 
         Caption         =   "Height"
         Height          =   255
         Left            =   3600
         TabIndex        =   11
         Top             =   840
         Width           =   615
      End
      Begin VB.Label Label4 
         Caption         =   "Width"
         Height          =   375
         Left            =   2520
         TabIndex        =   9
         Top             =   840
         Width           =   495
      End
      Begin VB.Label Label3 
         Caption         =   "Top"
         Height          =   255
         Left            =   1320
         TabIndex        =   7
         Top             =   840
         Width           =   495
      End
      Begin VB.Label Label2 
         Caption         =   "Left"
         Height          =   375
         Left            =   120
         TabIndex        =   5
         Top             =   840
         Width           =   375
      End
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Preview"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   480
      TabIndex        =   2
      Top             =   5880
      Width           =   1455
   End
   Begin VB.ComboBox cboDevice 
      Height          =   315
      Left            =   1680
      Style           =   2  'Dropdown List
      TabIndex        =   1
      Top             =   360
      Width           =   3615
   End
   Begin VB.Label Label1 
      Caption         =   "Video Device"
      Height          =   495
      Left            =   240
      TabIndex        =   0
      Top             =   360
      Width           =   975
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub chkfullscreen_Click()
If chkfullscreen.Value = 1 Then
    txtleft.Enabled = False
    txttop.Enabled = False
    txtwidth.Enabled = False
    txtheight.Enabled = False
    
Else
    txtleft.Enabled = True
    txttop.Enabled = True
    txtwidth.Enabled = True
    txtheight.Enabled = True

End If


End Sub

Private Sub cmdhighlightcolor_Click()
CommonDialog1.ShowColor
VideoCap1.VirtualScreenHighlightColor CommonDialog1.Color

End Sub

Private Sub cmdselcursor_Click()
Me.CommonDialog1.Filter = "Cursor File (*.ico)|*.ico|Cursor File (*.cur)|*.cur"

Me.CommonDialog1.ShowOpen

txtcursorfile = CommonDialog1.FileName

End Sub

Private Sub Command1_Click()

VideoCap1.Device = cboDevice.ListIndex

If chkfullscreen.Value = 1 Then
    
 VideoCap1.VirtualScreenCaptureFullScreen True
    
Else
    VideoCap1.VirtualScreenCaptureFullScreen False
     VideoCap1.VirtualScreenCaptureArea txtleft, txttop, txtwidth, txtheight
End If

If chkusesystemcursor.Value = 1 Then
   VideoCap1.VirtualScreenShowSystemCursor True
Else
   VideoCap1.VirtualScreenShowSystemCursor False
   
   
   VideoCap1.VirtualScreenCursorFile txtcursorfile
End If

   


VideoCap1.Start
End Sub

Private Sub Command2_Click()
CommonDialog1.ShowColor
VideoCap1.VirtualScreenLeftClickColor CommonDialog1.Color
End Sub

Private Sub Command3_Click()
CommonDialog1.ShowColor
VideoCap1.VirtualScreenRightClickColor CommonDialog1.Color
End Sub

Private Sub Command4_Click()
VideoCap1.Stop
End Sub

Private Sub Command5_Click()

End Sub

Private Sub Command6_Click()

End Sub

Private Sub Form_Load()
Dim i As Integer
i = 0
For Each mydevice In Me.VideoCap1.Devices
    cboDevice.AddItem mydevice.Name
     
     
     
    If cboDevice.List(i) = "Viscomsoft Virtual Screen Capture" Then
      
        cboDevice.ListIndex = i
    
    End If
   i = i + 1
Next



strapp = App.Path



iFindIndex = InStr(1, strapp, "Examples")

    If iFindIndex > 0 Then
        strapp = Mid(strapp, 1, iFindIndex - 1)
        
     Else
       
            MsgBox "cannot found cursor image"
       
    End If
    
    
  
    txtcursorfile = strapp + "\Cursor\hand-icon.ico"
End Sub
