using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using BE;

namespace BL
{
    public class BL_imp : IBL
    {

        IDAL dal = FactoryDal.getDal();

        //מתודות לסניפים
        public void AddBranch(Branch branch)
        {

           dal.AddBranch(branch);
        }//מוסיף סניף תוך קידום המספר הרץ
        public bool RemoveBranch(Branch branch)
        {
            if (DataSource.BranchesList.Count() == 1&&DataSource.AccountsList.Count()!=0)
                return false;//אם יש רק סניף אחד ואין לאן להעביר את החשבונות, במקרה כזה פשוט נצטרך למחוק קודם את כל החשבונות
           return dal.RemoveBranch(branch);
        }//מוחק סניף בנק תוך שימוש בפונקציית בדיקה אם הסניף קיים כבר
        public bool UpdateBranch(Branch branch)
        {
            return dal.UpdateBranch(branch);
        } //מעדכן שם וכו
        //public Branch GetBranch(int id)
        //{
        //  return dal.GetBranch(id);
        //}//מתודת בדיקה אם הסניף קיים כבר
        public List<Branch> GetAllBranches()
        {
            return dal.GetAllBranches();
        }//מתודת החזרה של רשימת כל הסניפים


        //מתודות לחשבונות
        public void AddAccount(Account account)
        {
            dal.AddAccount(account);
        }//מוסיף חשבון תוך קידום המספר הרץ
        public bool RemoveAccount(Account account)
        {
                var v = from item in DataSource.TransactionsList  //מעדכן בשעת מחיקת חשבון את המאפיין בולאני של התנועות הקשורות לחשבון  
                        where item.FromAccountId == account.Id || item.ToAccountId == account.Id
                        select item;
                foreach (var o in v)
                {
                    o.IsUpdated = true;
                }
                return dal.RemoveAccount(account);
        }//מוחק חשבון תוך שימוש בפונקציית בדיקה אם החשבון קיים כבר
        public bool UpdateAccount(Account account)
        {
            return dal.UpdateAccount(account);
        }//מעדכן יתרת וסיסמת חשבון
        //public Account GetAccount(int id)
        //{
        //    return dal.GetAccount(id);
        //}//מתודת בדיקה אם החשבון קיים כבר
        public List<PrivateAccount> GetAllPrivateAccounts()
        {
            return dal.GetAllPrivateAccounts();

        }//מתודת החזרה של רשימת כל החשבונות הפרטיים תוך שימוש בלינק ושאילתא
        public List<BussinesAccount> GetAllBussinesAccounts()
        {
            return dal.GetAllBussinesAccounts();

        }//מתודת החזרה של רשימת כל החשבונות המסחריים תוך שימוש בלינק ושאילתא


        //מתודות לתנועות
        /// <summary>
        /// מתודת הוספת תנועה עם בדיקות נוספות של הבי אל
        /// </summary>
        /// <param name="trans"></param>
        /// <returns></returns>
        public bool AddTrans(Transaction trans)
        {
                Account temp = DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.FromAccountId);
                if ((temp.Credit + temp.Balance) < trans.Sum&&trans.TransType!=TransType.הפקדת_מזומן)
                {
                    trans.IsUpdated = false;
                    return dal.AddTrans(trans);
                }

