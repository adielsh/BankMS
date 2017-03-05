using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DAL;
using BE;
using System.IO;


namespace DAL
{
   public class DAL_XML_imp
    {
        XElement accountRoot;
        string F1Path = @"AccountsXml.xml";
        XElement branchRoot;
        string F2Path = @"BranchesXml.xml";
        XElement transRoot;
        string F3Path = @"TransXml.xml";
        XElement configRoot;
        string F4Path = @"config.xml";

        public DAL_XML_imp()
        {
            //LoadAccountsList();

            //LoadTransList();
            //SaveTransList(DataSource.TransactionsList);

        }

        public void LoadConfig()
        {
            if (File.Exists(F4Path))
            {
                configRoot = XElement.Load(F4Path);
                DAL_imp.AccountId = Convert.ToInt32(configRoot.Element("AccountId").Value);
                DAL_imp.BranchId = Convert.ToInt32(configRoot.Element("BranchId").Value);
                DAL_imp.TransId = Convert.ToInt32(configRoot.Element("TransId").Value);
            }
            else
            {
                DAL_imp.AccountId = 0;
                DAL_imp.BranchId = 0;
                DAL_imp.TransId = 0;
            }
         }
        public void SaveConfig()
        {         
                configRoot = new XElement("Config");
                configRoot.Add(new XElement("AccountId", DAL_imp.AccountId),
                               new XElement("BranchId", DAL_imp.BranchId),
                               new XElement("TransId", DAL_imp.TransId));
                configRoot.Save(F4Path);
        }


        public void LoadAccountsList()
        {

            if (File.Exists(F1Path))
            {
                accountRoot = XElement.Load(F1Path);
                foreach (var Item in accountRoot.Elements())
                {
                    if (Item.Name == "privateAccount")
                    {

                        DataSource.AccountsList.Add(new PrivateAccount()
                                  {
                                      Id = Convert.ToInt32(Item.Element("Id").Value),
                                      Name = Item.Element("Name").Value,
                                      Credit = Convert.ToDouble(Item.Element("Credit").Value),
                                      Adress = Item.Element("Adress").Value,
                                      //AccountStatus = (AccountStatus)Enum.Parse(typeof(AccountStatus), Item.Element("AccountStatus").Value),
                                      Balance = Convert.ToDouble(Item.Element("Balance").Value),
                                      BranchId = Convert.ToInt32(Item.Element("BranchId").Value),
                                      IsPrivate = Convert.ToBoolean(Item.Element("IsPrivate").Value),
                                      OpenDate = Convert.ToDateTime(Item.Element("OpenDate").Value),
                                      Password = Item.Element("Password").Value,
                                      PhoneNumber = Item.Element("PhoneNumber").Value,
                                      CreditNumber = Convert.ToInt32(Item.Element("CreditNumber").Value)
                                  });
                    }

                    else if (Item.Name == "bussinesAccount")
                    {
                        DataSource.AccountsList.Add(new BussinesAccount()
                                {
                                    Id = Convert.ToInt32(Item.Element("Id").Value),
                                    Name = Item.Element("Name").Value,
                                    Credit = Convert.ToDouble(Item.Element("Credit").Value),
                                    Adress = Item.Element("Adress").Value,
                                    AccountStatus = (AccountStatus)Enum.Parse(typeof(AccountStatus), Item.Element("AccountStatus").Value.ToString()),
                                    Balance = Convert.ToDouble(Item.Element("Balance").Value),
                                    BranchId = Convert.ToInt32(Item.Element("BranchId").Value),
                                    IsPrivate = Convert.ToBoolean(Item.Element("IsPrivate").Value),
                                    OpenDate = Convert.ToDateTime(Item.Element("OpenDate").Value),
                                    Password = Item.Element("Password").Value,
                                    PhoneNumber = Item.Element("PhoneNumber").Value,
                                    Allowed = (Item.Element("Allowed").Value).Split().ToList<string>()
                                });
                    }
                }
            }
        }
        public void SaveAccountsList()
        {
            if (DataSource.AccountsList.Count!=0)
            {

                accountRoot = new XElement("Accounts");

                foreach (var Item in DataSource.AccountsList)
                {
                    if (Item is PrivateAccount)
                    {
                        PrivateAccount thisAccount = (PrivateAccount)Item;
                        accountRoot.Add( new XElement("privateAccount",
                                         new XElement("Id", thisAccount.Id),
                                         new XElement("Name", thisAccount.Name),
                                         new XElement("AccountStatus", thisAccount.AccountStatus),
                                         new XElement("IsPrivate", thisAccount.IsPrivate),
                                         new XElement("OpenDate", thisAccount.OpenDate),
                                         new XElement("Password", thisAccount.Password),
                                         new XElement("PhoneNumber", thisAccount.PhoneNumber),
                                         new XElement("Balance", thisAccount.Balance),
                                         new XElement("Credit", thisAccount.Credit),
                                         new XElement("BranchId", thisAccount.BranchId),
                                         new XElement("CreditNumber", thisAccount.CreditNumber),
                                         new XElement("Adress", thisAccount.Adress)
                                         ));
                    }
                    else if (Item is BussinesAccount)
                    {
                        BussinesAccount thisAccount = (BussinesAccount)Item;
                        accountRoot.Add(new XElement("bussinesAccount",
                                              new XElement("Id", thisAccount.Id),
                                              new XElement("Name", thisAccount.Name),
                                              new XElement("AccountStatus", thisAccount.AccountStatus),
                                              new XElement("IsPrivate", thisAccount.IsPrivate),
                                              new XElement("OpenDate", thisAccount.OpenDate),
                                              new XElement("Password", thisAccount.Password),
                                              new XElement("PhoneNumber", thisAccount.PhoneNumber),
                                              new XElement("Balance", thisAccount.Balance),
                                              new XElement("Credit", thisAccount.Credit),
                                              new XElement("BranchId", thisAccount.BranchId),
                                              new XElement("Adress", thisAccount.Adress),
                                              new XElement("Allowed", string.Join(" ", thisAccount.Allowed.ToArray())
                                              )));
                    }
                }

                accountRoot.Save(F1Path); 
            }
        }

