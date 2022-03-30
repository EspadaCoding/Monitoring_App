using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring.Forms
{
    public partial class OptionsForm : Form
    {
        #region - Variables - 
        public string LogFilePath { get; set; } = string.Empty;
        private string Applications;
        private string Path;
        private bool Moderation;
        private bool Statistics;
        public bool Flag { get; set; } = false;
        #endregion

        public OptionsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            checkBox_Statistic.Checked = Statistics;
            if (checkBox_Statistic.Checked)
            {
                textBox_Path.Text = Path;
                textBox_Path.Enabled = true;
            }
            else 
            {
                textBox_Path.Enabled = false;
                textBox_Path.Text = string.Empty;
            }

            checkBox_Moderation.Checked = Moderation;
            if (checkBox_Moderation.Checked) 
            {
                richTextBox_Applications.Enabled = true;
                richTextBox_Applications.Text = Applications;
            }
            else 
            {
                richTextBox_Applications.Enabled = false;
                richTextBox_Applications.Text = string.Empty;
            }
            
            this.Close();
        }

        private void checkBox_Statistic_Click(object sender, EventArgs e)
        {
            if (checkBox_Statistic.Checked) label_Info.Enabled = label_Path.Enabled = textBox_Path.Enabled = true;
            else
            {
                if (textBox_Path.Text.Length > 0)
                {
                    if (File.Exists(textBox_Path.Text)) File.Delete(textBox_Path.Text);
                }
                else
                {
                    if (File.Exists("log.txt")) File.Delete("log.txt");
                }
                label_Info.Enabled = label_Path.Enabled = textBox_Path.Enabled = false; textBox_Path.Text = string.Empty;
            }
        }

        private void checkBox_Moderation_Click(object sender, EventArgs e)
        {
            if (checkBox_Moderation.Checked)
            {
                checkBox_Moderation.Checked = label_Applications.Enabled = true;
                richTextBox_Applications.Enabled = comboBox_Items.Enabled = true;
                button_Clear.Enabled = true;
            }
            else
            {
                checkBox_Moderation.Checked = label_Applications.Enabled = false;
                richTextBox_Applications.Enabled = comboBox_Items.Enabled = false;
                button_Clear.Enabled = false;
                richTextBox_Applications.Text = string.Empty;
            }
        }

        private void LoadData()
        {
            if (!File.Exists("CurrentSettings.txt"))
            {
                string info = @"false||false|";
                File.WriteAllText("CurrentSettings.txt", info);
            }
            else
            {
                string[] info = File.ReadAllText("CurrentSettings.txt").Split('|');

                if (info[0] == "False")
                {
                    checkBox_Statistic.Checked = false;
                    label_Info.Enabled = label_Path.Enabled = textBox_Path.Enabled = false;
                    LogFilePath = string.Empty;
                    if (File.Exists("log.txt")) File.Delete("log.txt");
                }
                else
                {
                    checkBox_Statistic.Checked = true;
                    label_Info.Enabled = label_Path.Enabled = textBox_Path.Enabled = true;
                    if (info[1] == string.Empty)
                    {
                        if (!File.Exists("log.txt")) using (var file = File.Create("log.txt")) { }
                        LogFilePath = "log.txt";
                    }
                    else
                    {
                        LogFilePath = textBox_Path.Text = info[1];
                        if (!File.Exists(LogFilePath)) using (var file = File.Create(LogFilePath)) { }
                    }
                }

                if (info[2] == "False")
                {
                    checkBox_Moderation.Checked = label_Applications.Enabled = false;
                    richTextBox_Applications.Enabled = comboBox_Items.Enabled = false;
                    button_Clear.Enabled = false;
                }
                else
                {
                    checkBox_Moderation.Checked = label_Applications.Enabled = true;
                    richTextBox_Applications.Enabled = comboBox_Items.Enabled = true;
                    button_Clear.Enabled = true;

                    if (info[3] != string.Empty)
                    {
                        richTextBox_Applications.Text = info[3];
                    }
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            if (richTextBox_Applications.Text.Length > 0) richTextBox_Applications.Text = string.Empty;
            else MessageBox.Show("The list of programs is empty!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void BackUp()
        {
            Statistics = checkBox_Statistic.Checked;
            Moderation = checkBox_Moderation.Checked;
            Path = textBox_Path.Text;
            Applications = richTextBox_Applications.Text;
        }
        
        public void SaveSettings()
        {
            Flag = true;

            if (textBox_Path.Text != Path)
            {
                File.Delete(Path);
            }

            if (!checkBox_Statistic.Checked)
            {
                LogFilePath = string.Empty;
            }
            else
            {
                if (textBox_Path.Text.Length > 0)
                {
                    if (File.Exists(textBox_Path.Text))
                    {
                        LogFilePath = textBox_Path.Text;
                    }
                    else
                    {
                        if (!File.Exists("log.txt")) using (var file = File.Create("log.txt")) { }
                        textBox_Path.Text = LogFilePath = "log.txt";
                    }
                }
                else
                {
                    if (!File.Exists("log.txt")) using (var file = File.Create("log.txt")) { }
                    textBox_Path.Text = LogFilePath = "log.txt";
                }
            }

            string data = $"{checkBox_Statistic.Checked}|{textBox_Path.Text}|{checkBox_Moderation.Checked}|{richTextBox_Applications.Text}";
            File.WriteAllText("CurrentSettings.txt", data);
        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            button_Cancel_Click(sender, e);
        }

        private void comboBox_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!richTextBox_Applications.Text.Contains(comboBox_Items.SelectedItem.ToString()))
            {
                richTextBox_Applications.Text += comboBox_Items.SelectedItem.ToString();
                richTextBox_Applications.Text += Environment.NewLine;
            }
            else MessageBox.Show("This application has already been added!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            try { comboBox_Items.SelectedIndex = -1; }
            catch (Exception) { }
        }
    }
}
