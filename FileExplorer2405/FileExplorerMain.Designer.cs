namespace _240520
{
    partial class FileExplorerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myTabControl = new System.Windows.Forms.TabControl();
            this.colorPage = new System.Windows.Forms.TabPage();
            this.undoBtn = new System.Windows.Forms.Button();
            this.changeBkColor = new System.Windows.Forms.Button();
            this.textPanel = new System.Windows.Forms.Panel();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorChangerBtn = new System.Windows.Forms.Button();
            this.myTrackBar = new System.Windows.Forms.TrackBar();
            this.imagePage = new System.Windows.Forms.TabPage();
            this.openImgFileBtn = new System.Windows.Forms.Button();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.textfilePage = new System.Windows.Forms.TabPage();
            this.internetTab = new System.Windows.Forms.TabPage();
            this.browseBtn = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.myWebBrowser = new System.Windows.Forms.WebBrowser();
            this.taskTab = new System.Windows.Forms.TabPage();
            this.progrssLbl = new System.Windows.Forms.Label();
            this.tasksProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.myTabControl.SuspendLayout();
            this.colorPage.SuspendLayout();
            this.textPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar)).BeginInit();
            this.imagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.internetTab.SuspendLayout();
            this.taskTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTabControl
            // 
            this.myTabControl.Controls.Add(this.colorPage);
            this.myTabControl.Controls.Add(this.imagePage);
            this.myTabControl.Controls.Add(this.textfilePage);
            this.myTabControl.Controls.Add(this.internetTab);
            this.myTabControl.Controls.Add(this.taskTab);
            this.myTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabControl.Location = new System.Drawing.Point(0, 0);
            this.myTabControl.Name = "myTabControl";
            this.myTabControl.SelectedIndex = 0;
            this.myTabControl.Size = new System.Drawing.Size(861, 616);
            this.myTabControl.TabIndex = 0;
            // 
            // colorPage
            // 
            this.colorPage.Controls.Add(this.undoBtn);
            this.colorPage.Controls.Add(this.changeBkColor);
            this.colorPage.Controls.Add(this.textPanel);
            this.colorPage.Controls.Add(this.colorChangerBtn);
            this.colorPage.Controls.Add(this.myTrackBar);
            this.colorPage.Location = new System.Drawing.Point(4, 25);
            this.colorPage.Name = "colorPage";
            this.colorPage.Padding = new System.Windows.Forms.Padding(3);
            this.colorPage.Size = new System.Drawing.Size(853, 587);
            this.colorPage.TabIndex = 0;
            this.colorPage.Text = "Color";
            this.colorPage.UseVisualStyleBackColor = true;
            // 
            // undoBtn
            // 
            this.undoBtn.BackgroundImage = global::_240520.Properties.Resources.undo;
            this.undoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undoBtn.Location = new System.Drawing.Point(219, 307);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(60, 47);
            this.undoBtn.TabIndex = 5;
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Visible = false;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // changeBkColor
            // 
            this.changeBkColor.Location = new System.Drawing.Point(467, 307);
            this.changeBkColor.Name = "changeBkColor";
            this.changeBkColor.Size = new System.Drawing.Size(162, 47);
            this.changeBkColor.TabIndex = 4;
            this.changeBkColor.Text = "Change Background";
            this.changeBkColor.UseVisualStyleBackColor = true;
            this.changeBkColor.Click += new System.EventHandler(this.changeBkColor_Click);
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.colorLabel);
            this.textPanel.Location = new System.Drawing.Point(0, 3);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(847, 236);
            this.textPanel.TabIndex = 3;
            // 
            // colorLabel
            // 
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.colorLabel.Location = new System.Drawing.Point(3, 85);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(841, 72);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "I LOVE .NET";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorChangerBtn
            // 
            this.colorChangerBtn.Location = new System.Drawing.Point(294, 307);
            this.colorChangerBtn.Name = "colorChangerBtn";
            this.colorChangerBtn.Size = new System.Drawing.Size(155, 47);
            this.colorChangerBtn.TabIndex = 2;
            this.colorChangerBtn.Text = "Change Color";
            this.colorChangerBtn.UseVisualStyleBackColor = true;
            this.colorChangerBtn.Click += new System.EventHandler(this.colorChangerBtn_Click);
            // 
            // myTrackBar
            // 
            this.myTrackBar.Location = new System.Drawing.Point(5, 245);
            this.myTrackBar.Name = "myTrackBar";
            this.myTrackBar.Size = new System.Drawing.Size(842, 56);
            this.myTrackBar.TabIndex = 1;
            this.myTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.myTrackBar.Scroll += new System.EventHandler(this.myTrackBar_Scroll);
            // 
            // imagePage
            // 
            this.imagePage.Controls.Add(this.openImgFileBtn);
            this.imagePage.Controls.Add(this.myPictureBox);
            this.imagePage.Location = new System.Drawing.Point(4, 25);
            this.imagePage.Name = "imagePage";
            this.imagePage.Padding = new System.Windows.Forms.Padding(3);
            this.imagePage.Size = new System.Drawing.Size(853, 587);
            this.imagePage.TabIndex = 1;
            this.imagePage.Text = "Image";
            this.imagePage.UseVisualStyleBackColor = true;
            // 
            // openImgFileBtn
            // 
            this.openImgFileBtn.Location = new System.Drawing.Point(330, 495);
            this.openImgFileBtn.Name = "openImgFileBtn";
            this.openImgFileBtn.Size = new System.Drawing.Size(140, 41);
            this.openImgFileBtn.TabIndex = 1;
            this.openImgFileBtn.Text = "Open Image";
            this.openImgFileBtn.UseVisualStyleBackColor = true;
            this.openImgFileBtn.Click += new System.EventHandler(this.openImgFileBtn_Click);
            // 
            // myPictureBox
            // 
            this.myPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPictureBox.Location = new System.Drawing.Point(3, 3);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(847, 445);
            this.myPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPictureBox.TabIndex = 0;
            this.myPictureBox.TabStop = false;
            // 
            // textfilePage
            // 
            this.textfilePage.Location = new System.Drawing.Point(4, 25);
            this.textfilePage.Name = "textfilePage";
            this.textfilePage.Size = new System.Drawing.Size(853, 587);
            this.textfilePage.TabIndex = 2;
            this.textfilePage.Text = "Text file";
            this.textfilePage.UseVisualStyleBackColor = true;
            // 
            // internetTab
            // 
            this.internetTab.Controls.Add(this.browseBtn);
            this.internetTab.Controls.Add(this.urlTextBox);
            this.internetTab.Controls.Add(this.myWebBrowser);
            this.internetTab.Location = new System.Drawing.Point(4, 25);
            this.internetTab.Name = "internetTab";
            this.internetTab.Size = new System.Drawing.Size(853, 587);
            this.internetTab.TabIndex = 3;
            this.internetTab.Text = "Browser";
            this.internetTab.UseVisualStyleBackColor = true;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(24, 520);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(130, 29);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Go to this URL";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(24, 472);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(388, 22);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.Text = "http://";
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyDown);
            // 
            // myWebBrowser
            // 
            this.myWebBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.myWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.myWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.myWebBrowser.Name = "myWebBrowser";
            this.myWebBrowser.Size = new System.Drawing.Size(853, 424);
            this.myWebBrowser.TabIndex = 0;
            // 
            // taskTab
            // 
            this.taskTab.Controls.Add(this.progrssLbl);
            this.taskTab.Controls.Add(this.tasksProgressBar);
            this.taskTab.Controls.Add(this.panel1);
            this.taskTab.Location = new System.Drawing.Point(4, 25);
            this.taskTab.Name = "taskTab";
            this.taskTab.Size = new System.Drawing.Size(853, 587);
            this.taskTab.TabIndex = 4;
            this.taskTab.Text = "My tasks";
            this.taskTab.UseVisualStyleBackColor = true;
            // 
            // progrssLbl
            // 
            this.progrssLbl.Font = new System.Drawing.Font("Miriam", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.progrssLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progrssLbl.Location = new System.Drawing.Point(8, 489);
            this.progrssLbl.Name = "progrssLbl";
            this.progrssLbl.Size = new System.Drawing.Size(842, 23);
            this.progrssLbl.TabIndex = 2;
            this.progrssLbl.Text = "You are done! time to watch TV";
            this.progrssLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progrssLbl.Visible = false;
            // 
            // tasksProgressBar
            // 
            this.tasksProgressBar.Location = new System.Drawing.Point(80, 440);
            this.tasksProgressBar.Name = "tasksProgressBar";
            this.tasksProgressBar.Size = new System.Drawing.Size(683, 23);
            this.tasksProgressBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 395);
            this.panel1.TabIndex = 0;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(510, 218);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Clean room";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_Any_Changed);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(510, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Wash car";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_Any_Changed);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(201, 218);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Buy milk";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_Any_Changed);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(201, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Prepare for test";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_Any_Changed);
            // 
            // FileExplorerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 616);
            this.Controls.Add(this.myTabControl);
            this.Name = "FileExplorerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.myTabControl.ResumeLayout(false);
            this.colorPage.ResumeLayout(false);
            this.colorPage.PerformLayout();
            this.textPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myTrackBar)).EndInit();
            this.imagePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.internetTab.ResumeLayout(false);
            this.internetTab.PerformLayout();
            this.taskTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl myTabControl;
        private System.Windows.Forms.TabPage colorPage;
        private System.Windows.Forms.TabPage imagePage;
        private System.Windows.Forms.TabPage textfilePage;
        private System.Windows.Forms.Button colorChangerBtn;
        private System.Windows.Forms.TrackBar myTrackBar;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button changeBkColor;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button openImgFileBtn;
        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabPage internetTab;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.WebBrowser myWebBrowser;
        private System.Windows.Forms.TabPage taskTab;
        private System.Windows.Forms.Label progrssLbl;
        private System.Windows.Forms.ProgressBar tasksProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

