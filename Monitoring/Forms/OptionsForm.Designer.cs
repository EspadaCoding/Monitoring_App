
namespace Monitoring.Forms
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Accept = new System.Windows.Forms.Button();
            this.checkBox_Statistic = new System.Windows.Forms.CheckBox();
            this.checkBox_Moderation = new System.Windows.Forms.CheckBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.label_Path = new System.Windows.Forms.Label();
            this.label_Applications = new System.Windows.Forms.Label();
            this.richTextBox_Applications = new System.Windows.Forms.RichTextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.comboBox_Items = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Cancel.Font = new System.Drawing.Font("Source Sans Pro", 13F);
            this.button_Cancel.Location = new System.Drawing.Point(83, 503);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(128, 39);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Accept
            // 
            this.button_Accept.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Accept.Font = new System.Drawing.Font("Source Sans Pro", 13F);
            this.button_Accept.Location = new System.Drawing.Point(310, 503);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(128, 39);
            this.button_Accept.TabIndex = 3;
            this.button_Accept.Text = "Применить";
            this.button_Accept.UseVisualStyleBackColor = false;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // checkBox_Statistic
            // 
            this.checkBox_Statistic.AutoSize = true;
            this.checkBox_Statistic.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Statistic.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox_Statistic.ForeColor = System.Drawing.Color.LimeGreen;
            this.checkBox_Statistic.Location = new System.Drawing.Point(17, 11);
            this.checkBox_Statistic.Name = "checkBox_Statistic";
            this.checkBox_Statistic.Size = new System.Drawing.Size(136, 28);
            this.checkBox_Statistic.TabIndex = 4;
            this.checkBox_Statistic.Text = "Статистика";
            this.checkBox_Statistic.UseVisualStyleBackColor = true;
            this.checkBox_Statistic.Click += new System.EventHandler(this.checkBox_Statistic_Click);
            // 
            // checkBox_Moderation
            // 
            this.checkBox_Moderation.AutoSize = true;
            this.checkBox_Moderation.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Moderation.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox_Moderation.ForeColor = System.Drawing.Color.LimeGreen;
            this.checkBox_Moderation.Location = new System.Drawing.Point(18, 132);
            this.checkBox_Moderation.Name = "checkBox_Moderation";
            this.checkBox_Moderation.Size = new System.Drawing.Size(179, 28);
            this.checkBox_Moderation.TabIndex = 5;
            this.checkBox_Moderation.Text = "Модерирование";
            this.checkBox_Moderation.UseVisualStyleBackColor = true;
            this.checkBox_Moderation.Click += new System.EventHandler(this.checkBox_Moderation_Click);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Enabled = false;
            this.textBox_Path.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Path.Location = new System.Drawing.Point(83, 51);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(355, 28);
            this.textBox_Path.TabIndex = 6;
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Enabled = false;
            this.label_Path.Font = new System.Drawing.Font("Source Sans Pro", 14F);
            this.label_Path.Location = new System.Drawing.Point(19, 51);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(58, 24);
            this.label_Path.TabIndex = 7;
            this.label_Path.Text = "Путь :";
            // 
            // label_Applications
            // 
            this.label_Applications.AutoSize = true;
            this.label_Applications.Enabled = false;
            this.label_Applications.Font = new System.Drawing.Font("Source Sans Pro", 14F);
            this.label_Applications.Location = new System.Drawing.Point(19, 168);
            this.label_Applications.Name = "label_Applications";
            this.label_Applications.Size = new System.Drawing.Size(127, 24);
            this.label_Applications.TabIndex = 9;
            this.label_Applications.Text = "Приложения :";
            // 
            // richTextBox_Applications
            // 
            this.richTextBox_Applications.Enabled = false;
            this.richTextBox_Applications.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Applications.Location = new System.Drawing.Point(23, 195);
            this.richTextBox_Applications.Name = "richTextBox_Applications";
            this.richTextBox_Applications.ReadOnly = true;
            this.richTextBox_Applications.Size = new System.Drawing.Size(296, 243);
            this.richTextBox_Applications.TabIndex = 12;
            this.richTextBox_Applications.Text = "";
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Enabled = false;
            this.label_Info.Font = new System.Drawing.Font("Source Sans Pro", 8F);
            this.label_Info.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_Info.Location = new System.Drawing.Point(20, 82);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(443, 14);
            this.label_Info.TabIndex = 14;
            this.label_Info.Text = "Если не выбрать путь к файлу, то он будет установлен по умолчанию (в папке програ" +
    "ммы).";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Clear.Enabled = false;
            this.button_Clear.Font = new System.Drawing.Font("Source Sans Pro", 10F);
            this.button_Clear.Location = new System.Drawing.Point(234, 435);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(85, 25);
            this.button_Clear.TabIndex = 16;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // comboBox_Items
            // 
            this.comboBox_Items.Font = new System.Drawing.Font("Source Sans Pro", 14F);
            this.comboBox_Items.FormattingEnabled = true;
            this.comboBox_Items.Items.AddRange(new object[] {
            "notepad",
            "chrome",
            "Taskmgr",
            "Calculator",
            "WINWORD",
            "EXCEL",
            "mspaint"});
            this.comboBox_Items.Location = new System.Drawing.Point(320, 195);
            this.comboBox_Items.Name = "comboBox_Items";
            this.comboBox_Items.Size = new System.Drawing.Size(143, 32);
            this.comboBox_Items.TabIndex = 17;
            this.comboBox_Items.Text = "Приложения";
            this.comboBox_Items.SelectedIndexChanged += new System.EventHandler(this.comboBox_Items_SelectedIndexChanged);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(559, 562);
            this.Controls.Add(this.comboBox_Items);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.richTextBox_Applications);
            this.Controls.Add(this.label_Applications);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.checkBox_Moderation);
            this.Controls.Add(this.checkBox_Statistic);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.button_Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Accept;
        public System.Windows.Forms.CheckBox checkBox_Statistic;
        public System.Windows.Forms.CheckBox checkBox_Moderation;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.Label label_Applications;
        public System.Windows.Forms.RichTextBox richTextBox_Applications;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ComboBox comboBox_Items;
    }
}