                   // if (trans.TransType != TransType.הפקדת_מזומן && trans.TransType != TransType.משיכה_מכספומט)
                      if (trans.TransType == TransType.הוצאה_בהוראת_קבע || trans.TransType == TransType.העברה_מחשבון_לחשבון|| trans.TransType == TransType.צק)
                    {
                        DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.FromAccountId).Balance -= trans.Sum;//עדכון תנועה בחשבון הנחסר כסף 
                        DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.ToAccountId).Balance += trans.Sum;//עדכון תנועה בחשבון המרוויח כסף
                        
                    }

                    else if (trans.TransType == TransType.הפקדת_מזומן)
                    {
                        DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.ToAccountId).Balance += trans.Sum;//עדכון תנועה בחשבון המרוויח כסף
                    }
                    else if (trans.TransType == TransType.משיכה_מכספומט)
                    {
                        DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.FromAccountId).Balance -= trans.Sum;//עדכון תנועה בחשבון הנחסר כסף
                    }
                    trans.IsUpdated = true;
                    trans.UpdateTime=DateTime.Now;
                    return dal.AddTrans(trans);
        }          
        
        /// <summary>
        /// מחיקת פעולה כדלעיל בדאל אין כאן תוספות 
        /// </summary>
        /// <param name="id">מספר הפעולה</param>
        /// <returns>מחזיר אמת אם בוצעה הפעולה</returns>
        public bool RemoveTrans(Transaction trans)
        {
            if (trans.IsUpdated == false)
                return dal.RemoveTrans(trans);
            else
                return false;
        }
        /// <summary>
        /// מעדכן נתונים של הפעולה, אין תוספות על הדאל
        /// </summary>
        /// <param name="branch">המידע שמתקבל זה אובייקט מסוג פעולה</param>
        /// <returns>מחזיר אמת אם בוצע העדכון</returns>
        public bool UpdateTrans(Transaction trans)
        {
            Account temp = DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.FromAccountId);
            if ((temp.Credit + temp.Balance) < trans.Sum)
                return false;

                if (trans.TransType != TransType.הפקדת_מזומן && trans.TransType != TransType.משיכה_מכספומט)
                {
                    DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.FromAccountId).Balance -= trans.Sum;//עדכון תנועה בחשבון הנחסר כסף 
                    DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.ToAccountId).Balance += trans.Sum;//עדכון תנועה בחשבון המרוויח כסף

                }

                else if (trans.TransType == TransType.הפקדת_מזומן)
                {
                    DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.ToAccountId).Balance += trans.Sum;//עדכון תנועה בחשבון המרוויח כסף
                }
                else if (trans.TransType == TransType.משיכה_מכספומט)
                {
                    DataSource.AccountsList.FirstOrDefault(a => a.Id == trans.FromAccountId).Balance -= trans.Sum;//עדכון תנועה בחשבון הנחסר כסף
                }
                trans.IsUpdated = true;
                trans.UpdateTime = DateTime.Now;
                return dal.UpdateTrans(trans);
     
        }
        /// <summary>
        /// כמו בדאל
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public Transaction GetTrans(int id)
        //{
        //    return dal.GetTrans(id);
        //}
        /// <summary>
        /// מחזיר את כל התנועות בטווח תאריך מסויים, אין תוספת על הדאל
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public List<Transaction> GetAllTarnsFromDateToDate(DateTime s, DateTime e)
        {
            return dal.GetAllTarnsFromDateToDate(s, e);
        }





        //מימוש למתודות הנוספות

        /// <summary>
        /// מחשב את כל ההכנסות לחשבון מסויים בטווח זמן
        /// </summary>
        public double AllTheIncomingPerAccount(Account account, DateTime s, DateTime e)
        {
            double InTimeIncoming = 0;
            var v = from Transaction Item in DataSource.TransactionsList
                    where
                    Item.UpdateTime > s && Item.UpdateTime < e && Item.ToAccountId == account.Id
                    && (Item.TransType != TransType.משיכה_מכספומט)
                    select Item;
            foreach (var Item in v)
            {
                InTimeIncoming+=Item.Sum;
            }
            return InTimeIncoming;
        }
        /// <summary>
        /// עדכון כל החשבונות לפי רשימה של תנועות, המתודה הזו פשוט מעדכנת תנועות שלא מסומנות כאפדייטד ועושה את הפעולה האמורה
        /// </summary>
        /// <param name="Translist">רשימה של תנועות</param>
        public void AllAccountsUpdate(List<Transaction> Translist)
        {
            //try
            //{
                var v = from Transaction Item in DataSource.TransactionsList
                        where Item.IsUpdated == false
                        select Item;
                foreach (var item in v)
                {
                    UpdateTrans(item);
                }
        
            //        if (item.TransType == TransType.העברה_מחשבון_לחשבון || item.TransType == TransType.הפקדת_צק ||
            //            item.TransType == TransType.הוצאה_באמצעות_צק || item.TransType == TransType.הוצאה_בהוראת_קבע || item.TransType == TransType.קבלה_מחשבון_אחר)
            //        {
            //            var nifkad = DataSource.AccountsList.FirstOrDefault(a => a.Id == item.ToAccountId);
            //            var mafkid = DataSource.AccountsList.FirstOrDefault(a => a.Id == item.FromAccountId);
            //            if (mafkid.Credit >= item.Sum)
            //            {
            //                nifkad.Balance += (int)item.Sum;//לראו איך אני עושה את זה בלי המרה
            //                mafkid.Balance -= (int)item.Sum;
            //                item.IsUpdated = true;
                            
            //            }

            //            else
            //            {
            //                throw new Exception("BL ERROR: Trans over credit..");
            //            }


            //        }
            //        else if (item.TransType == TransType.הפקדת_מזומן) //במקרה של פעולה שנוגעת רק לאדם אחד, כאן זו פעולת הכנסה
            //        {
            //            var OperationOwner = DataSource.AccountsList.FirstOrDefault(a => a.Id == item.ToAccountId);
            //            if (OperationOwner.Credit >= item.Sum)
            //            {
            //                OperationOwner.Balance += (int)item.Sum;//לראו איך אני עושה את זה בלי המרה
            //                item.IsUpdated = true;                         
            //            }
            //            else
            //            {
            //                throw new Exception("BL ERROR: Trans over credit..");
            //            }
            //        }
            //        else if (item.TransType == TransType.משיכה_מכספומט)  //במקרה של פעולה שנוגעת רק לאדם אחד, כאן זו פעולת הוצאה
            //        {
            //            var OperationOwner = DataSource.AccountsList.FirstOrDefault(a => a.Id == item.FromAccountId);
            //            if (OperationOwner.Credit >= item.Sum)
            //            {
            //                OperationOwner.Balance -= (int)item.Sum;//לראו איך אני עושה את זה בלי המרה
            //                item.IsUpdated = true;
            //            }
            //            else
            //            {
            //                throw new Exception("BL ERROR: Trans over credit..");
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
    }
        /// <summary>
        /// מחזיר סכום הפעולות בטווח זמן
        /// </summary>
        /// <param name="account_id">id of the account</param>
        /// <param name="start">between the time</param>
        /// <param name="end">to time</param>
        /// <returns>the sum of transaction</returns>
        public List<Transaction> SumOfTransPerAccount(int account_id, DateTime start, DateTime end)
        {
            List<Transaction> SumOfTransPerAccountList = new List<Transaction>();
            var v = from Transaction Item in DataSource.TransactionsList
                    where Item.Time > start && Item.Time < end && (account_id==Item.ToAccountId||account_id==Item.FromAccountId)
                    select Item;
            foreach (var Item in v)
            {
                SumOfTransPerAccountList.Add(Item);
            }
            return SumOfTransPerAccountList;

        }
        /// <summary>
        /// מחזיר רשימה של חשבונות שעונים על תנאי שמקבלים כפרידקייט
        /// </summary>
        /// <param name="p">פרידיקייט </param>
        /// <returns>רשימת הפעולות שעונות על התנאי הנל</returns>
        public List<Account> GetAccountsByCondition(Predicate<Account> p)
        {
           List<Account> AccountsByConditionList = DataSource.AccountsList.FindAll(p);
           return AccountsByConditionList;
        }
        /// <summary>
        /// מחזיר רשימה של פעולות שעונים על תנאי שמקבלים כפרידקייט
        /// </summary>
        /// <param name="p">פרידיקייט </param>
        /// <returns>רשימת הפעולות שעונות על התנאי הנל</returns>
        public List<Transaction> GetTransByCondition(Predicate<Transaction> p)
        {
            List<Transaction> TransByConditionList = DataSource.TransactionsList.FindAll(p);
            return TransByConditionList;
        }
        /// <summary>
        /// מחזיר רשימה של סניפים שעונים על תנאי שמקבלים כפרידקייט
        /// </summary>
        /// <param name="p">פרידיקייט </param>
        /// <returns>רשימת הסניפים שעונות על התנאי הנל</returns>
        public List<Branch> GetBranchesByCondition(Predicate<Branch> p)
        {
            List<Branch> BranchesByConditionList = DataSource.BranchesList.FindAll(p);
            return BranchesByConditionList;
        }


        /// <summary>
        /// מחזירה את החשבון עם היתרה הגבוהה ביותר
        /// </summary>
        /// <returns></returns>
        /// 


        public Account TheRichest()
        {
            double sum = DataSource.AccountsList.First().Balance;
            Account selected = DataSource.AccountsList.First();
            foreach (var item in DataSource.AccountsList)
            {
                if (item.Balance>sum)
                {
                    sum = item.Balance;
                    selected = item;
                }
            }
            return selected;
        }
        /// <summary>
        /// מחזיר את החברה הכי גדולה לפי כמות מורשי החתימה
        /// </summary>
        /// <returns>id</returns>
        public Account TheBiggestCompany() 
        { 
            int sum=0;
            Account selected=DataSource.AccountsList.First();
            var v = from item in DataSource.AccountsList
                    where item.IsPrivate == false
                    select item;
            foreach (BussinesAccount item in v)
            {
                if (item.Allowed.Count()>sum)
                {
                    sum = item.Allowed.Count();
                    selected = item;
                }
            }
            return selected;
        }
        /// <summary>
        /// מחזירה כמה חשבונות קיימים, כל סוגי השחבונות
        /// </summary>
        /// <returns>sum of accounts</returns>
        public int HowMuchAccounts() 
        {
            return DataSource.AccountsList.Count();
        }
    }
}