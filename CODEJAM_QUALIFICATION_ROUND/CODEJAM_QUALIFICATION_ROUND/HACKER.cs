using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEJAM_QUALIFICATION_ROUND
{
    class HACKER
    {//Lets hack robot :p
     /// <summary>
     /// start of beam with a strength of 1 so set
     /// </summary>

        char[] data;
       // bool RobotAttackEnable = true;
        int TotalDamage;
        int beam_strength;
        //int Calculated_Damage;
        long SheildStrength;
        int TotalHackAttacks = 0;
        public HACKER(string data, long SheildStrength)
        {
            GetData(data);
            this.SheildStrength = SheildStrength;
            Calculated_Damage = 1;
            beam_strength = 1;
        }
        public void StartHacking()
        {
            while (StartAttack() == true)
            {

            }
            //if (!RobotAttackEnable)
            //    Console.WriteLine("No need to attack");
           
            //else if(TotalHackAttacks==0&&RobotAttackEnable)
            //{
            //    Console.WriteLine("No need to attack robot program beacause according to robot program damage to universe=" + TotalDamage + "So the shield can stand with it");

            //}
             if (TotalDamage>SheildStrength)
                Console.WriteLine("Impossible");
            else
            {
                Console.WriteLine("Total Attacks " + TotalHackAttacks);
            }
        }
        private bool StartAttack()
        {
            bool ISswap = false;
            bool FormatCheck = true;
            TotalDamage = GetDamage();
            if (TotalDamage == 0)
            {
               // RobotAttackEnable = false;
                return false;
            }
            else if (TotalDamage > SheildStrength)
            {
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] == 'C' && data[i + 1] == 'S')
                    {
                        swap(data[i]);
                        ISswap = true;
                        ++TotalHackAttacks;
                        break;
                    }
                }
                TotalDamage = GetDamage();
                return ISswap;
            }
            else
            {
                return false;
            }
            
        }
        private int GetDamage()
        {
            foreach (char x in data)
            {
                if (x == 'C')
                {

                    beam_strength *= 2;


                }
                if (x == 'S')
                {
                  //  Console.WriteLine("Shooting beam >>>>>>");
                    TotalDamage += beam_strength;
                   // Console.WriteLine("DAMAGE BY ROBOT >>>> " + beam_strength);

                }
            }
            return TotalDamage;
        }
        private void swap(int i)
        {
            Char temp = data[i];
            data[i] = data[i + 1];
            data[i + 1] = temp;
        }
        private void GetData(string data)
        {
            this.data = data.ToArray<Char>();
        }
        public int GetTotalAttacks
        {
            get { return TotalHackAttacks; }
        }
    }
}
