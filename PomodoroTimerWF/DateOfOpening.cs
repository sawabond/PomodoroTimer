using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace PomodoroTimerWF
{
    public static class DateOfOpening
    {
        private static DateTime _dateOfOpening;
        private static DateTime _dateOfLastOpening;
        private static readonly string _pathToJson = "date.txt";
        private static string pathToJson { get; set; }

        static DateOfOpening()
        {
            _dateOfOpening = DateTime.Now;
            ReadLastDate();
            WriteCurrentDate();
        }

        private static void ReadLastDate()
        {
            using (StreamReader sr = new StreamReader(_pathToJson))
                _dateOfLastOpening = Convert.ToDateTime(sr.ReadToEnd());
        }
        private static void WriteCurrentDate()
        {
            using (StreamWriter sw = new StreamWriter(_pathToJson))
                sw.Write(Convert.ToString(_dateOfOpening));
        }
        public static bool IsOpenedToday()
        {
            return _dateOfOpening.Date.Equals(_dateOfLastOpening.Date);
        }
    }
}
