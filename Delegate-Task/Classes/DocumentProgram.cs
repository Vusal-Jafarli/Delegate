using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Delegate_Task.Classes
{


    interface Idocument
    {
        public void OpenDocument();
        public  void EditDocument();
        public  void SaveDocument();

    }

    internal class DocumentProgram:Idocument
    {

        public void Functions()
        {
            MyDelegate new_delegate = this.OpenDocument;
            new_delegate += this.EditDocument;
            new_delegate += this.SaveDocument;
            new_delegate.Invoke();

        }

        public DocumentProgram() { }

        public void OpenDocument()
        {
            Console.WriteLine("Document Opened.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
}
