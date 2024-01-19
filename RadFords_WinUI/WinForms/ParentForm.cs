using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadFordsWinUI.WinForms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void staffManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StaffManagementCRUD frmStaffManagement = new StaffManagementCRUD();
            frmStaffManagement.MdiParent = this;
            frmStaffManagement.Show();
        }
    }
}
