using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PhoneBook
{
    public class Person
    {
        public Person()
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string strLine;
            string[] strWords;
            StreamReader sr;
            List<Person> lstPerson = new List<Person>();

            // Skip the first two lines as they are headers
            sr = new StreamReader("data.tsv");
            strLine = sr.ReadLine();
            if (strLine != null)
                strLine = sr.ReadLine();
            if (strLine != null)
                strLine = sr.ReadLine();

            // Read the actual data line by line
            while (strLine != null)
            {
                strWords = strLine.Split('\t');
                Console.WriteLine(strWords[0] + "\t" + strWords[1] + "\t" + strWords[2] + "\t" + strWords[3]);
                strLine = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
