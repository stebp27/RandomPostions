using System;

namespace HelloCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Luca", "Stefano", "Fabio", "Federico", "Alessio", "Andrea",
            "Gianluca", "Nicoletta", "Francesco", "Valerio", "Matteo", "Cristian"};

             PrintStudents(students);
        }

        static void PrintStudents(string[] students)
        {
            string[] rndOrder = new string[] {"","","","","","","","","","","",""};

            int insert = 0;

            while(insert < 12)
            {

            Random rnd = new Random();
            
            int r = rnd.Next(12);
            
                if(rndOrder[r] == "")
                {
                rndOrder[r] = students[insert];
                insert++;
                }
           
            }
            for(int i=0; i<rndOrder.Length -1; i++)
            {
                Console.WriteLine(rndOrder[i++].PadRight(15)+rndOrder[i]);
            }
        }
    }
}
