using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public enum BranchType {    בחר , משכנתאות, תרומות, חשבונות };
    public class Branch
    {
        public Branch() { 
            //Id = 0; Name = null;// BranchType = 0;
            //Adress = null;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public BranchType BranchType { get; set; }
        public string Adress { get; set; }
        public override string ToString()
        {
          return string.Format(" מספר: {0}" + " שם: {2}" 
                   , Id, BranchType, Name);
           
        }
    }
}
