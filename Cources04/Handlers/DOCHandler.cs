using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources04.Handlers
{
    class DOCHandler:AbstractHandler
    {
        public string Path { get; private set; }
        public DOCHandler(string path)
        {
            this.Path = path;
        }
        
        public override void Open()
        {
            Console.WriteLine("Changing .doc  " + this.Path);
        }
        public override void Create()
        {
            Console.WriteLine("Creating .doc " + this.Path);
        }
        public override void Edit()
        {
            Console.WriteLine("Editing .doc " + this.Path);
        }
        public override void Save()
        {
            Console.WriteLine("Saving .doc " + this.Path);
        }
    }
}
