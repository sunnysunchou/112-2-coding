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

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the
        // user and assigns it to the variable passed as
        // an argument.

        // The GetCountries method accpets a filename as an
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.
        

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string filename = "";
            //GetFileName(ref filename);

            filename = GetFileNamebyReturn();

            GetCountries(filename);
        }

        private string GetFileNamebyReturn()
        {
            string selectedFile;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFile.FileName;
            }
            else
            {
                selectedFile = "";
            }
            return selectedFile;
        }
        private void GetFileName(ref string selectedFile)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFile.FileName;
            }
            else
            {
                selectedFile = "";
            }
        }

        private void GetCountries(string filename)
        {
            try
            {
                string countryName;
                StreamReader inputFile;
                inputFile = File.OpenText(filename);

                countriesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }
                inputFile.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
