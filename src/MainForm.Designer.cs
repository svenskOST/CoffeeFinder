namespace CoffeeFinder
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.Alexander = new System.Windows.Forms.PictureBox();
            this.Coffee = new System.Windows.Forms.PictureBox();
            this.SizeTrackbar = new System.Windows.Forms.TrackBar();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeLog = new System.Windows.Forms.Label();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Alexander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Nineteen Ninety Seven", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(853, 113);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 62);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.RunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RunButton.Font = new System.Drawing.Font("Nineteen Ninety Seven", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunButton.ForeColor = System.Drawing.Color.White;
            this.RunButton.Location = new System.Drawing.Point(853, 27);
            this.RunButton.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(200, 62);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // GridPanel
            // 
            this.GridPanel.Controls.Add(this.Alexander);
            this.GridPanel.Controls.Add(this.Coffee);
            this.GridPanel.Location = new System.Drawing.Point(27, 25);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(801, 740);
            this.GridPanel.TabIndex = 2;
            this.GridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GridPanel_Paint);
            // 
            // Alexander
            // 
            this.Alexander.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Alexander.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Alexander.Image = ((System.Drawing.Image)(resources.GetObject("Alexander.Image")));
            this.Alexander.Location = new System.Drawing.Point(135, 1);
            this.Alexander.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.Alexander.Name = "Alexander";
            this.Alexander.Size = new System.Drawing.Size(131, 121);
            this.Alexander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Alexander.TabIndex = 1;
            this.Alexander.TabStop = false;
            // 
            // Coffee
            // 
            this.Coffee.BackColor = System.Drawing.Color.IndianRed;
            this.Coffee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Coffee.Image = ((System.Drawing.Image)(resources.GetObject("Coffee.Image")));
            this.Coffee.Location = new System.Drawing.Point(1, 1);
            this.Coffee.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.Coffee.Name = "Coffee";
            this.Coffee.Size = new System.Drawing.Size(131, 121);
            this.Coffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coffee.TabIndex = 0;
            this.Coffee.TabStop = false;
            // 
            // SizeTrackbar
            // 
            this.SizeTrackbar.Location = new System.Drawing.Point(875, 277);
            this.SizeTrackbar.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.SizeTrackbar.Maximum = 4;
            this.SizeTrackbar.Name = "SizeTrackbar";
            this.SizeTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SizeTrackbar.Size = new System.Drawing.Size(56, 271);
            this.SizeTrackbar.TabIndex = 3;
            this.SizeTrackbar.Value = 2;
            this.SizeTrackbar.ValueChanged += new System.EventHandler(this.SizeTrackbar_ValueChanged);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Nineteen Ninety Seven", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.ForeColor = System.Drawing.Color.White;
            this.SizeLabel.Location = new System.Drawing.Point(900, 222);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(89, 31);
            this.SizeLabel.TabIndex = 4;
            this.SizeLabel.Text = "Size:";
            // 
            // SizeLog
            // 
            this.SizeLog.AutoSize = true;
            this.SizeLog.Font = new System.Drawing.Font("Nineteen Ninety Seven", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLog.ForeColor = System.Drawing.Color.White;
            this.SizeLog.Location = new System.Drawing.Point(961, 398);
            this.SizeLog.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.SizeLog.Name = "SizeLog";
            this.SizeLog.Size = new System.Drawing.Size(52, 26);
            this.SizeLog.TabIndex = 5;
            this.SizeLog.Text = "60";
            // 
            // SearchTimer
            // 
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1080, 788);
            this.Controls.Add(this.SizeLog);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.SizeTrackbar);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Finder";
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Alexander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.PictureBox Coffee;
        private System.Windows.Forms.TrackBar SizeTrackbar;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label SizeLog;
        private System.Windows.Forms.PictureBox Alexander;
        private System.Windows.Forms.Timer SearchTimer;
    }
}

