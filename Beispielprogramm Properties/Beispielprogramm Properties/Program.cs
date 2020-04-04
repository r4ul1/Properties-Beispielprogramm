using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispielprogramm_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            HISTORY asd = new HISTORY("Samuel", "Russische Monarchie");
            asd.isSupliert = false;

            Console.WriteLine(asd.LessionBegin);
            asd.Printlession();
        }
    }

    class HISTORY
    {
        private string teacher = "Franklin";
        private string secTeacher;
        private string topic;
        private int lessionBegin = 3;

        public HISTORY(string secTeach, string top)
        {
            secTeacher = secTeach;
            topic = top;
        }

        public int LessionBegin
        {
            get { return lessionBegin; }
        }

        public bool isSupliert;

        public void Printlession()
        {
            Console.WriteLine("Die Lehrer sind {0} und {1}", teacher, secTeacher);
            Console.WriteLine("Der Unterricht fängt an in der {0}. Stunde", lessionBegin);
            Console.WriteLine("Das Thema ist {0}", topic);

            if (isSupliert)
            {
                Console.WriteLine("Aber die Stunde ist supliert");
            }
            else
            {
                Console.WriteLine("Die Stunde ist nicht supliert");
            }
        }
    }
}