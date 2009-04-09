using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SSMP
{
    public partial class FrmCalendar : Form
    {
        private Form frmParent;

        public FrmCalendar()
        {
            InitializeComponent();
        }

        public FrmCalendar(Form frmParent)
        {
            InitializeComponent();
            this.frmParent = frmParent;
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            FrmUser frmUser = (FrmUser)frmParent;
            //MessageBox.Show(e.Start + "");
            frmUser.setDOB(e.Start.ToString("dd/MM/yyyy"));
            this.Close();
        }
    }
}