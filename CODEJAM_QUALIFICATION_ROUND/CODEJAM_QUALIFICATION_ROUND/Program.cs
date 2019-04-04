using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEJAM_QUALIFICATION_ROUND
{
    class Program
    {
        static void Main(string[] args)
        {
            string RobotAttackingProgram;
            Console.WriteLine("Enter Robot Attack Program");
            Console.Write(">>>>>");
            RobotAttackingProgram = Console.ReadLine();
            Console.WriteLine("Enter Total Strength of Shield");
            Console.Write(">>>>>");
            long ShieldStrength = long.Parse(Console.ReadLine());
          
            HACKER h1 = new HACKER(RobotAttackingProgram.ToUpper(),ShieldStrength);
            h1.StartHacking();

        }
    }
}
