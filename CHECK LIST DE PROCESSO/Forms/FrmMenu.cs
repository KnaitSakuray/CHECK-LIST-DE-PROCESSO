using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHECK_LIST_DE_PROCESSO.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            FrmCheckList frm = new FrmCheckList();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(frm);
            this.panel1.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            FrmSmt frm = new FrmSmt();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(frm);
            this.panel1.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
    }
}
