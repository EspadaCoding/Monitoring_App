using Monitoring.Forms;
using Monitoring.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring
{
    public partial class MainForm : Form
    {
        #region - Variables -
        private OptionsForm options; 
        private bool IsStarted { get; set; } = false;

        public bool IsStatistic { get; set; } = false;
        public bool IsModeration { get; set; } = false;
        public string LogPath { get; set; } = string.Empty;
        public List<string> Apps { get; set; }
        public MyKeyboardHook hook { get; set; }
        public DateTime LastCheckTime { get; set; } = DateTime.Now;


        public System.Windows.Forms.Timer timer;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            Apps = new List<string>();
            options = new OptionsForm();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += Timer_Tick;
            LoadData();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (IsStatistic)
                {
                    if (LogPath != string.Empty)
                    {
                        Process[] runningProcesses = Process.GetProcesses();

                        foreach (Process process in runningProcesses)
                        {
                            try
                            {
                                if (process.StartTime > LastCheckTime)
                                {
                                    string tmp = DateTime.Now.ToString() + " - App: " + process.ProcessName + " opened" + Environment.NewLine;
                                    File.AppendAllText(LogPath, tmp);
                                }
                            }
                            catch (Exception) { }
                        }
                        LastCheckTime = DateTime.Now;
                    }
                }
            });

            Task.Run(() =>
            {
                if (IsModeration)
                {
                    if (Apps.Count > 0)
                    {
                        Process[] runningProcesses = Process.GetProcesses();
                        foreach (Process process in runningProcesses)
                        {
                            foreach (var App in Apps)
                            {
                                if (process.ProcessName.Equals(App))
                                {
                                    string processName = string.Empty;
                                    try
                                    {
                                        processName = process.ProcessName;
                                        if (IsStatistic)
                                        {
                                            string tmp = DateTime.Now.ToString() + " - Forbidden App: " + processName + " try opened" + Environment.NewLine;
                                            File.AppendAllText(LogPath, tmp);
                                        }
                                        process.Kill();
                                    }
                                    catch (Exception) { }

                                    if (IsStatistic)
                                    {
                                        string tmp = DateTime.Now.ToString() + " - Forbidden App: " + processName + " closed" + Environment.NewLine;
                                        File.AppendAllText(LogPath, tmp);
                                    }
                                }
                            }
                        }
                    }
                }
            });
        }

        private void button_Options_Click(object sender, EventArgs e)
        {
            this.Hide();
            options.BackUp();
            options.ShowDialog();
            this.Show();
            if (options.Flag) LoadData();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            IsStarted = !IsStarted;

            if (IsStarted)
            {
                button_Start.Text = "Выключить";
                button_Options.Enabled = false;
                hook = new MyKeyboardHook();
                hook.Install();
                timer.Interval = 100;
                timer.Start();

                Task.Run(() =>
                {
                    if (IsStatistic)
                    {
                        if (LogPath != string.Empty)
                        {
                            hook.KeyDown += Hook_KeyDown;
                        }
                    }
                });
            }
            else
            {
                button_Start.Text = "Включить";
                button_Options.Enabled = true;
                hook.Uninstall();
                timer.Stop();
            }
        }

        private void Hook_KeyDown(object sender, KeyEventArgs e)
        {
            string tmp = DateTime.Now.ToString() + " - Key: " + e.KeyCode + Environment.NewLine;
            File.AppendAllText(LogPath, tmp);
        }

        private void LoadData()
        {
            Apps.Clear();
            IsStatistic = options.checkBox_Statistic.Checked;
            LogPath = options.LogFilePath;
            IsModeration = options.checkBox_Moderation.Checked;
            var tmp = options.richTextBox_Applications.Text.Split('\n');
            foreach (var item in tmp)
            {
                if (item != "")
                {
                    Apps.Add(item);
                }
            }
            options.Flag = false;
        }


    }
}
