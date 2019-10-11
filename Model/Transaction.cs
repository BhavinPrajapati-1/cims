using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIMS.Model
{
    public class Transaction
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public int Unit_ID { get; set; }
        public int Employee_ID { get; set; }
        public int Supplier_ID { get; set; }
        public string InvoiceNumber { get; set; }
        public int PONumber { get; set; }
        public int BillOfMaterials_ID { get; set; }
        public float Price { get; set; }
        public string Remarks { get; set; }
        public int User_ID { get; set; }
        public string CreateDate { get; set; }

        public string Headers
        {
            get
            {
                return "Date,Unit_ID,Employee_ID,Supplier_ID,InvoiceNumber,PONumber,BillOfMaterials_ID,Price,Remarks,User_ID,CreateDate";
            }
        }
    }
}
