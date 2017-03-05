using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class BussinesAccount :Account
    {
        //public BussinesAccount()       
        //{ 
           
        //    //Id =0;
        //    //Name = null;
        //    //Credit = 0;
        //    //Adress = null;
        //    //AccountStatus = 0;
        //    ////Convert.ChangeType((Item.Element("AccountStatus").Value)),
        //    //Balance = 0;
        //    //BranchId = 0;
        //    //IsPrivate = false;
        //    //OpenDate = DateTime.Now;
        //    //Password = null;
        //    //PhoneNumber = null;
        //    //Allowed = null;

        //}
        public List<string> Allowed = new List<string>();
        public override string ToString()
        {             
           return string.Format("Id: {0}" + "Name {1}" ,Id, Name);
        }
    }
}
