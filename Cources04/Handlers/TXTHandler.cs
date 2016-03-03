using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources04.Handlers
{
    class TXTHandler:AbstractHandler
    {
         public string Path { get; private set; }
        public TXTHandler(string path)
        {
            this.Path = path;
        }
        
        public override void Open()
        {
            Console.WriteLine("Changing .txt  " + this.Path);
        }
        public override void Create()
        {
            Console.WriteLine("Creating .txt " + this.Path);
        }
        public override void Edit()
        {
            Console.WriteLine("Editing .txt " + this.Path);
        }
        public override void Save()
        {
            Console.WriteLine("Saving .txt " + this.Path);
        }
    }
}
