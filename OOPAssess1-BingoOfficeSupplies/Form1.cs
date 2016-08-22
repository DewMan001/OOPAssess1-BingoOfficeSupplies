using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOPAssess1_BingoOfficeSupplies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clearing out the listbox
            lBox_ProductsDisplay.Items.Clear();

            //making a string to read in each line
            string readLine;

            //and a string for the file path
            string filePath;
            filePath = "C:/Users/James/OneDrive/Certificate IV in Programming/Semester 2/Assessments/OOPAssess1-BingoOfficeSupplies/OOPAssess1-BingoOfficeSupplies/Products.txt";

            //and a streamreader to pipe in the data
            StreamReader pipeIn;

            //checking if the data file exists
        }
    }
}
