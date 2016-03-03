using Cources04.Players;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Cources04
{
    public  static class Tasks
    {
         enum TextFormats
        {
            TXT,
            DOC,
            XML
        };

        public static Handlers.AbstractHandler ParseHandlers(string path)
        {
            string ext = Path.GetExtension(path);
            Handlers.AbstractHandler handler;
            switch (ext.ToLower())
            {
                case ".doc":
                    handler = new Handlers.DOCHandler(path);
                    break;
                case ".txt":
                    handler = new Handlers.TXTHandler(path);
                    break;
                case ".xml":
                    handler = new Handlers.XMLHandler(path);
                    break;
                default:
                    throw new Exception("Неверный ввод");
            }
            return handler;
        }
        public static void Task1()
        {
            Console.WriteLine("Введите название файла либо путь к нему");
            string path = Console.ReadLine();
            try
            {
                Handlers.AbstractHandler handler = ParseHandlers(path);

                handler.Create();
                handler.Open();
                handler.Edit();
                handler.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static void Task2()
        {
            Player testplayer = new Player();
            testplayer.Play();
            testplayer.Pause();
            testplayer.Record();


            (testplayer as IPlayable).Stop();

            (testplayer as IRecordable).Stop();

            Console.ReadLine();
        }
        
    }
}
