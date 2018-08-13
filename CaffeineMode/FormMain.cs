using System;
using System.Drawing;
using System.Windows.Forms;

namespace CaffeineMode {
    public partial class FormMain : Form {
        private Caffeine caffeine;

        public FormMain() {
            InitializeComponent();

            this.caffeine = new Caffeine();
            SetStatusIcons(Properties.Resources.icon_red);
        }
        private void FormMain_Shown(object sender, EventArgs e) {
            if (Properties.Settings.Default.U_EnableOnStartup) {
                ToggleCaffeine();
            }

            if (Properties.Settings.Default.U_StartMinimized) {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }
        private void FormMain_Resize(object sender, EventArgs e) {
            // Minimize to system tray
            if (this.WindowState == FormWindowState.Minimized) {
                this.Hide();
            }
        }

        private void SetStatusIcons(Icon icon) {
            this.Icon = icon;
            this.ENotifyIcon_Main.Icon = icon;
        }
        private void SetToggleText(string text) {
            this.EContextMenu_NotifyIcon_Main_ItemToggleCaffeine.Text = text;
            this.EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine.Text = text;
        }
        private void ToggleCaffeine() {
            if (!this.caffeine.CaffeineEnabled) {
                if (this.caffeine.EnableThreadState()) {
                    SetStatusIcons(Properties.Resources.icon_green);
                    SetToggleText("Disable Caffeine");
                }
            }
            else {
                if (this.caffeine.DisableThreadState()) {
                    SetStatusIcons(Properties.Resources.icon_red);
                    SetToggleText("Enable Caffeine");
                }
            }
        }

        private void ENotifyIcon_Main_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void EContextMenu_NotifyIcon_Main_ItemToggleCaffeine_Click(object sender, EventArgs e) {
            ToggleCaffeine();
        }
        private void EContextMenu_NotifyIcon_Main_ItemExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void EMenuStrip_Main_ItemFileMenu_ItemToggleCaffeine_Click(object sender, EventArgs e) {
            ToggleCaffeine();
        }
        private void EMenuStrip_Main_ItemFileMenu_ItemExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ECheckBox_Settings_EnableOnStartup_CheckedChanged(object sender, EventArgs e) {
            CheckBox check = (CheckBox)sender;

            if (check.Checked) {
                Properties.Settings.Default.U_EnableOnStartup = true;
            }
            else {
                Properties.Settings.Default.U_EnableOnStartup = false;
            }

            Properties.Settings.Default.Save();
        }
        private void ECheckBox_Settings_StartMinimized_CheckedChanged(object sender, EventArgs e) {
            CheckBox check = (CheckBox)sender;

            if (check.Checked) {
                Properties.Settings.Default.U_StartMinimized = true;
            }
            else {
                Properties.Settings.Default.U_StartMinimized = false;
            }

            Properties.Settings.Default.Save();
        }
    }
}
