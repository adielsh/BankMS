using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    //public enum TransType
    //{
    //    הגדר, הפקדת_מזומן, הפקדת_צק, העברה_מחשבון_לחשבון,
    //    משיכה_מכספומט, הוצאה_באמצעות_צק, הוצאה_בהוראת_קבע, קבלה_מחשבון_אחר
    //}

    public enum TransType
    {
        הגדר, הפקדת_מזומן, צק, העברה_מחשבון_לחשבון,
        משיכה_מכספומט, הוצאה_בהוראת_קבע, 
    }

    public class Transaction
    {
        public int Id { get; set; }
        public int FromAccountId { get; set; }
        public DateTime Time { get; set; }
        public double Sum { get; set; }
        public DateTime UpdateTime { get; set; }
        public int ToAccountId { get; set; }
        public TransType TransType { get; set; }
        public bool IsUpdated { get; set; }
        public override string ToString()
        {
            return string.Format("מספר: {0} " +"סכום: {1} "+"סוג: {2} ", Id, Sum,TransType);
        }

    }
}
