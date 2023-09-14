
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task.Classes
{
    internal class ExpertDocument : ProDocumentProgram, Idocument
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened.");
        }
        public void EditDocument()
        {
            Console.WriteLine("Document Edited.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format.");
        }
    }
}
