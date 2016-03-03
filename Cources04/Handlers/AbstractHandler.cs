using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources04.Handlers
{
   public abstract class AbstractHandler
    {
        
        public abstract void Open();
        public abstract void Create();
        public abstract void Edit();
        public abstract void Save();
    }
}
