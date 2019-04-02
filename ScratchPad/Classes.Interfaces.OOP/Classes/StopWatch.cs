using System;

namespace Classes.Interfaces.OOP.Classes
{
    public class StopWatch
    {
        private DateTime _startTime;
        private int _accumulatedTime;
        private bool _isRunning = false;

        public TimeSpan Duration { get; private set; }

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stop watch already running");

            if (Duration.Seconds == 0)
            {
                _startTime = DateTime.Now;
            }
            else
            {
                _accumulatedTime += Duration.Seconds;
                _startTime = _startTime.AddSeconds(_accumulatedTime);
            }

            _isRunning = true;
        }
        public void Stop()
        {
            Duration = DateTime.Now - _startTime;
            _isRunning = false;
        }
    }
}
