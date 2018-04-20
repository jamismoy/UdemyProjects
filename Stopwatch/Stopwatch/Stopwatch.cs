using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Stopwatch
    {
        private DateTime timeInitial;
        private DateTime timeFinal;
        private bool isRunning = false;

        public void Start()
        {
            if (isRunning)
            {
                throw new InvalidOperationException("Cannot start stopwatch twice in a row");
            }
            timeInitial = DateTime.Now;
            isRunning = true;
        }

        public TimeSpan Stop()
        {
            if (!isRunning)
            {
                throw new InvalidOperationException("Cannot stop a stopwatch that is not started");
            }
            timeFinal = DateTime.Now;
            isRunning = false;
            return timeFinal - timeInitial;
        }

        
    }
}
