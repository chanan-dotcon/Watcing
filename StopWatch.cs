using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject.Classes.Exercises
{
    public class StopWatch
    {
        private TimeSpan _total;
        private DateTime _startWatch;
        private DateTime _endWatch;

        public void Strat()
        {
            if (_startWatch.Millisecond == 0)
                _startWatch = DateTime.Now;
            else
                Console.WriteLine(new InvalidOperationException("Cannot be starting twice"));
        }

        public void Stop()
        {
            _endWatch = DateTime.Now;
        }

        public void DurationWatch()
        {
            _total = (_endWatch - _startWatch);
            Console.WriteLine($"The total the time watching: " +
                $"Hours: {_total.Hours}, Minutes: {_total.Minutes}," +
                $" MilliSeconds: {_total.Milliseconds}");
            //For reset 'DateTime'
            _startWatch = new DateTime();
        }

        //Program
        //var stop = new StopWatch();
        //stop.Strat();
        //stop.Strat();
        //stop.Stop();
        //stop.DurationWatch();
        //stop.Strat();
        //stop.Stop();
        //stop.DurationWatch();
    }
}
