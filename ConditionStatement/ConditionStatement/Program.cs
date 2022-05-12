using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st Example
            char Ch = 'x';
            int x, y;
            x = y = 5;
            if(Ch == 'x')
            {
                x += 5; // x = x+5 // 10 =  5 + 5
                Console.WriteLine("The value of x: {0} and y: {1}",x,y);
            }
            //2nd Example
            String UserName;
            String Pass;
            Console.Write("Enter UserName: ");
            UserName = Console.ReadLine();
            Console.Write("Enter Password: ");
            Pass = Console.ReadLine();
            if((UserName == "Admin" || UserName == "admin") && (Pass == "Admin123")){

                Console.WriteLine("Login Successful");

            }
            Console.Read();
        }
    }
}
