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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("{SONG}: Current Song");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("{ARTIST}: Songs Artist");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("{SPOTIFY}: Shows spotifys current song/artist");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("{CPU}: CPU Usage");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("{GPU}: GPU Usage");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("{RAM}: Ram Usage");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("{TIME}: current time (12h)");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("{MTIME}: current time (24h)");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("{WINDOW}: Currently focused window");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("{DURATION}: song total duration");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("{POSITION}: song current positon");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("{CLANTAG}: clantag idk");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.presenceToggle = new System.Windows.Forms.CheckBox();
            this.OSCToggle = new System.Windows.Forms.CheckBox();
            this.oscMessageLabel = new System.Windows.Forms.Label();
            this.oscMessage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PresenceUpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.presenceDetails = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SessionHolder = new System.Windows.Forms.GroupBox();
            this.ForceUpdateSessions = new System.Windows.Forms.Button();
            this.Sessions = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ClanTagLabel = new System.Windows.Forms.Label();
            this.ClanTag = new System.Windows.Forms.TextBox();
            this.DebugLogging = new System.Windows.Forms.CheckBox();
            this.Placeholders = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Placeholders.SuspendLayout();
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
            // OSCToggle
            // 
            this.OSCToggle.AutoSize = true;
            this.OSCToggle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OSCToggle.Location = new System.Drawing.Point(9, 19);
            this.OSCToggle.Name = "OSCToggle";
            this.OSCToggle.Size = new System.Drawing.Size(122, 17);
            this.OSCToggle.TabIndex = 2;
            this.OSCToggle.Text = "OSC Message Send";
            this.OSCToggle.UseVisualStyleBackColor = true;
            this.OSCToggle.CheckedChanged += new System.EventHandler(this.OSCToggle_CheckedChanged);
            // 
            // oscMessageLabel
            // 
            this.oscMessageLabel.AutoSize = true;
            this.oscMessageLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.oscMessageLabel.Location = new System.Drawing.Point(7, 39);
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
            this.oscMessage.Size = new System.Drawing.Size(262, 54);
            this.oscMessage.TabIndex = 4;
            this.oscMessage.Text = "{SONG} - {ARTIST} | CPU: {CPU}% | RAM: {RAM}% | GPU: {GPU}% | Time: {TIME} | {CLA" +
    "NTAG}";
            this.oscMessage.TextChanged += new System.EventHandler(this.OSCMessage_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oscMessageLabel);
            this.groupBox1.Controls.Add(this.oscMessage);
            this.groupBox1.Controls.Add(this.OSCToggle);
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
            this.groupBox3.Size = new System.Drawing.Size(200, 342);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Session List";
            // 
            // SessionHolder
            // 
            this.SessionHolder.Location = new System.Drawing.Point(6, 19);
            this.SessionHolder.Name = "SessionHolder";
            this.SessionHolder.Size = new System.Drawing.Size(187, 288);
            this.SessionHolder.TabIndex = 2;
            this.SessionHolder.TabStop = false;
            // 
            // ForceUpdateSessions
            // 
            this.ForceUpdateSessions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ForceUpdateSessions.Location = new System.Drawing.Point(7, 313);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClanTagLabel);
            this.groupBox4.Controls.Add(this.ClanTag);
            this.groupBox4.Controls.Add(this.DebugLogging);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Location = new System.Drawing.Point(12, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // ClanTagLabel
            // 
            this.ClanTagLabel.AutoSize = true;
            this.ClanTagLabel.Location = new System.Drawing.Point(9, 40);
            this.ClanTagLabel.Name = "ClanTagLabel";
            this.ClanTagLabel.Size = new System.Drawing.Size(50, 13);
            this.ClanTagLabel.TabIndex = 5;
            this.ClanTagLabel.Text = "Clan Tag";
            // 
            // ClanTag
            // 
            this.ClanTag.Location = new System.Drawing.Point(9, 56);
            this.ClanTag.Name = "ClanTag";
            this.ClanTag.Size = new System.Drawing.Size(122, 20);
            this.ClanTag.TabIndex = 4;
            this.ClanTag.Text = "VRChatify";
            this.ClanTag.TextChanged += new System.EventHandler(this.ClanTag_TextChanged);
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
            // Placeholders
            // 
            this.Placeholders.Controls.Add(this.listView1);
            this.Placeholders.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Placeholders.Location = new System.Drawing.Point(499, 13);
            this.Placeholders.Name = "Placeholders";
            this.Placeholders.Size = new System.Drawing.Size(269, 341);
            this.Placeholders.TabIndex = 9;
            this.Placeholders.TabStop = false;
            this.Placeholders.Text = "Placeholders";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 322);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(200, 30);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 368);
            this.Controls.Add(this.Placeholders);
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
            this.Placeholders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox presenceToggle;
        private System.Windows.Forms.CheckBox OSCToggle;
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
        private System.Windows.Forms.Label ClanTagLabel;
        private System.Windows.Forms.TextBox ClanTag;
        private System.Windows.Forms.GroupBox Placeholders;
        private System.Windows.Forms.ListView listView1;
    }
}