using System;
using System.Diagnostics;
using System.Threading;

namespace Stop_Watch
{
    public class CustomStopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;

        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException($"Stop watch is already running");
            }
            else
            {
                
                _startTime = DateTime.Now;
                _isRunning = true;
            }
                                              
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException($"Stop watch isn't running");
            }
            else
            {
                _stopTime = DateTime.Now;
                _isRunning = false;               
            }
        }

        public TimeSpan DurationTime()
        {
            return _stopTime - _startTime;
        }

    }
}
