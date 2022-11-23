﻿namespace VRChatify
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
            this.spotifyToggle = new System.Windows.Forms.CheckBox();
            this.oscMessageLabel = new System.Windows.Forms.Label();
            this.oscMessage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PresenceUpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.presenceDetails = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ForceUpdateSessions = new System.Windows.Forms.Button();
            this.Sessions = new System.Windows.Forms.ListBox();
            this.SessionHolder = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DebugLogging = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // presenceToggle
            // 
            this.presenceToggle.AutoSize = true;
            this.presenceToggle.BackColor = System.Drawing.Color.Transparent;
            this.presenceToggle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.presenceToggle.Location = new System.Drawing.Point(9, 19);
            this.presenceToggle.Name = "presenceToggle";
            this.presenceToggle.Size = new System.Drawing.Size(59, 17);
            this.presenceToggle.TabIndex = 0;
            this.presenceToggle.Text = "Enable";
            this.presenceToggle.UseVisualStyleBackColor = false;
            this.presenceToggle.CheckedChanged += new System.EventHandler(this.PresenceToggle_CheckedChanged);
            // 
            // spotifyToggle
            // 
            this.spotifyToggle.AutoSize = true;
            this.spotifyToggle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.spotifyToggle.Location = new System.Drawing.Point(9, 19);
            this.spotifyToggle.Name = "spotifyToggle";
            this.spotifyToggle.Size = new System.Drawing.Size(122, 17);
            this.spotifyToggle.TabIndex = 2;
            this.spotifyToggle.Text = "OSC Message Send";
            this.spotifyToggle.UseVisualStyleBackColor = true;
            this.spotifyToggle.CheckedChanged += new System.EventHandler(this.SpotifyToggle_CheckedChanged);
            // 
            // oscMessageLabel
            // 
            this.oscMessageLabel.AutoSize = true;
            this.oscMessageLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.oscMessageLabel.Location = new System.Drawing.Point(6, 39);
            this.oscMessageLabel.Name = "oscMessageLabel";
            this.oscMessageLabel.Size = new System.Drawing.Size(75, 13);
            this.oscMessageLabel.TabIndex = 3;
            this.oscMessageLabel.Text = "OSC Message";
            // 
            // oscMessage
            // 
            this.oscMessage.BackColor = System.Drawing.Color.DimGray;
            this.oscMessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.oscMessage.Location = new System.Drawing.Point(6, 55);
            this.oscMessage.Multiline = true;
            this.oscMessage.Name = "oscMessage";
            this.oscMessage.Size = new System.Drawing.Size(228, 42);
            this.oscMessage.TabIndex = 4;
            this.oscMessage.Text = "{SONG} - {ARTIST} | CPU: {CPU}% | RAM: {RAM}% | GPU: {GPU}% | Time: {TIME}";
            this.oscMessage.TextChanged += new System.EventHandler(this.OSCMessage_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oscMessageLabel);
            this.groupBox1.Controls.Add(this.oscMessage);
            this.groupBox1.Controls.Add(this.spotifyToggle);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 115);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OSC Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PresenceUpdateButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.presenceDetails);
            this.groupBox2.Controls.Add(this.presenceToggle);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 115);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discord Presence";
            // 
            // PresenceUpdateButton
            // 
            this.PresenceUpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PresenceUpdateButton.Location = new System.Drawing.Point(6, 81);
            this.PresenceUpdateButton.Name = "PresenceUpdateButton";
            this.PresenceUpdateButton.Size = new System.Drawing.Size(97, 23);
            this.PresenceUpdateButton.TabIndex = 3;
            this.PresenceUpdateButton.Text = "Update";
            this.PresenceUpdateButton.UseVisualStyleBackColor = true;
            this.PresenceUpdateButton.Click += new System.EventHandler(this.PresenceUpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presence Text";
            // 
            // presenceDetails
            // 
            this.presenceDetails.Location = new System.Drawing.Point(6, 55);
            this.presenceDetails.Name = "presenceDetails";
            this.presenceDetails.Size = new System.Drawing.Size(100, 20);
            this.presenceDetails.TabIndex = 1;
            this.presenceDetails.Text = "Using VRchatify";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SessionHolder);
            this.groupBox3.Controls.Add(this.ForceUpdateSessions);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(292, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 236);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Session List";
            // 
            // ForceUpdateSessions
            // 
            this.ForceUpdateSessions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ForceUpdateSessions.Location = new System.Drawing.Point(6, 207);
            this.ForceUpdateSessions.Name = "ForceUpdateSessions";
            this.ForceUpdateSessions.Size = new System.Drawing.Size(187, 23);
            this.ForceUpdateSessions.TabIndex = 1;
            this.ForceUpdateSessions.Text = "Force Update Sessions";
            this.ForceUpdateSessions.UseVisualStyleBackColor = true;
            this.ForceUpdateSessions.Click += new System.EventHandler(this.ForceUpdateSessions_Click);
            // 
            // Sessions
            // 
            this.Sessions.FormattingEnabled = true;
            this.Sessions.Location = new System.Drawing.Point(6, 19);
            this.Sessions.Name = "Sessions";
            this.Sessions.Size = new System.Drawing.Size(187, 147);
            this.Sessions.TabIndex = 0;
            // 
            // SessionHolder
            // 
            this.SessionHolder.Location = new System.Drawing.Point(6, 19);
            this.SessionHolder.Name = "SessionHolder";
            this.SessionHolder.Size = new System.Drawing.Size(187, 182);
            this.SessionHolder.TabIndex = 2;
            this.SessionHolder.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DebugLogging);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Location = new System.Drawing.Point(12, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // DebugLogging
            // 
            this.DebugLogging.AutoSize = true;
            this.DebugLogging.Location = new System.Drawing.Point(9, 20);
            this.DebugLogging.Name = "DebugLogging";
            this.DebugLogging.Size = new System.Drawing.Size(99, 17);
            this.DebugLogging.TabIndex = 0;
            this.DebugLogging.Text = "Debug Logging";
            this.DebugLogging.UseVisualStyleBackColor = true;
            this.DebugLogging.CheckedChanged += new System.EventHandler(this.DebugLogging_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(658, 422);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "VRChatify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox presenceToggle;
        private System.Windows.Forms.CheckBox spotifyToggle;
        private System.Windows.Forms.Label oscMessageLabel;
        private System.Windows.Forms.TextBox oscMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox presenceDetails;
        private System.Windows.Forms.Button PresenceUpdateButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ForceUpdateSessions;
        private System.Windows.Forms.ListBox Sessions;
        private System.Windows.Forms.GroupBox SessionHolder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox DebugLogging;
    }
}