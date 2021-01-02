using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoRepository.DataAccess;
using DemoRepository.Model;
using ConsoleApplicationDemoRepos;

namespace ConsoleApplicationDemoRepos
{
    class Program
    {
        public static void Main()
        {
            InterfaceRepo empinterfece = new Implemantation();
            XpayDetails xp = new XpayDetails();
            Console.WriteLine("Enter 1:Insert \t 2:Delete \t 3: update\t 4: show:");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                Console.WriteLine("Id\t  Name\t  Amount\t  Description\t  TermAndCondition ");
              //  int Id = Convert.ToInt32(Console.ReadLine());
                string Name = Console.ReadLine();
                decimal Amount = decimal.Parse(Console.ReadLine());
                string Description = Console.ReadLine();
                string TermAndCondition = Console.ReadLine();
               
                //xp.Id=Id;
                xp.Name= Name;
                xp.Amount = Amount;
                xp.Description = Description;
               xp.TermAndCondition = TermAndCondition;
               
                empinterfece.Insert_record(xp);


                Main();

            }
            if (i == 2)
            {
                Console.WriteLine("Enter id to dlt data");
                int id = Convert.ToInt32(Console.ReadLine());
                xp.Id = id;
                empinterfece.Dlt_Record(xp);
                Console.WriteLine("Datadeleted");
                Main();
            }

            if (i == 3)
            {

                Console.WriteLine("Id,Name,Amount,Description,TermAndCondition");
                Console.WriteLine("Insert Id to be updated");
                int Id = Convert.ToInt32(Console.ReadLine());
                string Name = Console.ReadLine();
                decimal Amount = decimal.Parse(Console.ReadLine());
                string Description = Console.ReadLine();
                string TermAndCondition = Console.ReadLine();

                xp.Id=Id;
                xp.Name = Name;
                xp.Amount = Amount;
                xp.Description = Description;
                xp.TermAndCondition = TermAndCondition;

                empinterfece.Update_Record(xp);


                Main();

            }
            if (i == 4)
            {

                List<XpayDetails> lst = new List<XpayDetails>();
                lst = empinterfece.Show_Record();
                foreach (var obj in lst)
                {
                    Console.WriteLine("id=" + obj.Id + ",name=" + obj.Name + " and num=" + obj.Amount+ "Description= "+ obj.Description+ "Term and condition= "+obj.TermAndCondition);
                }
                Main();

            }

            Console.ReadLine();

        }
    }
}
