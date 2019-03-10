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
            this.label1 = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.NotifyIcon(this.components);
            this.osrs = new System.Windows.Forms.WebBrowser();
            this.Holder = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zulrahPlugin = new System.Windows.Forms.PictureBox();
            this.Merch = new System.Windows.Forms.PictureBox();
            this.osrs_wiki = new System.Windows.Forms.PictureBox();
            this.zulrahKey = new System.Windows.Forms.PictureBox();
            this.Contract = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zulrahPlugin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osrs_wiki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zulrahKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1409, 28);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Epacsenur";
            // 
            // Minimize
            // 
            this.Minimize.Icon = ((System.Drawing.Icon)(resources.GetObject("Minimize.Icon")));
            this.Minimize.Text = "Epacsenur";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // osrs
            // 
            this.osrs.Location = new System.Drawing.Point(12, 33);
            this.osrs.MinimumSize = new System.Drawing.Size(20, 20);
            this.osrs.Name = "osrs";
            this.osrs.ScriptErrorsSuppressed = true;
            this.osrs.ScrollBarsEnabled = false;
            this.osrs.Size = new System.Drawing.Size(777, 535);
            this.osrs.TabIndex = 2;
            this.osrs.WebBrowserShortcutsEnabled = false;
            // 
            // Holder
            // 
            this.Holder.Controls.Add(this.zulrahKey);
            this.Holder.Controls.Add(this.label3);
            this.Holder.Controls.Add(this.label2);
            this.Holder.Location = new System.Drawing.Point(805, 33);
            this.Holder.Name = "Holder";
            this.Holder.Size = new System.Drawing.Size(573, 535);
            this.Holder.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "This is a simple resource filled client made by Sphere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "About";
            // 
            // zulrahPlugin
            // 
            this.zulrahPlugin.BackgroundImage = global::Epacsenur.Properties.Resources.Serpentine_helm;
            this.zulrahPlugin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zulrahPlugin.Location = new System.Drawing.Point(1382, 85);
            this.zulrahPlugin.Name = "zulrahPlugin";
            this.zulrahPlugin.Size = new System.Drawing.Size(20, 20);
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
            this.Merch.Location = new System.Drawing.Point(1382, 59);
            this.Merch.Name = "Merch";
            this.Merch.Size = new System.Drawing.Size(20, 20);
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
            this.osrs_wiki.Location = new System.Drawing.Point(1382, 33);
            this.osrs_wiki.Name = "osrs_wiki";
            this.osrs_wiki.Size = new System.Drawing.Size(20, 20);
            this.osrs_wiki.TabIndex = 4;
            this.osrs_wiki.TabStop = false;
            this.osrs_wiki.Click += new System.EventHandler(this.Osrs_wiki_Click);
            this.osrs_wiki.MouseEnter += new System.EventHandler(this.Osrs_wiki_MouseEnter);
            this.osrs_wiki.MouseLeave += new System.EventHandler(this.Osrs_wiki_MouseLeave);
            // 
            // zulrahKey
            // 
            this.zulrahKey.BackColor = System.Drawing.Color.Transparent;
            this.zulrahKey.BackgroundImage = global::Epacsenur.Properties.Resources.Zulrah_Key;
            this.zulrahKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zulrahKey.Location = new System.Drawing.Point(144, 0);
            this.zulrahKey.Name = "zulrahKey";
            this.zulrahKey.Size = new System.Drawing.Size(286, 98);
            this.zulrahKey.TabIndex = 2;
            this.zulrahKey.TabStop = false;
            this.zulrahKey.Visible = false;
            // 
            // Contract
            // 
            this.Contract.BackgroundImage = global::Epacsenur.Properties.Resources.Left;
            this.Contract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Contract.Location = new System.Drawing.Point(1335, 3);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(16, 22);
            this.Contract.TabIndex = 3;
            this.Contract.TabStop = false;
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Epacsenur.Properties.Resources.Logo_png;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 27);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Epacsenur.Properties.Resources.dash;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1357, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Epacsenur.Properties.Resources.x;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1383, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(81)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1405, 577);
            this.Controls.Add(this.zulrahPlugin);
            this.Controls.Add(this.Merch);
            this.Controls.Add(this.osrs_wiki);
            this.Controls.Add(this.Holder);
            this.Controls.Add(this.osrs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Epacsenur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Holder.ResumeLayout(false);
            this.Holder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zulrahPlugin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osrs_wiki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zulrahKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox zulrahKey;
    }
}

