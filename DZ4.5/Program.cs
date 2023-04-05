using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string DocumentType = Console.ReadLine();
            AbstractHandler docHandler = null;
            switch (DocumentType)
            {
                case "XMLHandler":
                    docHandler = new XMLHandler();
                    break;
                case "DOCHandler":
                    docHandler = new TXTHandler();
                    break;
                case "TXTHandler":
                    docHandler = new DOCHandler();
                    break;
                default:
                    Console.WriteLine("Invalid document type");
                    break;
            }
            if (docHandler != null)
            {
                docHandler.Open();
                docHandler.Create();
                docHandler.Change();
                docHandler.Save();
            }
            Console.ReadKey();
        }
    }
    abstract class AbstractHandler
    {
        public virtual void Open() => Console.WriteLine("DocumentPart.Open");
        public virtual void Create() => Console.WriteLine("DocumentPart.Create");
        public virtual void Change() => Console.WriteLine("DocumentPart.Change");
        public virtual void Save() => Console.WriteLine("DocumentPart.Save");
    }
    class XMLHandler : AbstractHandler
    {
        public override void Open() => Console.WriteLine("XMLHandler.Open");
        public override void Create() => Console.WriteLine("XMLHandler.Create");
        public override void Change() => Console.WriteLine("XMLHandler.Change");
        public override void Save() => Console.WriteLine("XMLHandler.Save");
    }
    class TXTHandler : AbstractHandler
    {
        public override void Open() => Console.WriteLine("TXTHandler.Open");
        public override void Create() => Console.WriteLine("TXTHandler.Create");
        public override void Change() => Console.WriteLine("TXTHandler.Change");
        public override void Save() => Console.WriteLine("TXTHandler.Save");

    }
    class DOCHandler : AbstractHandler
    {
        public override void Open() => Console.WriteLine("DOCHandler.Open");
        public override void Create() => Console.WriteLine("DOCHandler.Create");
        public override void Change() => Console.WriteLine("DOCHandler.Change");
        public override void Save() => Console.WriteLine("DOCHandler.Save");
    }
}
