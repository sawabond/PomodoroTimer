using System;
using System.Media;
using System.Timers;
using System.Drawing;
using System.Diagnostics;
using System.Timers;
//using System.IO;
using System.Windows.Forms;
//using Newtonsoft.Json;

namespace PomodoroTimerWF
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer t;
        private const int _minutes = 25;
        private const int _seconds = 0;
        private const int _minutesToRest = 5;
        private const int _minutesForBigRest = 20;

        private static Image _unmuted = Image.FromFile("Unmuted.png");
        private static Image _muted = Image.FromFile("Muted.png");
        public static string StatFilename { get; } = "statistics.txt";

        private readonly string _notificationFileName = Environment.CurrentDirectory + "\\Notification.wav";

        private static int _curCicles = 0;
        private bool _isMuted = false;
        private TimeNotification form2 = new TimeNotification();
        public static StatisticsWindow form3 { get; set; } = new StatisticsWindow();
        private int currentCicles = _curCicles;

        private static int m = _minutes, s = _seconds;
        private static bool _isWorkOn = true;
        private static bool _isOpenedToday = DateOfOpening.IsOpenedToday();
        public static Statistics statistics { get; set; } = new Statistics();

        public Form1()
        {
            statistics.StartSessionTimer();
            InitializeComponent();
            notifyIcon1.Visible = true;
            ShowInTaskbar = false;
            pictureBox1.BringToFront();
        }

        private void PlayMusic()
        {
            using(var sound = new SoundPlayer(_notificationFileName))
            sound.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            mainTimerLabel.Text = string.Format("{0}:{1}", _minutes.ToString().PadLeft(2, '0'), _seconds.ToString().PadLeft(2, '0'));
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void SetTimerLabelText(Label label, int mins, int secs)
        {
            label.Text = string.Format("{0}:{1}", mins.ToString().PadLeft(2, '0'), secs.ToString().PadLeft(2, '0'));
        }

        private bool isBigRest(int currentCicles)
        {
            return currentCicles % 4 == 0 && currentCicles != 0;
        }
        private void WorkFinished()
        {
            currentCicles += 1;
            _isWorkOn = false;
            form2.Hide();
            t.Stop();
            statistics.StopFocusTimer();
            bStart.Text = "Start";
            int timeToRest;
            if (isBigRest(currentCicles))
            {
                timeToRest = _minutesForBigRest;
                m = _minutesForBigRest;
                s = _seconds;
            }
            else
            {
                timeToRest = _minutesToRest;
                m = _minutesToRest;
                s = _seconds;
            }
            SetTimerLabelText(mainTimerLabel, timeToRest, _seconds);
            if (!_isMuted) 
                PlayMusic();
        }
        private static string[] GetStatisticsLines()
        {
            string timespanToString(TimeSpan ts)
            {
                string result = String.Format("{0}:{1}:{2}",
                    ts.Hours.ToString().PadLeft(2, '0'),
                    ts.Minutes.ToString().PadLeft(2, '0'),
                    ts.Seconds.ToString().PadLeft(2, '0'));
                return result;
            }
            int fields = 2;
            var tsSession = statistics.CurrentSession;
            var tsFocus = statistics.CurrentTimeInFocus;

            string curTime = timespanToString(tsSession);
            string curTimeInFocus = timespanToString(tsFocus);
            string[] statString = new string[fields];
            statString[0] = $"Current time:\t {curTime}\n";
            statString[1] = $"Time in focus:\t {curTimeInFocus}\n";

            return statString;
        }
        public static void SetStatistics(StatisticsWindow f3)
        {
            string[] statLines = GetStatisticsLines();
            f3.SetStatisticsText(statLines);
        }
        private void ShowStatistics()
        {
            form3.SetParent(this);
            form3.SetPosition(Top, Left);
            SetStatistics(form3);
            form3.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (form3.Visible)
            {
                form3.Visible = false;
            }
            else
            {
                ShowStatistics();
                Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_isMuted)
            {
                pictureBox1.Image = _unmuted;
                _isMuted = false;
            }
            else
            {
                pictureBox1.Image = _muted;
                _isMuted = true;
            }
        }

        private void RestFinished()
        {
            _isWorkOn = true;
            form2.Hide();
            t.Stop();
            bStart.Text = "Start";
            SetTimerLabelText(mainTimerLabel, _minutes, _seconds);
            m = _minutes;
            s = _seconds;
            if(!_isMuted)
                PlayMusic();
        }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                StatisticsIO.WriteStatistics();
                s--;
                if (s < 0)
                {
                    s = 59;
                    m--;
                }
                SetTimerLabelText(mainTimerLabel, m, s);
                if (m % 5 == 0 && m != _minutes && s <= 3 && s >= 0)
                {
                    form2.TopMost = true;
                    form2.SetStringOnLabel(mainTimerLabel.Text);
                    form2.Show();
                }
                else
                {
                    form2.Hide();
                }
                if (m == 0 && s == 0)
                {
                    if (_isWorkOn)
                    {
                        WorkFinished();
                    }
                    else
                    {
                        RestFinished();
                    }
                }
            }));
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            // TODO: сделать открытие с первого раза
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else
            {
                WindowState = FormWindowState.Normal;
                Focus();
            }  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            form3.Hide();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            bCloseApp.BackColor = Color.Transparent;
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            bCloseApp.BackColor = Color.FromArgb(255, 255, 174, 188);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            bMinimize.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            bMinimize.BackColor = Color.FromArgb(255, 255, 174, 188);
        }

        public static Point movingWindow { get; set; }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            movingWindow = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - movingWindow.X;
                Top += e.Y - movingWindow.Y;
            }
            form3.SetPosition(Top, Left);
        }

        private void Timer1_MouseDown(object sender, MouseEventArgs e)
        {
            movingWindow = new Point(e.X, e.Y);
        }

        private void Timer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - movingWindow.X;
                Top += e.Y - movingWindow.Y;
            }
            form3.SetPosition(Top, Left);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t.Enabled)
            {
                bStart.Text = "Start";
                t.Stop();
                statistics.StopFocusTimer();
            }
            else
            {
                bStart.Text = "Pause";
                t.Start();
                if(_isWorkOn)
                    statistics.StartFocusTimer();
            }
        }

        private void Timer1_MouseDown_1(object sender, MouseEventArgs e)
        {
            movingWindow = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Timer1_MouseDown_2(object sender, MouseEventArgs e)
        {
            movingWindow = new Point(e.X, e.Y);
        }

        private void Timer1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - movingWindow.X;
                Top += e.Y - movingWindow.Y;
            }
            form3.SetPosition(Top, Left);
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - movingWindow.X;
                Top += e.Y - movingWindow.Y;
            }
            form3.SetPosition(Top, Left);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            movingWindow = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m = _minutes;
            s = _seconds;
            _isWorkOn = true;
            t.Stop();
            statistics.StopFocusTimer();
            SetTimerLabelText(mainTimerLabel, m, s);
            bStart.Text = "Start";
        }
    }
}