using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using DAL;
using BE;
using BL;

namespace PLForms
{
    static class Program
    {


        //public static void saveListToXML(List<Account> list, string path)
        //{
        //    XmlSerializer x = new XmlSerializer(list.GetType());
        //    FileStream fs = new FileStream(path, FileMode.Create);
        //    x.Serialize(fs, list);
        //}

        //public static List<Account> loadListFromXML(string path)
        //{
        //    List<Account> list;
        //    XmlSerializer x = new XmlSerializer(typeof(List<Account>));
        //    FileStream fs = new FileStream(path, FileMode.Open);
        //    list = (List<Account>)x.Deserialize(fs);
        //    return list;

        //}

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            DAL_XML_imp xml = new DAL_XML_imp();

            xml.LoadConfig();
            xml.LoadAccountsList();
            xml.LoadTransList();
            xml.LoadBranchesList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            xml.SaveConfig();
            xml.SaveAccountsList();
            xml.SaveTransList();
            xml.SaveBranchesList();
        }
    }
}