        public void LoadBranchesList()
        {
            if (File.Exists(F2Path))
            {
                branchRoot = XElement.Load(F2Path);
                foreach (var Item in branchRoot.Elements())
                {
                    DataSource.BranchesList.Add(new Branch()
                    {
                        Id = Convert.ToInt32(Item.Element("Id").Value),
                        Name = Item.Element("Name").Value,
                        Adress = Item.Element("Adress").Value,
                        BranchType = (BranchType)Enum.Parse(typeof(BranchType), Item.Element("BranchType").Value.ToString()),
                      // BranchType =  int.Parse(BranchType.ToString(Item.Element("BranchType").Value))
                    });
                    
                    
                      
                }
             }
            
        }
        public void SaveBranchesList()
        {
            if (DataSource.BranchesList.Count!=0)
            {
              
                foreach (var Item in DataSource.BranchesList)
                {
                    branchRoot = new XElement("branches");
                    branchRoot.Add(  new XElement("branch",
                                     new XElement("Id", Item.Id),
                                     new XElement("Name", Item.Name),
                                     new XElement("BranchType", Item.BranchType.ToString()),
                                     new XElement("Adress", Item.Adress)
                                     ));

                }


                branchRoot.Save(F2Path); 
            }
        }


        public void LoadTransList()
        {


                if (File.Exists(F3Path))
                {

                    transRoot = XElement.Load(F3Path);

                    foreach (var Item in transRoot.Elements())
                    {

                        DataSource.TransactionsList.Add(new Transaction()
                                {
                                    Id = Convert.ToInt32(Item.Element("Id").Value),
                                    FromAccountId = Convert.ToInt32(Item.Element("FromAccountId").Value),
                                    ToAccountId = Convert.ToInt32(Item.Element("ToAccountId").Value),
                                    TransType = (TransType)Enum.Parse(typeof(TransType),Item.Element("TransType").Value.ToString()),
                                    IsUpdated = Convert.ToBoolean(Item.Element("IsUpdated").Value),
                                    UpdateTime = Convert.ToDateTime(Item.Element("UpdateTime").Value),
                                    Sum = Convert.ToDouble(Item.Element("Sum").Value),
                                    Time = Convert.ToDateTime(Item.Element("Time").Value),
                                });

                    }
                } 
            
        }
        public void SaveTransList()
        {

            if (DataSource.TransactionsList.Count()!=0)
            {
                foreach (var Item in DataSource.TransactionsList)
                {
                    transRoot = new XElement("transactions");
                    transRoot.Add(   new XElement("transactions",
                                     new XElement("FromAccountId", Item.FromAccountId),
                                     new XElement("Id", Item.Id),
                                     new XElement("IsUpdated", Item.IsUpdated),
                                     new XElement("Sum", Item.Sum),
                                     new XElement("Time", Item.Time),
                                     new XElement("ToAccountId", Item.ToAccountId),
                                     new XElement("TransType", Item.TransType),
                                     new XElement("UpdateTime", Item.UpdateTime))
                                     );

                }
                transRoot.Save(F3Path); 
            }
        }
    }
}
