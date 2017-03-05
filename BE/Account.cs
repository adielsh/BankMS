using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public enum AccountStatus
    {
        בחירה ,חסום, פעיל,
        עלתנאי
    }
    public class Account
    {
      // public Account() { }
        public bool IsPrivate { get; set; }//TRUE for Private and FALSE for Bussines
        public int Id { get;  set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int BranchId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime OpenDate { get; set; }
        public string Password { get; set; }
        public double Credit { get; set; }
        public double Balance { get; set; }//יתירה
        public AccountStatus AccountStatus
        {
            get;
            set;
        }
        public override string ToString()
        {
                return string.Format("מספר: {0} " + "שם: {1} " , Id, Name);
        }

    }
}
