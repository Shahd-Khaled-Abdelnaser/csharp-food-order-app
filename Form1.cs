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

namespace WindowsFormsApp_shahdkhaled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                nametextBox.Focus();
                string name = nametextBox.Text;
                Boolean flag = true;
                if(name== "")
                {
                    flag = false;
                    MessageBox.Show("please enter name");
                    nametextBox.Focus();
                } decimal total = 0m;
                string food = "";
                if (listBox1.SelectedIndex !=-1)
                {
                    food = listBox1.SelectedItem.ToString();
                    total += 100;
                }
                else
                {
                    MessageBox.Show("please select item");
                    flag = false;
                }
                string size = "";
                if (smallradioButton.Checked)
                {
                    size = smallradioButton.Text;
                    total += 20;
                }
                else if (largeradioButton.Checked)
                {
                    size= largeradioButton.Text;
                    total += 50;
                }
                else
                {
                    MessageBox.Show("please select size");
                    flag = false;
                } string extra = "";
                if(cheesecheckBox.Checked)
                { 
                    extra += cheesecheckBox.Text +" ";
                    total += 10;
                }
                if(saucecheckBox.Checked)
                {
                    extra += saucecheckBox.Text+ " ";
                    total += 15;
                }
                if(extra== "")
                {
                    extra = "no extra";
                }
                if(flag)
                {
                    totallabel.Text= "name:" + name + "  food:" + food + "  size:" + size + "  extra:" + extra + "  total:" + total.ToString("c");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
