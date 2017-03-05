using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using BL;

namespace BL
{
    public interface IBL
    {

        /// <summary>
        /// מתודות סניפים
        /// </summary>
        void AddBranch(Branch branch);
        bool RemoveBranch(Branch branch);
        bool UpdateBranch(Branch branch);
        //Branch GetBranch(int id);
        List<Branch> GetAllBranches();


       /// <summary>
       /// מתודות חשבונות
       /// </summary>
        void AddAccount(Account account);
        bool RemoveAccount(Account account);
        bool UpdateAccount(Account account);
        //Account GetAccount(int id);
        List<PrivateAccount> GetAllPrivateAccounts();
        List<BussinesAccount> GetAllBussinesAccounts();


        /// <summary>
        /// מתודות העברה
        /// </summary>
        bool AddTrans(Transaction trans);
        bool RemoveTrans(Transaction trans);
        bool UpdateTrans(Transaction trans);
       // Transaction GetTrans(int id);
        List<Transaction> GetAllTarnsFromDateToDate(DateTime s, DateTime e);
    
        // מתודות נוספות 

        /// <summary>
        /// מחשב את כל ההכנסות לחשבון מסויים בטווח זמן
        /// </summary>
        double AllTheIncomingPerAccount(Account account, DateTime s, DateTime e);
        /// <summary>
       /// עדכון כל החשבונות לפי רשימה של תנועות 
       /// </summary>
        void AllAccountsUpdate(List<Transaction> translist);
        /// <summary>
        /// return sum of transaction per accounts between given time
        /// </summary>
        /// <param name="account_id">id of the account</param>
        /// <param name="start">between the time</param>
        /// <param name="end">to time</param>
        /// <returns>the sum of transaction</returns>
        List<Transaction> SumOfTransPerAccount(int account_id, DateTime start, DateTime end);
        List<Account> GetAccountsByCondition(Predicate<Account> p);
        List<Branch> GetBranchesByCondition(Predicate<Branch> p);
        List<Transaction> GetTransByCondition(Predicate<Transaction> p);

        /// <summary>
        /// return the rich man
        /// </summary>
        /// <returns></returns>
        Account TheRichest();
        /// <summary>
        /// returns list of account's id that in overdraft
        /// </summary>
        /// <returns>id</returns>
        Account TheBiggestCompany();
        /// <summary>
        /// returns how much accounts in the bank
        /// </summary>
        /// <returns>sum of accounts</returns>
        int HowMuchAccounts();
    }
}
