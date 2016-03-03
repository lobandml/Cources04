using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources04.Players
{
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
