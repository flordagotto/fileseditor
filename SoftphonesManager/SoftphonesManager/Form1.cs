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
    public partial class Form1 : Form
    {
        private string colorsPath;
        private string valuesEsPath;
        private string valuesPtPath;
        private string valuesEnPath;
        private string iconPath;

        public Form1()
        {
            InitializeComponent();
            SetPaths();
            lblColors.Text = colorsPath;
            lblEs.Text = valuesEsPath;
            lblPt.Text = valuesPtPath;
            lblEn.Text = valuesEnPath;
        }

        private void SetPaths()
        {
            var path = Service.GetPath();
            this.colorsPath = path + "\\Strings\\colors.xml";
            this.valuesEsPath = path + "\\Strings\\valuesEs.xml";
            this.valuesPtPath = path + "\\Strings\\valuesPt.xml";
            this.valuesEnPath = path + "\\Strings\\valuesEn.xml";
        }




        #region events
        private void pnlColors_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.colorsPath = files[0];
        }

        private void pnlColors_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlEs_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.valuesEsPath = files[0];
        }

        private void pnlEs_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlPt_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.valuesPtPath = files[0];
        }

        private void pnlPt_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlEn_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.valuesEnPath = files[0];
        }

        private void pnlEn_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pnlIc_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.iconPath = files[0];
        }

        private void pnlIc_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        #endregion
    }
}
