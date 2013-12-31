namespace iTunes2Twitter
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TweetTextBox = new System.Windows.Forms.TextBox();
            this.ArtWorkPictureBox = new System.Windows.Forms.PictureBox();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.PreviousSongButton = new System.Windows.Forms.Button();
            this.NextSongButton = new System.Windows.Forms.Button();
            this.TweetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArtWorkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TweetTextBox
            // 
            this.TweetTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TweetTextBox.Location = new System.Drawing.Point(-2, -1);
            this.TweetTextBox.Multiline = true;
            this.TweetTextBox.Name = "TweetTextBox";
            this.TweetTextBox.ReadOnly = true;
            this.TweetTextBox.Size = new System.Drawing.Size(537, 61);
            this.TweetTextBox.TabIndex = 0;
            // 
            // ArtWorkPictureBox
            // 
            this.ArtWorkPictureBox.Location = new System.Drawing.Point(12, 66);
            this.ArtWorkPictureBox.Name = "ArtWorkPictureBox";
            this.ArtWorkPictureBox.Size = new System.Drawing.Size(160, 160);
            this.ArtWorkPictureBox.TabIndex = 1;
            this.ArtWorkPictureBox.TabStop = false;
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(329, 203);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(75, 23);
            this.StartStopButton.TabIndex = 2;
            this.StartStopButton.Text = "再生/停止";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // PreviousSongButton
            // 
            this.PreviousSongButton.Location = new System.Drawing.Point(216, 203);
            this.PreviousSongButton.Name = "PreviousSongButton";
            this.PreviousSongButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousSongButton.TabIndex = 3;
            this.PreviousSongButton.Text = "前の曲へ";
            this.PreviousSongButton.UseVisualStyleBackColor = true;
            this.PreviousSongButton.Click += new System.EventHandler(this.PreviousSongButton_Click);
            // 
            // NextSongButton
            // 
            this.NextSongButton.Location = new System.Drawing.Point(436, 203);
            this.NextSongButton.Name = "NextSongButton";
            this.NextSongButton.Size = new System.Drawing.Size(75, 23);
            this.NextSongButton.TabIndex = 4;
            this.NextSongButton.Text = "次の曲へ";
            this.NextSongButton.UseVisualStyleBackColor = true;
            this.NextSongButton.Click += new System.EventHandler(this.NextSongButton_Click);
            // 
            // TweetButton
            // 
            this.TweetButton.Location = new System.Drawing.Point(436, 66);
            this.TweetButton.Name = "TweetButton";
            this.TweetButton.Size = new System.Drawing.Size(75, 23);
            this.TweetButton.TabIndex = 5;
            this.TweetButton.Text = "ツイートする";
            this.TweetButton.UseVisualStyleBackColor = true;
            this.TweetButton.Click += new System.EventHandler(this.TweetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 238);
            this.Controls.Add(this.TweetButton);
            this.Controls.Add(this.NextSongButton);
            this.Controls.Add(this.PreviousSongButton);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.ArtWorkPictureBox);
            this.Controls.Add(this.TweetTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "なにきいてるのー？";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArtWorkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TweetTextBox;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Button PreviousSongButton;
        private System.Windows.Forms.Button NextSongButton;
        private System.Windows.Forms.Button TweetButton;
        internal System.Windows.Forms.PictureBox ArtWorkPictureBox;
    }
}

