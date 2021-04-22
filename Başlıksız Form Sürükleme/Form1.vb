Public Class Form1
    Public Const HT_CAPTION As Integer = &H2
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1

    Private Sub ToolStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStrip1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
        End If

        Me.WndProc(Message.Create(Me.Handle, WM_NCLBUTTONDOWN, CType(HT_CAPTION, IntPtr), IntPtr.Zero))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripLabel2.Text = Me.Text
    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        End
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
