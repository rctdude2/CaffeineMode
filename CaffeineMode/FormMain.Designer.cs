namespace CaffeineMode {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ENotifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.EContextMenu_NotifyIcon_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EContextMenu_NotifyIcon_Main_ItemToggleCaffeine = new System.Windows.Forms.ToolStripMenuItem();
            this.EContextMenu_NotifyIcon_Main_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EContextMenu_NotifyIcon_Main_ItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.EMenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.EMenuStrip_Main_ItemFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine = new System.Windows.Forms.ToolStripMenuItem();
            this.EMenuStrip_Main_ItemFileMenu_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EMenuStrip_Main_ItemFileMenu_ItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.EGroupBox_Settings = new System.Windows.Forms.GroupBox();
            this.ECheckBox_Settings_StartMinimized = new System.Windows.Forms.CheckBox();
            this.ECheckBox_Settings_EnableOnStartup = new System.Windows.Forms.CheckBox();
            this.EContextMenu_NotifyIcon_Main.SuspendLayout();
            this.EMenuStrip_Main.SuspendLayout();
            this.EGroupBox_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ENotifyIcon_Main
            // 
            this.ENotifyIcon_Main.ContextMenuStrip = this.EContextMenu_NotifyIcon_Main;
            this.ENotifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("ENotifyIcon_Main.Icon")));
            this.ENotifyIcon_Main.Text = "Caffeine Mode";
            this.ENotifyIcon_Main.Visible = true;
            this.ENotifyIcon_Main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ENotifyIcon_Main_MouseDoubleClick);
            // 
            // EContextMenu_NotifyIcon_Main
            // 
            this.EContextMenu_NotifyIcon_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EContextMenu_NotifyIcon_Main_ItemToggleCaffeine,
            this.EContextMenu_NotifyIcon_Main_Separator1,
            this.EContextMenu_NotifyIcon_Main_ItemExit});
            this.EContextMenu_NotifyIcon_Main.Name = "EContextMenu_NotifyIcon_Main";
            this.EContextMenu_NotifyIcon_Main.Size = new System.Drawing.Size(174, 54);
            // 
            // EContextMenu_NotifyIcon_Main_ItemToggleCaffeine
            // 
            this.EContextMenu_NotifyIcon_Main_ItemToggleCaffeine.Name = "EContextMenu_NotifyIcon_Main_ItemToggleCaffeine";
            this.EContextMenu_NotifyIcon_Main_ItemToggleCaffeine.ShortcutKeyDisplayString = "";
            this.EContextMenu_NotifyIcon_Main_ItemToggleCaffeine.Size = new System.Drawing.Size(173, 22);
            this.EContextMenu_NotifyIcon_Main_ItemToggleCaffeine.Text = "Enable Caffeine";
            this.EContextMenu_NotifyIcon_Main_ItemToggleCaffeine.Click += new System.EventHandler(this.EContextMenu_NotifyIcon_Main_ItemToggleCaffeine_Click);
            // 
            // EContextMenu_NotifyIcon_Main_Separator1
            // 
            this.EContextMenu_NotifyIcon_Main_Separator1.Name = "EContextMenu_NotifyIcon_Main_Separator1";
            this.EContextMenu_NotifyIcon_Main_Separator1.Size = new System.Drawing.Size(170, 6);
            // 
            // EContextMenu_NotifyIcon_Main_ItemExit
            // 
            this.EContextMenu_NotifyIcon_Main_ItemExit.Name = "EContextMenu_NotifyIcon_Main_ItemExit";
            this.EContextMenu_NotifyIcon_Main_ItemExit.Size = new System.Drawing.Size(173, 22);
            this.EContextMenu_NotifyIcon_Main_ItemExit.Text = "Exit Caffeine Mode";
            this.EContextMenu_NotifyIcon_Main_ItemExit.Click += new System.EventHandler(this.EContextMenu_NotifyIcon_Main_ItemExit_Click);
            // 
            // EMenuStrip_Main
            // 
            this.EMenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EMenuStrip_Main_ItemFileMenu});
            this.EMenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.EMenuStrip_Main.Name = "EMenuStrip_Main";
            this.EMenuStrip_Main.Size = new System.Drawing.Size(284, 24);
            this.EMenuStrip_Main.TabIndex = 1;
            this.EMenuStrip_Main.Text = "EMenuStrip_Main";
            // 
            // EMenuStrip_Main_ItemFileMenu
            // 
            this.EMenuStrip_Main_ItemFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine,
            this.EMenuStrip_Main_ItemFileMenu_Separator1,
            this.EMenuStrip_Main_ItemFileMenu_ItemExit});
            this.EMenuStrip_Main_ItemFileMenu.Name = "EMenuStrip_Main_ItemFileMenu";
            this.EMenuStrip_Main_ItemFileMenu.Size = new System.Drawing.Size(37, 20);
            this.EMenuStrip_Main_ItemFileMenu.Text = "File";
            // 
            // EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine
            // 
            this.EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine.Name = "EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine";
            this.EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine.Size = new System.Drawing.Size(156, 22);
            this.EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine.Text = "Enable Caffeine";
            this.EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine.Click += new System.EventHandler(this.EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine_Click);
            // 
            // EMenuStrip_Main_ItemFileMenu_Separator1
            // 
            this.EMenuStrip_Main_ItemFileMenu_Separator1.Name = "EMenuStrip_Main_ItemFileMenu_Separator1";
            this.EMenuStrip_Main_ItemFileMenu_Separator1.Size = new System.Drawing.Size(153, 6);
            // 
            // EMenuStrip_Main_ItemFileMenu_ItemExit
            // 
            this.EMenuStrip_Main_ItemFileMenu_ItemExit.Name = "EMenuStrip_Main_ItemFileMenu_ItemExit";
            this.EMenuStrip_Main_ItemFileMenu_ItemExit.Size = new System.Drawing.Size(156, 22);
            this.EMenuStrip_Main_ItemFileMenu_ItemExit.Text = "Exit";
            this.EMenuStrip_Main_ItemFileMenu_ItemExit.Click += new System.EventHandler(this.EMenuStrip_Main_ItemFileMenu_ItemExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enabling Caffeine Mode prevents your monitor from\r\nautomatically shutting off and" +
    " your computer from\r\nlocking, as if you were watching a video.\r\nYou can still ma" +
    "nually lock your computer.";
            // 
            // EGroupBox_Settings
            // 
            this.EGroupBox_Settings.Controls.Add(this.ECheckBox_Settings_StartMinimized);
            this.EGroupBox_Settings.Controls.Add(this.ECheckBox_Settings_EnableOnStartup);
            this.EGroupBox_Settings.Location = new System.Drawing.Point(12, 88);
            this.EGroupBox_Settings.Name = "EGroupBox_Settings";
            this.EGroupBox_Settings.Size = new System.Drawing.Size(260, 161);
            this.EGroupBox_Settings.TabIndex = 3;
            this.EGroupBox_Settings.TabStop = false;
            this.EGroupBox_Settings.Text = "Settings";
            // 
            // ECheckBox_Settings_StartMinimized
            // 
            this.ECheckBox_Settings_StartMinimized.AutoSize = true;
            this.ECheckBox_Settings_StartMinimized.Checked = global::CaffeineMode.Properties.Settings.Default.U_StartMinimized;
            this.ECheckBox_Settings_StartMinimized.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CaffeineMode.Properties.Settings.Default, "U_StartMinimized", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ECheckBox_Settings_StartMinimized.Location = new System.Drawing.Point(6, 42);
            this.ECheckBox_Settings_StartMinimized.Name = "ECheckBox_Settings_StartMinimized";
            this.ECheckBox_Settings_StartMinimized.Size = new System.Drawing.Size(96, 17);
            this.ECheckBox_Settings_StartMinimized.TabIndex = 1;
            this.ECheckBox_Settings_StartMinimized.Text = "Start minimized";
            this.ECheckBox_Settings_StartMinimized.UseVisualStyleBackColor = true;
            this.ECheckBox_Settings_StartMinimized.CheckedChanged += new System.EventHandler(this.ECheckBox_Settings_StartMinimized_CheckedChanged);
            // 
            // ECheckBox_Settings_EnableOnStartup
            // 
            this.ECheckBox_Settings_EnableOnStartup.AutoSize = true;
            this.ECheckBox_Settings_EnableOnStartup.Checked = global::CaffeineMode.Properties.Settings.Default.U_EnableOnStartup;
            this.ECheckBox_Settings_EnableOnStartup.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CaffeineMode.Properties.Settings.Default, "U_EnableOnStartup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ECheckBox_Settings_EnableOnStartup.Location = new System.Drawing.Point(6, 19);
            this.ECheckBox_Settings_EnableOnStartup.Name = "ECheckBox_Settings_EnableOnStartup";
            this.ECheckBox_Settings_EnableOnStartup.Size = new System.Drawing.Size(212, 17);
            this.ECheckBox_Settings_EnableOnStartup.TabIndex = 0;
            this.ECheckBox_Settings_EnableOnStartup.Text = "Automatically enable Caffeine at launch";
            this.ECheckBox_Settings_EnableOnStartup.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EGroupBox_Settings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EMenuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.EMenuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Caffeine Mode";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.EContextMenu_NotifyIcon_Main.ResumeLayout(false);
            this.EMenuStrip_Main.ResumeLayout(false);
            this.EMenuStrip_Main.PerformLayout();
            this.EGroupBox_Settings.ResumeLayout(false);
            this.EGroupBox_Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ENotifyIcon_Main;
        private System.Windows.Forms.ContextMenuStrip EContextMenu_NotifyIcon_Main;
        private System.Windows.Forms.ToolStripMenuItem EContextMenu_NotifyIcon_Main_ItemToggleCaffeine;
        private System.Windows.Forms.ToolStripSeparator EContextMenu_NotifyIcon_Main_Separator1;
        private System.Windows.Forms.ToolStripMenuItem EContextMenu_NotifyIcon_Main_ItemExit;
        private System.Windows.Forms.MenuStrip EMenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem EMenuStrip_Main_ItemFileMenu;
        private System.Windows.Forms.ToolStripMenuItem EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine;
        private System.Windows.Forms.ToolStripSeparator EMenuStrip_Main_ItemFileMenu_Separator1;
        private System.Windows.Forms.ToolStripMenuItem EMenuStrip_Main_ItemFileMenu_ItemExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox EGroupBox_Settings;
        private System.Windows.Forms.CheckBox ECheckBox_Settings_EnableOnStartup;
        private System.Windows.Forms.CheckBox ECheckBox_Settings_StartMinimized;
    }
}

