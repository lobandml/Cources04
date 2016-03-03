using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources04.Players
{
    
        class Player : IPlayable, IRecordable
        {
            public void Play()
            {
                Console.WriteLine("File is playing");
            }
            public void Pause()
            {
                Console.WriteLine("[IPlayable+Irecodable] File is paused");
            }
            void IPlayable.Stop()
            {
                Console.WriteLine("[IPlayable] Stopped");
            }
            public void Record()
            {
                Console.WriteLine("File have recorded.");
            }
            void IRecordable.Stop()
            {
                Console.WriteLine("[IRecodable] Stopped");
            }
        
    }
}
