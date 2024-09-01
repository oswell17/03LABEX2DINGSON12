using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LABEX2DINGSON12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DTP = @"C:\Users\dings\Documents\Requirements";//system path


            string[] FilesCheck = // dito i check kung avail yung nasa requirements
            {
                "GOODMORAL.docx",
                "FORM137.docx",
                "SHSDIPLOMA.docx",
                "PSA.docx",
                "MEDCERT.docx",
            };


            Console.WriteLine("WELLCOME TO STI WEBSITE ");
            Console.Write("Enter Name: "); //ask name
            string name = Console.ReadLine();



            Console.WriteLine("");// space
            Console.WriteLine("Here's the Choices of Course ");
            Console.WriteLine("BSCS " + "BSIT");

            Console.WriteLine(""); //space

            Console.Write("Choose your Course: ");//asking for course
            string course = Console.ReadLine();

            if (course == "BSCS" || course == "bscs" || course == "Bscs")
            {
                Console.WriteLine("You Choose " + course);
                Console.WriteLine("For more info about BSCS Click here: " + "https://www.sti.edu/programs-details.asp?p=Mg==");
            }
            else if (course == "BSIT" || course == "bsit" || course == "Bsit")
            {
                Console.WriteLine("You Choose " + course);
                Console.WriteLine("For more info about BSIT Click here: " + "https://www.sti.edu/programs-details.asp?p=Mw==");
            }
            else
            {

                Console.WriteLine("Invalid Please choose your courses");

            }



            Console.WriteLine(" ");// space

            //ask for cash or installment 
            Console.Write("Cash or Installment: ");
            String CI = Console.ReadLine();
            //another if else statement
            if (CI == "CASH" || CI == "Cash" || CI == "cash")
            {
                Console.WriteLine("You Choose CASH");
                Console.WriteLine("That will be 32,000 pesos");

            }
            else if (CI == "INSTALLMENT" || CI == "Installment" || CI == "installment")
            {
                Console.WriteLine("You Choose " + CI);
                Console.WriteLine("The Deposit will be P 10,000 pesos");
                Console.WriteLine("That will be 6,250 pesos per Quarter ");


            }
            else
            {
                Console.WriteLine("Invalid Please Choose if Cash or Installment");

            }
            Console.WriteLine("");
            //requirements
            Console.WriteLine("Here's The requirements for enrolling to STI ");
            Console.WriteLine("GOOD MORAL");
            Console.WriteLine("FORM 137");
            Console.WriteLine("SHS DIPLOMA");
            Console.WriteLine("PSA");
            Console.WriteLine("MEDICAL CERTIFICATE");
            Console.Write("Have you Submitted the Requirements (YES/NO) ");
            string re = Console.ReadLine();

            foreach (string file in FilesCheck)
            {
                string combi = Path.Combine(DTP, file);
                if (File.Exists(combi))
                {

                    Console.WriteLine($"The File {file} exists");


                }
                else
                {
                    Console.WriteLine($"The File {file} does not exists");

                }


            }

        }
    }
}
