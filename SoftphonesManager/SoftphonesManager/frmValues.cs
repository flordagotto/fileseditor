using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftphonesManager
{
    public partial class frmValues : Form
    {
        public string colorPrimary = "";
        public string colorAccent = "";
        public string nameEs = "";
        public string websiteEs = "";
        public string nameEn = "";
        public string websiteEn = "";
        public string namePt = "";
        public string websitePt = "";

        public frmValues()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtPrimary.Text == "" || txtAccent.Text == "" || txtNameEs.Text == "" || txtWebPt.Text == ""
                || txtNameEn.Text == "" || txtNamePt.Text == "" || txtWebEn.Text == "" || txtWebEs.Text == "")
                return;

            colorPrimary = txtPrimary.Text;
            colorAccent = txtAccent.Text;
            nameEs = txtNameEs.Text;
            websiteEs = txtWebEs.Text;
            nameEn = txtNameEn.Text;
            websiteEn = txtWebEn.Text;
            namePt = txtNamePt.Text;
            websitePt = txtWebPt.Text;

            this.Dispose();
        }

    }
}
