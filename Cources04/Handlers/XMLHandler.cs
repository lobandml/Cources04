using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources04.Handlers
{
    class XMLHandler:AbstractHandler
    {
        public string Path { get; private set; }
        public XMLHandler(string path)
        {
            this.Path = path;
        }
        
        public override void Open()
        {
            Console.WriteLine("Changing .xml  " + this.Path);
        }
        public override void Create()
        {
            Console.WriteLine("Creating .xml " + this.Path);
        }
        public override void Edit()
        {
            Console.WriteLine("Editing .xml " + this.Path);
        }
        public override void Save()
        {
            Console.WriteLine("Saving .xml " + this.Path);
        }
    }
}
