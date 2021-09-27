
namespace IssueMAnagementSystemV1._0.Presentation_Layer
{
    partial class LoadingPage
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
            this.Loading_progressBar = new System.Windows.Forms.ProgressBar();
            this.Load_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Load_timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Loading_progressBar
            // 
            this.Loading_progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Loading_progressBar.Location = new System.Drawing.Point(225, 395);
            this.Loading_progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loading_progressBar.Name = "Loading_progressBar";
            this.Loading_progressBar.Size = new System.Drawing.Size(597, 28);
            this.Loading_progressBar.TabIndex = 10;
            this.Loading_progressBar.Click += new System.EventHandler(this.Loading_progressBar_Click);
            // 
            // Load_label
            // 
            this.Load_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_label.AutoSize = true;
            this.Load_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_label.Location = new System.Drawing.Point(435, 341);
            this.Load_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Load_label.Name = "Load_label";
            this.Load_label.Size = new System.Drawing.Size(108, 20);
            this.Load_label.TabIndex = 9;
            this.Load_label.Text = "Loading . . .";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IssueMAnagementSystemV1._0.Properties.Resources.MicrosoftTeams_image__14_;
            this.pictureBox1.Location = new System.Drawing.Point(317, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Load_timer
            // 
            this.Load_timer.Interval = 30;
            this.Load_timer.Tick += new System.EventHandler(this.Load_timer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("BankGothic Lt BT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "Issue_Management_System";
            // 
            // LoadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loading_progressBar);
            this.Controls.Add(this.Load_label);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoadingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadingPage_FormClosing);
            this.Load += new System.EventHandler(this.LoadingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Loading_progressBar;
        private System.Windows.Forms.Label Load_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Load_timer;
        private System.Windows.Forms.Label label1;
    }
}