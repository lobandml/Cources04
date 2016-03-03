using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources04.Players
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
}
