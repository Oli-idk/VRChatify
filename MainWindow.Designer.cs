namespace VRChatify
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.presenceToggle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spotifyToggle = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // presenceToggle
            // 
            this.presenceToggle.AutoSize = true;
            this.presenceToggle.Location = new System.Drawing.Point(12, 34);
            this.presenceToggle.Name = "presenceToggle";
            this.presenceToggle.Size = new System.Drawing.Size(110, 17);
            this.presenceToggle.TabIndex = 0;
            this.presenceToggle.Text = "Discord Presence";
            this.presenceToggle.UseVisualStyleBackColor = true;
            this.presenceToggle.CheckedChanged += new System.EventHandler(this.presenceToggle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // spotifyToggle
            // 
            this.spotifyToggle.AutoSize = true;
            this.spotifyToggle.Location = new System.Drawing.Point(12, 57);
            this.spotifyToggle.Name = "spotifyToggle";
            this.spotifyToggle.Size = new System.Drawing.Size(122, 17);
            this.spotifyToggle.TabIndex = 2;
            this.spotifyToggle.Text = "OSC Message Send";
            this.spotifyToggle.UseVisualStyleBackColor = true;
            this.spotifyToggle.CheckedChanged += new System.EventHandler(this.spotifyToggle_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "OSC Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 42);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "{SPOTIFY} | CPU: {CPU}% | RAM: {RAM}% | GPU: {GPU}% | Time: {TIME}";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spotifyToggle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.presenceToggle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "VRChatify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox presenceToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox spotifyToggle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}