using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class PrivateAccount :Account
    {
     //   public PrivateAccount() { }
        public int CreditNumber { get; set; }
        public override string ToString()
        {
            return string.Format("Account Id: {0}\n" + "Name: {1}\n", Id, Name);
        }
    }
}
