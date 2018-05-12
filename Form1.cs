using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopTenListsFormsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListChoice_Click(object sender, EventArgs e)
        {
            //Declare a variable to hold the choice
            string choice = txtListChoice.Text;

            switch(choice)
            {
                case "1":
                    //Code forshowing cars list
                    break;
                case "2":
                    //Code for showing motorcycles
                    break;
                default:
                    MessageBox.Show("Invalid choice");
                    break;
            }


            //Decision statement
            if (txtListChoice.Text == "1")
            {
                //Show to the list of cars
            } else if (txtListChoice.Text == "2")
            {
                //Show the list of motorcycles
            }
        }
    }
}
