using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssess1_BingoOfficeSupplies
{
    class SalesInvoice
    {
        int userInvoiceNumber;
        string userProductNumber;
        int userSalePrice;
        int userAmtPurchased;
        int userSaleValue;

        SalesInvoice()
        {
            InvoiceNumber = 0;
            ProductNumber = "No product number set";
            SalePrice = 0;
            AmtPurchased = 0;
            SaleValue = 0;
        }

        public int InvoiceNumber
        {
            set { userInvoiceNumber = value; }
            get { return userInvoiceNumber; }
        }

        public string ProductNumber
        {
            set { userProductNumber = value; }
            get { return userProductNumber; }
        }

        public int SalePrice
        {
            set { userSalePrice = value; }
            get { return userSalePrice; }
        }

        public int AmtPurchased
        {
            set { userAmtPurchased = value; }
            get { return userAmtPurchased; }
        }

        public int SaleValue
        {
            set { userSaleValue = value; }
            get { return userSaleValue; }
        }

        public int SaleTotal(int SalePrice, int AmountPurchased)
        {
            int TotalPrice;

            TotalPrice = SalePrice * AmountPurchased;

            return TotalPrice;
        }
    }
     
}
