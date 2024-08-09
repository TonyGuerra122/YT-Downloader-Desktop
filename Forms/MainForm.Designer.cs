namespace YTDownloaderDesktop;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        panel1 = new Panel();
        BtnMinimizeForm = new FontAwesome.Sharp.IconButton();
        BtnCloseForm = new FontAwesome.Sharp.IconButton();
        TBUrl = new TextBox();
        LabelUrl = new Label();
        BtnDownload = new Button();
        PBLoader = new PictureBox();
        PBThumb = new PictureBox();
        LabelVideoName = new Label();
        LabelVideoDuration = new Label();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PBLoader).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PBThumb).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(18, 18, 18);
        panel1.Controls.Add(BtnMinimizeForm);
        panel1.Controls.Add(BtnCloseForm);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1198, 51);
        panel1.TabIndex = 0;
        panel1.MouseDown += MouseDownAction;
        // 
        // BtnMinimizeForm
        // 
        BtnMinimizeForm.Cursor = Cursors.Hand;
        BtnMinimizeForm.FlatAppearance.BorderSize = 0;
        BtnMinimizeForm.FlatStyle = FlatStyle.Flat;
        BtnMinimizeForm.IconChar = FontAwesome.Sharp.IconChar.Subtract;
        BtnMinimizeForm.IconColor = Color.White;
        BtnMinimizeForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
        BtnMinimizeForm.Location = new Point(1090, 3);
        BtnMinimizeForm.Name = "BtnMinimizeForm";
        BtnMinimizeForm.Size = new Size(51, 47);
        BtnMinimizeForm.TabIndex = 1;
        BtnMinimizeForm.UseVisualStyleBackColor = true;
        BtnMinimizeForm.Click += MinimizeFormAction;
        // 
        // BtnCloseForm
        // 
        BtnCloseForm.Cursor = Cursors.Hand;
        BtnCloseForm.FlatAppearance.BorderSize = 0;
        BtnCloseForm.FlatStyle = FlatStyle.Flat;
        BtnCloseForm.IconChar = FontAwesome.Sharp.IconChar.Close;
        BtnCloseForm.IconColor = Color.White;
        BtnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
        BtnCloseForm.Location = new Point(1147, 3);
        BtnCloseForm.Name = "BtnCloseForm";
        BtnCloseForm.Size = new Size(51, 47);
        BtnCloseForm.TabIndex = 0;
        BtnCloseForm.UseVisualStyleBackColor = true;
        BtnCloseForm.Click += CloseFormAction;
        // 
        // TBUrl
        // 
        TBUrl.AcceptsReturn = true;
        TBUrl.Location = new Point(279, 617);
        TBUrl.Name = "TBUrl";
        TBUrl.Size = new Size(654, 27);
        TBUrl.TabIndex = 1;
        TBUrl.TextChanged += WriteUrlAction;
        // 
        // LabelUrl
        // 
        LabelUrl.AutoSize = true;
        LabelUrl.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LabelUrl.ForeColor = Color.White;
        LabelUrl.Location = new Point(505, 537);
        LabelUrl.Name = "LabelUrl";
        LabelUrl.Size = new Size(217, 39);
        LabelUrl.TabIndex = 2;
        LabelUrl.Text = "Url do Vídeo";
        // 
        // BtnDownload
        // 
        BtnDownload.BackColor = Color.FromArgb(18, 18, 18);
        BtnDownload.Cursor = Cursors.Hand;
        BtnDownload.FlatStyle = FlatStyle.Flat;
        BtnDownload.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BtnDownload.ForeColor = Color.White;
        BtnDownload.Location = new Point(448, 690);
        BtnDownload.Name = "BtnDownload";
        BtnDownload.Size = new Size(310, 86);
        BtnDownload.TabIndex = 3;
        BtnDownload.Text = "Baixar";
        BtnDownload.UseVisualStyleBackColor = false;
        BtnDownload.Visible = false;
        BtnDownload.Click += BtnDownloadAction;
        // 
        // PBLoader
        // 
        PBLoader.Image = (Image)resources.GetObject("PBLoader.Image");
        PBLoader.Location = new Point(448, 690);
        PBLoader.Name = "PBLoader";
        PBLoader.Size = new Size(310, 86);
        PBLoader.SizeMode = PictureBoxSizeMode.Zoom;
        PBLoader.TabIndex = 4;
        PBLoader.TabStop = false;
        PBLoader.Visible = false;
        // 
        // PBThumb
        // 
        PBThumb.Location = new Point(448, 91);
        PBThumb.Name = "PBThumb";
        PBThumb.Size = new Size(350, 350);
        PBThumb.SizeMode = PictureBoxSizeMode.Zoom;
        PBThumb.TabIndex = 5;
        PBThumb.TabStop = false;
        PBThumb.Visible = false;
        // 
        // LabelVideoName
        // 
        LabelVideoName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        LabelVideoName.ForeColor = Color.White;
        LabelVideoName.Location = new Point(0, 444);
        LabelVideoName.Name = "LabelVideoName";
        LabelVideoName.Size = new Size(1198, 25);
        LabelVideoName.TabIndex = 7;
        LabelVideoName.Text = "Url do Vídeo";
        LabelVideoName.TextAlign = ContentAlignment.MiddleCenter;
        LabelVideoName.Visible = false;
        // 
        // LabelVideoDuration
        // 
        LabelVideoDuration.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        LabelVideoDuration.ForeColor = Color.White;
        LabelVideoDuration.Location = new Point(0, 469);
        LabelVideoDuration.Name = "LabelVideoDuration";
        LabelVideoDuration.Size = new Size(1198, 25);
        LabelVideoDuration.TabIndex = 8;
        LabelVideoDuration.Text = "Duração do Vídeo";
        LabelVideoDuration.TextAlign = ContentAlignment.MiddleCenter;
        LabelVideoDuration.Visible = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(51, 51, 51);
        CausesValidation = false;
        ClientSize = new Size(1198, 810);
        Controls.Add(LabelVideoDuration);
        Controls.Add(LabelVideoName);
        Controls.Add(PBThumb);
        Controls.Add(PBLoader);
        Controls.Add(BtnDownload);
        Controls.Add(LabelUrl);
        Controls.Add(TBUrl);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MainForm";
        Text = "Form1";
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PBLoader).EndInit();
        ((System.ComponentModel.ISupportInitialize)PBThumb).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private FontAwesome.Sharp.IconButton BtnCloseForm;
    private FontAwesome.Sharp.IconButton BtnMinimizeForm;
    private TextBox TBUrl;
    private Label LabelUrl;
    private Button BtnDownload;
    private PictureBox PBLoader;
    private PictureBox PBThumb;
    private Label LabelVideoName;
    private Label LabelVideoDuration;
}
