namespace Plugin
{
    partial class ForumForm
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
            this.forumBrowserControl1 = new Plugin.ForumBrowserControl();
            this.SuspendLayout();
            // 
            // forumBrowserControl1
            // 
            this.forumBrowserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forumBrowserControl1.Location = new System.Drawing.Point(0, 0);
            this.forumBrowserControl1.Name = "forumBrowserControl1";
            this.forumBrowserControl1.Size = new System.Drawing.Size(734, 443);
            this.forumBrowserControl1.TabIndex = 0;
            // 
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 443);
            this.ControlBox = false;
            this.Controls.Add(this.forumBrowserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ForumForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Forum";
            this.ResumeLayout(false);

        }

        #endregion

        private ForumBrowserControl forumBrowserControl1;
    }
}