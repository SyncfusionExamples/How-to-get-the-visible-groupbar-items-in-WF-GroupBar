using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBar_selection
{
    public partial class Form1 : MetroForm
    {
        GroupBar groupBar1 = new GroupBar();
        public Form1()
        {
            InitializeComponent();
            groupBar1.Size = new Size(220, 300);
            groupBar1.VisualStyle = VisualStyle.Metro;
            groupBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));

            groupBar1.GroupBarItemSelected += GroupBar1_GroupBarItemSelected;

            GroupBarItem groupBarItem1 = new GroupBarItem();
            groupBarItem1.Text = "Mail";

            GroupBarItem groupBarItem2 = new GroupBarItem();
            groupBarItem2.Text = "Contacts";
            
            GroupBarItem groupBarItem3 = new GroupBarItem();
            groupBarItem3.Text = "Tasks";
            groupBarItem3.Visible = false;
            
            GroupBarItem groupBarItem4 = new GroupBarItem();
            groupBarItem4.Text = "Notes";

            groupBar1.GroupBarItems.AddRange(new GroupBarItem[] { groupBarItem1, groupBarItem2, groupBarItem3, groupBarItem4 });

            this.Controls.Add(groupBar1);
        }

        private void GroupBar1_GroupBarItemSelected(object sender, EventArgs e)
        {
            String mygroup = this.groupBar1.VisibleGroupBarItems[this.groupBar1.SelectedItem].Text;
            MessageBox.Show(mygroup);
        }
    }
}
