using Syncfusion.Windows.Forms;
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
        public Form1()
        {
            InitializeComponent();
            groupBar1.GroupBarItemSelected += GroupBar1_GroupBarItemSelected;
        }

        private void GroupBar1_GroupBarItemSelected(object sender, EventArgs e)
        {
            String mygroup = this.groupBar1.VisibleGroupBarItems[this.groupBar1.SelectedItem].Text;
            MessageBox.Show(mygroup);
        }
    }
}
