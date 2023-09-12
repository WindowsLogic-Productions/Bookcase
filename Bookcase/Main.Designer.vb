<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToBuyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksOnLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Bookcase.My.Resources.Resources.BC1
        Me.PictureBox1.Location = New System.Drawing.Point(212, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 309)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LibraryToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBookToolStripMenuItem, Me.OpenBookToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NewBookToolStripMenuItem
        '
        Me.NewBookToolStripMenuItem.Name = "NewBookToolStripMenuItem"
        Me.NewBookToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewBookToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.NewBookToolStripMenuItem.Text = "New book..."
        '
        'LibraryToolStripMenuItem
        '
        Me.LibraryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListBooksToolStripMenuItem, Me.BooksToBuyToolStripMenuItem, Me.BooksOnLoanToolStripMenuItem, Me.ToolStripSeparator2, Me.ChangeLibraryToolStripMenuItem})
        Me.LibraryToolStripMenuItem.Name = "LibraryToolStripMenuItem"
        Me.LibraryToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.LibraryToolStripMenuItem.Text = "Library"
        '
        'ListBooksToolStripMenuItem
        '
        Me.ListBooksToolStripMenuItem.Name = "ListBooksToolStripMenuItem"
        Me.ListBooksToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ListBooksToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ListBooksToolStripMenuItem.Text = "List books..."
        '
        'ChangeLibraryToolStripMenuItem
        '
        Me.ChangeLibraryToolStripMenuItem.Name = "ChangeLibraryToolStripMenuItem"
        Me.ChangeLibraryToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ChangeLibraryToolStripMenuItem.Text = "Change library..."
        '
        'BooksToBuyToolStripMenuItem
        '
        Me.BooksToBuyToolStripMenuItem.Name = "BooksToBuyToolStripMenuItem"
        Me.BooksToBuyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BooksToBuyToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.BooksToBuyToolStripMenuItem.Text = "Books to buy..."
        '
        'BooksOnLoanToolStripMenuItem
        '
        Me.BooksOnLoanToolStripMenuItem.Name = "BooksOnLoanToolStripMenuItem"
        Me.BooksOnLoanToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Pause), System.Windows.Forms.Keys)
        Me.BooksOnLoanToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.BooksOnLoanToolStripMenuItem.Text = "Books on loan..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(182, 6)
        '
        'OpenBookToolStripMenuItem
        '
        Me.OpenBookToolStripMenuItem.Name = "OpenBookToolStripMenuItem"
        Me.OpenBookToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenBookToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.OpenBookToolStripMenuItem.Text = "Open book..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(220, 6)
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(162, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 115)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Book Case"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(778, 555)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Main"
        Me.Text = "Book Case - 0 Books"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksToBuyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksOnLoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ChangeLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
