using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManager.usercontrol
{
    public partial class LapphieusuachuaUserControl : UserControl
    {
      
        public LapphieusuachuaUserControl()
        {
          
            InitializeComponent();
        }

        // Only number in text box ( So luong )
        private void AddItem(string address,int x)
        {
            //get a reference to the previous existent 
            RowStyle temp = tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1];
            //increase panel rows count by one
            tableLayoutPanel1.RowCount++;
            
            //add a new RowStyle as a copy of the previous one
            tableLayoutPanel1.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            tableLayoutPanel1.Size = new System.Drawing.Size(tableLayoutPanel1.Width, tableLayoutPanel1.Height + 38);
            //add your three controls
            tableLayoutPanel1.Controls.Add(new Label() { Text = address }, 0, x);
            tableLayoutPanel1.Controls.Add(new TextBox(), 1, x);
            tableLayoutPanel1.Controls.Add(new TextBox(), 2, x);
            tableLayoutPanel1.Controls.Add(new TextBox(), 3, x);
        }
        //private void DeleteItem(int x)
        //{
        //    Control Control = tableLayoutPanel1.GetControlFromPosition(i, tableLayoutPanel1.RowCount);
        //    //tableLayoutPanel1.Controls.Remove(Control);
        //    tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowCount - 1);
        //}
        int i = 1;
        private void buttonplus_Click(object sender, EventArgs e)
        {
       
            string x = i.ToString();
            AddItem(x,i);
            i++;
        }

        private void buttondellte_Click(object sender, EventArgs e)
        {
            //DeleteItem(i);
            //i--;
        }
    }
}
