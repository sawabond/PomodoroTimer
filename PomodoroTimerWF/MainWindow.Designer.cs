using System;
using System.Windows.Forms;

namespace PomodoroTimerWF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTimerLabel = new System.Windows.Forms.Label();
            this.bStatistics = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bMinimize = new System.Windows.Forms.PictureBox();
            this.bCloseApp = new System.Windows.Forms.PictureBox();
            this.bStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTimerLabel
            // 
            this.mainTimerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(72)))));
            this.mainTimerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTimerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTimerLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTimerLabel.ForeColor = System.Drawing.Color.White;
            this.mainTimerLabel.Location = new System.Drawing.Point(12, 31);
            this.mainTimerLabel.Name = "mainTimerLabel";
            this.mainTimerLabel.Size = new System.Drawing.Size(328, 104);
            this.mainTimerLabel.TabIndex = 0;
            this.mainTimerLabel.Text = "25:00";
            this.mainTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainTimerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timer1_MouseDown_2);
            this.mainTimerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Timer1_MouseMove_1);
            // 
            // bStatistics
            // 
            this.bStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(26)))), ((int)(((byte)(60)))));
            this.bStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bStatistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.bStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStatistics.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStatistics.ForeColor = System.Drawing.Color.White;
            this.bStatistics.Location = new System.Drawing.Point(12, 245);
            this.bStatistics.Name = "bStatistics";
            this.bStatistics.Size = new System.Drawing.Size(328, 45);
            this.bStatistics.TabIndex = 0;
            this.bStatistics.Text = "Statistics";
            this.bStatistics.UseVisualStyleBackColor = false;
            this.bStatistics.Click += new System.EventHandler(this.button1_Click);
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(26)))), ((int)(((byte)(60)))));
            this.bStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.ForeColor = System.Drawing.Color.White;
            this.bStop.Location = new System.Drawing.Point(12, 200);
            this.bStop.Margin = new System.Windows.Forms.Padding(0);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(328, 45);
            this.bStop.TabIndex = 0;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(0, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(31)))), ((int)(((byte)(72)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Нажмите на иконку, чтобы открыть таймер";
            this.notifyIcon1.BalloonTipTitle = "Подсказка";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Показать таймер";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(26)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.bMinimize);
            this.panel2.Controls.Add(this.bCloseApp);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 31);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // bMinimize
            // 
            this.bMinimize.BackColor = System.Drawing.Color.Transparent;
            this.bMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bMinimize.BackgroundImage")));
            this.bMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.bMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bMinimize.Location = new System.Drawing.Point(290, 0);
            this.bMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(31, 31);
            this.bMinimize.TabIndex = 1;
            this.bMinimize.TabStop = false;
            this.bMinimize.Click += new System.EventHandler(this.pictureBox3_Click);
            this.bMinimize.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.bMinimize.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // bCloseApp
            // 
            this.bCloseApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCloseApp.BackgroundImage")));
            this.bCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bCloseApp.Cursor = System.Windows.Forms.Cursors.Default;
            this.bCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.bCloseApp.Location = new System.Drawing.Point(321, 0);
            this.bCloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.bCloseApp.Name = "bCloseApp";
            this.bCloseApp.Size = new System.Drawing.Size(31, 31);
            this.bCloseApp.TabIndex = 0;
            this.bCloseApp.TabStop = false;
            this.bCloseApp.Click += new System.EventHandler(this.pictureBox2_Click);
            this.bCloseApp.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.bCloseApp.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(26)))), ((int)(((byte)(60)))));
            this.bStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.ForeColor = System.Drawing.Color.White;
            this.bStart.Location = new System.Drawing.Point(12, 155);
            this.bStart.Margin = new System.Windows.Forms.Padding(0);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(328, 45);
            this.bStart.TabIndex = 10;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(26)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(352, 310);
            this.Controls.Add(this.mainTimerLabel);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCloseApp)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label mainTimerLabel;
        private System.Windows.Forms.Button bStatistics;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox bMinimize;
        private System.Windows.Forms.PictureBox bCloseApp;
        private System.Windows.Forms.Button bStart;
    }
}

