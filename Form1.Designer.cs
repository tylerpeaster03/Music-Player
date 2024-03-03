namespace AudioPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listMusic = new System.Windows.Forms.ListBox();
            this.BtnSelectMusic = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMusic
            // 
            this.listMusic.BackColor = System.Drawing.Color.DarkGray;
            this.listMusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMusic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMusic.FormattingEnabled = true;
            this.listMusic.ItemHeight = 22;
            this.listMusic.Location = new System.Drawing.Point(12, 90);
            this.listMusic.Name = "listMusic";
            this.listMusic.Size = new System.Drawing.Size(811, 376);
            this.listMusic.TabIndex = 1;
            this.listMusic.SelectedIndexChanged += new System.EventHandler(this.listMusic_SelectedIndexChanged);
            // 
            // BtnSelectMusic
            // 
            this.BtnSelectMusic.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelectMusic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSelectMusic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectMusic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSelectMusic.Location = new System.Drawing.Point(12, 43);
            this.BtnSelectMusic.Name = "BtnSelectMusic";
            this.BtnSelectMusic.Size = new System.Drawing.Size(364, 25);
            this.BtnSelectMusic.TabIndex = 2;
            this.BtnSelectMusic.Text = "Select Music";
            this.BtnSelectMusic.UseVisualStyleBackColor = false;
            this.BtnSelectMusic.Click += new System.EventHandler(this.BtnSelectMusic_Click);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(0, 504);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(835, 46);
            this.axWindowsMediaPlayer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 28);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Music Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(835, 550);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.BtnSelectMusic);
            this.Controls.Add(this.listMusic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listMusic;
        private System.Windows.Forms.Button BtnSelectMusic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

