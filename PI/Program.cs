using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using BL;
using DAL;


namespace PI
{
    /// <summary>
    /// אוסף של בדיקות לעצמי
    /// </summary>
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IBL f = FactoryBL.getBL();
                Branch b = new Branch();
                Account a = new Account();
                Transaction t = new Transaction();

                a.Balance = 10000;
                a.Credit = 5000;
                a.BranchId = b.Id;


                b.Name = "ahiezer";
                

                f.AddBranch(b);
                a.BranchId = b.Id;

                f.AddAccount(a);

                a.ToString();
                b.ToString();
                f.RemoveAccount(1);


               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

           // b.ToString();
            

           
            
            
        }
    }
}
