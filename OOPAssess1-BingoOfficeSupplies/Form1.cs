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

        string[] prodNumArray = new string[20];
        string[] prodNameArray = new string[20];
        int[] prodStockArray = new int[20];
        double[] prodPriceArray = new double[20];
        string[] prodPicArray = new string[20];

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("msg1");
            buildarray();

            MessageBox.Show("msg2");
        }

        public void buildarray()
        {
        //making a string to read in each line
            string nextLine;

            //and a string for the file path
            string filePath;
            filePath = "C:/Users/James/OneDrive/Certificate IV in Programming/Semester 2/Assessments/Products.txt";
            MessageBox.Show("msg10");
            //and a streamreader to pipe in the data
            StreamReader pipeIn;

            //finally a string array to hold the split up line
            string[] splitString = new string[5];

            //checking if the data file exists
            if (File.Exists(filePath))
            {
                //popping open the text file to read things from it
                pipeIn = File.OpenText(filePath);

                //reading in the next line
                nextLine = pipeIn.ReadLine();
                int count = 0;
                //as long as the next line in the text file isn't empty...
                while (nextLine != null)
                {
                    //making a temporary array to store the split up line
                    string[] lineArray = new string[5];
                    //break up the next line by the commas
                    lineArray = nextLine.Split(',');

                    //order of the fields: product code, product name, amount of stock, individual sale price, image name
                    prodNumArray[count] = lineArray[0];
                    prodNameArray[count] = lineArray[1];
                    prodStockArray[count] = Int32.Parse(lineArray[2]);
                    prodPriceArray[count] = double.Parse(lineArray[3]);
                    prodPicArray[count] = lineArray[4];
                    nextLine = pipeIn.ReadLine();
                    count++;
                }

            }

            lBox_ProductsDisplay.DataSource = prodNameArray;

        }
    }
}
