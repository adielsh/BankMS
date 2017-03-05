using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;

namespace DAL
{
    public interface IDAL
    {
        /// <summary>
        /// מתודות סניפים
        /// </summary>
        void AddBranch(Branch branch);
        bool RemoveBranch(Branch branch);
        bool UpdateBranch(Branch branch);
       // Branch GetBranch(int id);
        List<Branch> GetAllBranches();


       /// <summary>
       /// מתודות חשבונות
       /// </summary>
        void AddAccount(Account account);
        bool RemoveAccount(Account account);
        bool UpdateAccount(Account account);
      //  Account GetAccount(int id);
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

    }
}
