
namespace Epacsenur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contract = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.NotifyIcon(this.components);
            this.osrs = new System.Windows.Forms.WebBrowser();
            this.Holder = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ircPanel = new System.Windows.Forms.Panel();
            this.setName = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.messagesList = new System.Windows.Forms.RichTextBox();
            this.sendmessageBox = new System.Windows.Forms.RichTextBox();
            this.sendmessageButton = new System.Windows.Forms.Button();
            this.reddit = new System.Windows.Forms.PictureBox();
            this.zulrahPlugin = new System.Windows.Forms.PictureBox();
            this.Merch = new System.Windows.Forms.PictureBox();
            this.osrs_wiki = new System.Windows.Forms.PictureBox();
            this.openChat = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Holder.SuspendLayout();
            this.ircPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reddit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zulrahPlugin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osrs_wiki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openChat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.Contract);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2818, 54);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // Contract
            // 
            this.Contract.BackgroundImage = global::Epacsenur.Properties.Resources.Left;
            this.Contract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Contract.Location = new System.Drawing.Point(2670, 6);
            this.Contract.Margin = new System.Windows.Forms.Padding(6);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(32, 42);
            this.Contract.TabIndex = 3;
            this.Contract.TabStop = false;
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(68, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Epacsenur";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Epacsenur.Properties.Resources.Logo_png;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 52);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Epacsenur.Properties.Resources.dash;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(2714, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Epacsenur.Properties.Resources.x;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2766, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Minimize
            // 
            this.Minimize.Icon = ((System.Drawing.Icon)(resources.GetObject("Minimize.Icon")));
            this.Minimize.Text = "Epacsenur";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // osrs
            // 
            this.osrs.Location = new System.Drawing.Point(24, 63);
            this.osrs.Margin = new System.Windows.Forms.Padding(6);
            this.osrs.MinimumSize = new System.Drawing.Size(40, 38);
            this.osrs.Name = "osrs";
            this.osrs.ScriptErrorsSuppressed = true;
            this.osrs.ScrollBarsEnabled = false;
            this.osrs.Size = new System.Drawing.Size(1554, 1029);
            this.osrs.TabIndex = 2;
            this.osrs.WebBrowserShortcutsEnabled = false;
            // 
            // Holder
            // 
            this.Holder.Controls.Add(this.label3);
            this.Holder.Controls.Add(this.label2);
            this.Holder.Location = new System.Drawing.Point(1610, 63);
            this.Holder.Margin = new System.Windows.Forms.Padding(6);
            this.Holder.Name = "Holder";
            this.Holder.Size = new System.Drawing.Size(1146, 1029);
            this.Holder.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(32, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(639, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "This is a simple resource filled client made by Sphere and Konrad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "About";
            // 
            // ircPanel
            // 
            this.ircPanel.Controls.Add(this.richTextBox1);
            this.ircPanel.Controls.Add(this.setName);
            this.ircPanel.Controls.Add(this.usernameInput);
            this.ircPanel.Controls.Add(this.messagesList);
            this.ircPanel.Controls.Add(this.sendmessageBox);
            this.ircPanel.Controls.Add(this.sendmessageButton);
            this.ircPanel.Location = new System.Drawing.Point(1606, 64);
            this.ircPanel.Margin = new System.Windows.Forms.Padding(6);
            this.ircPanel.Name = "ircPanel";
            this.ircPanel.Size = new System.Drawing.Size(1146, 1029);
            this.ircPanel.TabIndex = 2;
            this.ircPanel.Visible = false;
            // 
            // setName
            // 
            this.setName.Location = new System.Drawing.Point(920, 183);
            this.setName.Margin = new System.Windows.Forms.Padding(6);
            this.setName.Name = "setName";
            this.setName.Size = new System.Drawing.Size(202, 117);
            this.setName.TabIndex = 4;
            this.setName.Text = "Set Username";
            this.setName.UseVisualStyleBackColor = true;
            this.setName.Click += new System.EventHandler(this.setName_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(920, 133);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(6);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(216, 31);
            this.usernameInput.TabIndex = 3;
            // 
            // messagesList
            // 
            this.messagesList.Location = new System.Drawing.Point(6, 50);
            this.messagesList.Margin = new System.Windows.Forms.Padding(6);
            this.messagesList.Name = "messagesList";
            this.messagesList.ReadOnly = true;
            this.messagesList.Size = new System.Drawing.Size(898, 810);
            this.messagesList.TabIndex = 2;
            this.messagesList.Text = "";
            // 
            // sendmessageBox
            // 
            this.sendmessageBox.Location = new System.Drawing.Point(0, 896);
            this.sendmessageBox.Margin = new System.Windows.Forms.Padding(6);
            this.sendmessageBox.Name = "sendmessageBox";
            this.sendmessageBox.Size = new System.Drawing.Size(904, 114);
            this.sendmessageBox.TabIndex = 1;
            this.sendmessageBox.Text = "";
            // 
            // sendmessageButton
            // 
            this.sendmessageButton.Location = new System.Drawing.Point(920, 896);
            this.sendmessageButton.Margin = new System.Windows.Forms.Padding(6);
            this.sendmessageButton.Name = "sendmessageButton";
            this.sendmessageButton.Size = new System.Drawing.Size(202, 117);
            this.sendmessageButton.TabIndex = 0;
            this.sendmessageButton.Text = "Send Message";
            this.sendmessageButton.UseVisualStyleBackColor = true;
            this.sendmessageButton.Click += new System.EventHandler(this.sendmessageButton_Click);
            // 
            // reddit
            // 
            this.reddit.BackgroundImage = global::Epacsenur.Properties.Resources.Reddit_Logo;
            this.reddit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reddit.Location = new System.Drawing.Point(2764, 263);
            this.reddit.Margin = new System.Windows.Forms.Padding(6);
            this.reddit.Name = "reddit";
            this.reddit.Size = new System.Drawing.Size(40, 38);
            this.reddit.TabIndex = 2;
            this.reddit.TabStop = false;
            this.reddit.Click += new System.EventHandler(this.Reddit_Click);
            this.reddit.MouseEnter += new System.EventHandler(this.Reddit_MouseEnter);
            this.reddit.MouseLeave += new System.EventHandler(this.Reddit_MouseLeave);
            // 
            // zulrahPlugin
            // 
            this.zulrahPlugin.BackgroundImage = global::Epacsenur.Properties.Resources.Serpentine_helm;
            this.zulrahPlugin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zulrahPlugin.Location = new System.Drawing.Point(2764, 163);
            this.zulrahPlugin.Margin = new System.Windows.Forms.Padding(6);
            this.zulrahPlugin.Name = "zulrahPlugin";
            this.zulrahPlugin.Size = new System.Drawing.Size(40, 38);
            this.zulrahPlugin.TabIndex = 2;
            this.zulrahPlugin.TabStop = false;
            this.zulrahPlugin.Click += new System.EventHandler(this.ZulrahPlugin_Click);
            this.zulrahPlugin.MouseEnter += new System.EventHandler(this.ZulrahPlugin_MouseEnter);
            this.zulrahPlugin.MouseLeave += new System.EventHandler(this.ZulrahPlugin_MouseLeave);
            // 
            // Merch
            // 
            this.Merch.BackgroundImage = global::Epacsenur.Properties.Resources.Merch;
            this.Merch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Merch.Location = new System.Drawing.Point(2764, 113);
            this.Merch.Margin = new System.Windows.Forms.Padding(6);
            this.Merch.Name = "Merch";
            this.Merch.Size = new System.Drawing.Size(40, 38);
            this.Merch.TabIndex = 2;
            this.Merch.TabStop = false;
            this.Merch.Click += new System.EventHandler(this.Merch_Click);
            this.Merch.MouseEnter += new System.EventHandler(this.Merch_MouseEnter);
            this.Merch.MouseLeave += new System.EventHandler(this.Merch_MouseLeave);
            // 
            // osrs_wiki
            // 
            this.osrs_wiki.BackgroundImage = global::Epacsenur.Properties.Resources.osrs_wiki;
            this.osrs_wiki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.osrs_wiki.Location = new System.Drawing.Point(2764, 63);
            this.osrs_wiki.Margin = new System.Windows.Forms.Padding(6);
            this.osrs_wiki.Name = "osrs_wiki";
            this.osrs_wiki.Size = new System.Drawing.Size(40, 38);
            this.osrs_wiki.TabIndex = 4;
            this.osrs_wiki.TabStop = false;
            this.osrs_wiki.Click += new System.EventHandler(this.Osrs_wiki_Click);
            this.osrs_wiki.MouseEnter += new System.EventHandler(this.Osrs_wiki_MouseEnter);
            this.osrs_wiki.MouseLeave += new System.EventHandler(this.Osrs_wiki_MouseLeave);
            // 
            // openChat
            // 
            this.openChat.BackColor = System.Drawing.Color.White;
            this.openChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openChat.Location = new System.Drawing.Point(2764, 213);
            this.openChat.Margin = new System.Windows.Forms.Padding(6);
            this.openChat.Name = "openChat";
            this.openChat.Size = new System.Drawing.Size(40, 38);
            this.openChat.TabIndex = 5;
            this.openChat.TabStop = false;
            this.openChat.Click += new System.EventHandler(this.openChat_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(7, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1136, 1021);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "IRC WORKS BUT THERE IS NO ACTIVE SERVER HOSTING IT. SO CONSIDER IT AS IT IS NOT W" +
    "ORKING. ";
            this.richTextBox1.ZoomFactor = 5F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(81)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(2812, 1100);
            this.Controls.Add(this.ircPanel);
            this.Controls.Add(this.openChat);
            this.Controls.Add(this.reddit);
            this.Controls.Add(this.zulrahPlugin);
            this.Controls.Add(this.Merch);
            this.Controls.Add(this.osrs_wiki);
            this.Controls.Add(this.Holder);
            this.Controls.Add(this.osrs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Epacsenur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Holder.ResumeLayout(false);
            this.Holder.PerformLayout();
            this.ircPanel.ResumeLayout(false);
            this.ircPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reddit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zulrahPlugin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osrs_wiki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon Minimize;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.WebBrowser osrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Contract;
        private System.Windows.Forms.Panel Holder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox osrs_wiki;
        private System.Windows.Forms.PictureBox Merch;
        private System.Windows.Forms.PictureBox zulrahPlugin;
        private System.Windows.Forms.PictureBox reddit;
        private System.Windows.Forms.PictureBox openChat;
        private System.Windows.Forms.Panel ircPanel;
        private System.Windows.Forms.Button setName;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.RichTextBox messagesList;
        private System.Windows.Forms.RichTextBox sendmessageBox;
        private System.Windows.Forms.Button sendmessageButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}