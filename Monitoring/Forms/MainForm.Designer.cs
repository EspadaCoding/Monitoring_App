
namespace Monitoring
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Start.Font = new System.Drawing.Font("Source Sans Pro", 13F);
            this.button_Start.Location = new System.Drawing.Point(48, 21);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(128, 38);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Включить";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Options
            // 
            this.button_Options.BackColor = System.Drawing.Color.PaleGreen;
            this.button_Options.Font = new System.Drawing.Font("Source Sans Pro", 13F);
            this.button_Options.Location = new System.Drawing.Point(194, 21);
            this.button_Options.Name = "button_Options";
            this.button_Options.Size = new System.Drawing.Size(128, 38);
            this.button_Options.TabIndex = 1;
            this.button_Options.Text = "Настройки";
            this.button_Options.UseVisualStyleBackColor = false;
            this.button_Options.Click += new System.EventHandler(this.button_Options_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(379, 70);
            this.Controls.Add(this.button_Options);
            this.Controls.Add(this.button_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Monitoring";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Options;
    }
}

