using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // List to hold CellPhone objects
        

        public Form1()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.
       





        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object.
           

            // Get the phone data.
            

            // Add the CellPhone object to the List.
            

            // Add an entry to the list box.
           


            // Clear the TextBox controls.
           

            // Reset the focus.
            
        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            

            // Display the selected item's price.
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
