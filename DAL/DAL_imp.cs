using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace DAL
{
    public class DAL_imp :DataSource, IDAL
    {
        ///implementation

        /// <summary>
        /// functions for branches
        /// </summary>
         public static int BranchId;
         public static int AccountId;
         public static int TransId;

         public DAL_imp()
         {
             //string path = "xmlBySerilalizer.xml"; 
             //List<Account> list2 = loadListFromXML(path);
             //DAL_XML_imp xml = new DAL_XML_imp();
             //xml.LoadConfig();
             //xml.LoadAccountsList();
             //xml.LoadTransList();
             //xml.LoadBranchesList();
         }
        
         
        
        //מתודות לסניפים
        public void AddBranch(Branch branch)
        {
            //if (GetBranch(branch.Id) != null)
              //  return false;
            branch.Id = ++BranchId;
            BranchesList.Add(branch);
            


        }//מוסיף סניף תוך קידום המספר הרץ
        /// <summary>
        /// מוחק סניף בנק תוך שימוש בפונקציית בדיקה אם הסניף קיים כבר
        /// </summary>
        /// <param name="id">מספר הבנק למחיקה</param>
        /// <returns>מחזיר אמת אם בוצעה המחיקה</returns>
        public bool RemoveBranch(Branch branch)
        {

            try
            {
                //Branch bra = GetBranch(id);
                //if (bra == null)
                //    throw new Exception("DAL ERROR: This Branch doenst found..");

                var v = from item in AccountsList  // מעביר את כל החשבונות בסניף שנמחק למצב 0
                        where item.BranchId == branch.Id
                        select item;
                foreach (var o in v)
                {
                    o.BranchId = 0;
                }
                if (DataSource.BranchesList.Remove(branch))
                    return true;
                else
                    return false;
                
            }
            catch (Exception)
            {
               
                throw;
            }


        }
        /// <summary>
        /// מעדכן נתונים של הסניף
        /// </summary>
        /// <param name="branch">המידע שמתקבל זה אובייקט מסוג סניף</param>
        /// <returns>מחזיר אמת אם בוצע העדכון</returns>
        public bool UpdateBranch(Branch branch)
        {

            try
            {
            //    Branch bra = GetBranch(branch.Id);
            //    if (bra == null)
            //        throw new Exception("DAL ERROR: The requsted branch Id did not found..");

                int i = BranchesList.FindIndex(b => b.Id == branch.Id);
                BranchesList[i] = branch;
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        } 
        //public Branch GetBranch(int id)
        //{
        //    return BranchesList.FirstOrDefault(b => b.Id == id);
        //}//מתודת בדיקה אם הסניף קיים כבר
        public List<Branch> GetAllBranches()
        {
            return BranchesList;
        }//מתודת החזרה של רשימת כל הסניפים


        //מתודות לחשבונות
        public void AddAccount(Account account)
        {
            account.Id = ++AccountId;
            DataSource.AccountsList.Add(account);
            
        }//מוסיף חשבון תוך קידום המספר הרץ
        /// <summary>
        /// מוחק חשבון תוך שימוש בפונקציית בדיקה אם החשבון קיים 
        /// </summary>
        /// <param name="id">מספר החשבון למחיקה</param>
        /// <returns>מחזיר אמת אם בוצעה המחיקה</returns>
        public bool RemoveAccount(Account account)
        {

            //try
            //{
                //Account acc = GetAccount(id);
                //if (acc == null)
                //    throw new Exception("DAL ERROR: This Account doenst found..");
                if (DataSource.AccountsList.Remove(account))
                    return true;
                else
                    return false;
            //}
            ////catch (Exception ex)
            //{
            //    throw;
            //}

        }
        /// <summary>
        /// מעדכן נתונים של החשבון
        /// </summary>
        /// <param name="branch">המידע שמתקבל זה אובייקט מסוג חשבון</param>
        /// <returns>מחזיר אמת אם בוצע העדכון</returns>
        public bool UpdateAccount(Account account)
        {

            try
            {
                int i = AccountsList.FindIndex(a => a.Id == account.Id);
                if (i > -1)
                {
                    AccountsList[i] = account;
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }

        }
        //public Account GetAccount(int id)
        //{
        //    return AccountsList.FirstOrDefault(a => a.Id == id);
        //}//מתודת בדיקה אם החשבון קיים 
        public List<PrivateAccount> GetAllPrivateAccounts()
        {

            List<PrivateAccount> PrivateAccountList = new List<PrivateAccount>();

            foreach (var item in AccountsList)
                if (item.IsPrivate == true)
                    PrivateAccountList.Add((PrivateAccount)item);
            return PrivateAccountList;
             //return (from PrivateAccount Item in DataSource.AccountsList
             //where Item.IsPrivate == true
             //select Item).ToList<PrivateAccount>();

        }//מתודת החזרה של רשימת כל החשבונות הפרטיים תוך שימוש בלינק ושאילתא
        public List<BussinesAccount> GetAllBussinesAccounts()
        {
            List<BussinesAccount> BussinesAccountList = new List<BussinesAccount>();

            foreach (var item in AccountsList)
                if (item.IsPrivate == false)
                    BussinesAccountList.Add((BussinesAccount)item);
            return BussinesAccountList;
        }

            //return (from BussinesAccount Item in DataSource.AccountsList
            //        where Item.IsPrivate == true
            //        select Item).ToList<BussinesAccount>();

            //List<BussinesAccount> BussinesAccountList = new List<BussinesAccount>();
            //var v = from BussinesAccount Item in DataSource.AccountsList
            //        where Item.IsPrivate == false
            //        select Item;
            //foreach (var Item in v)
            //{
            //    BussinesAccountList.Add(Item);
            //}
            //return BussinesAccountList;

        //מתודת החזרה של רשימת כל החשבונות המסחריים תוך שימוש בלינק ושאילתא
            

        //מתודות לפעולות
        public bool AddTrans(Transaction trans)
        {
            trans.Id = ++TransId;
            TransactionsList.Add(trans);
            if (trans.IsUpdated == true)
                return true;
            else
                return false;
        }
         //מוסיף פעולה תוך קידום המספר הרץ
        /// <summary>
        /// מוחק פעולה תוך שימוש בפונקציית בדיקה אם הפעולה קיימת 
        /// </summary>
        /// <param name="id">מספר הפעולה למחיקה</param>
        /// <returns>מחזיר אמת אם בוצעה המחיקה</returns>
        public bool RemoveTrans(Transaction tra)
        {

            //try
            //{
                //Transaction tra = GetTrans(id);
                //if (tra != null)
                //    throw new Exception("DAL ERROR: This transaction does not found..");
                if (DataSource.TransactionsList.Remove(tra))
                    return true;
                else
                    return false;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}


        }
        /// <summary>
        /// מעדכן נתונים של הפעולה
        /// </summary>
        /// <param name="branch">המידע שמתקבל זה אובייקט מסוג פעולה</param>
        /// <returns>מחזיר אמת אם בוצע העדכון</returns>
        public bool UpdateTrans(Transaction trans)
        {
                   int i = TransactionsList.FindIndex(t => t.Id == trans.Id);
                   if (i > -1)
                   {
                       TransactionsList[i] = trans;
                       return true;
                   }
                   else
                       return false;

        }
        //public Transaction GetTrans(int id)
        //{
        //    return TransactionsList.FirstOrDefault(t => t.Id == id);
        //}//מתודת בדיקה אם הפעולה קיימת
        public List<Transaction> GetAllTarnsFromDateToDate(DateTime s, DateTime e)//מחזיר את כל התנועות בטווח תאריך מסויים
        {
            List<Transaction> InTimeList = new List<Transaction>();
            var v = (from Transaction Item in DataSource.TransactionsList
                     where Item.Time > s && Item.Time < e
                     select Item).ToList();
            return v;
        }
    }
}
