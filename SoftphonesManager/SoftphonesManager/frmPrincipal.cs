using SoftphonesManager.FilesManager;
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
    public partial class frmPrincipal : Form
    {
        private string colorsPath;
        private string valuesEsPath;
        private string valuesPtPath;
        private string valuesEnPath;
        private string iconPath;

        public frmPrincipal()
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

        private void SetLabels()
        {
            lblColors.Text = colorsPath;
            lblEs.Text = valuesEsPath;
            lblPt.Text = valuesPtPath;
            lblEn.Text = valuesEnPath;
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

        private void chMantener_CheckedChanged(object sender, EventArgs e)
        {
            if (chMantener.Checked)
            {
                SetPaths();
                SetLabels();
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var formValues = new frmValues();
            formValues.ShowDialog();

            string client = txtCliente.Text;

            var cManager = new ColorsManager(formValues.colorPrimary, formValues.colorAccent);
            cManager.ModifyFile(colorsPath, client);

            var valuesEs = new Dictionary<string, string>();
            var valuesEn = new Dictionary<string, string>();
            var valuesPt = new Dictionary<string, string>();

            valuesEs.Add("app_name", formValues.nameEs);
            valuesEs.Add("website", formValues.websiteEs);
            
            valuesEn.Add("app_name", formValues.nameEn);
            valuesEn.Add("website", formValues.websiteEn);
            
            valuesPt.Add("app_name", formValues.namePt);
            valuesPt.Add("website", formValues.websitePt);

            /*
             values
             values-es-rAR
             values-pt-rBR
            */

            var vManager = new ValuesManager();
            vManager.ModifyFile(valuesEsPath, valuesEs, "values-es-rAR", client);
            vManager.ModifyFile(valuesEnPath, valuesEn, "values", client);
            vManager.ModifyFile(valuesPtPath, valuesPt, "values-pt-rBR", client);

            var icGenerator = new IconGenerator(iconPath);
            iconPath = icGenerator.GetConvertedPNGFile();

            var icons = new Dictionary<string, int>();
            icons.Add("mipmap-hdpi", 72);
            icons.Add("mipmap-mdpi", 48);
            icons.Add("mipmap-xhdpi", 96);
            icons.Add("mipmap-xxhdpi", 144);
            icons.Add("mipmap-xxxhdpi", 192);
            icons.Add("drawable-nodpi", 512);

            foreach (var item in icons)
            {
                icGenerator.resizeImage(iconPath, item.Value, item.Key);
            }
        }
    }
}
