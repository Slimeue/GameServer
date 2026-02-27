using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class GameLogic
    {
        bool _isRunning = true;
        const int tickRate = 30;
        const int delayMs = 1000 / tickRate;

        public async Task GameLoopAsync()
        {
            while (_isRunning)
            {
                var start = DateTime.UtcNow;

                Threading.Update();

                var elapsed = (int)(DateTime.UtcNow - start).TotalMilliseconds;
                int sleepTime = Math.Max(0, delayMs - elapsed);
                await Task.Delay(sleepTime);
            }

        }

    }
}
