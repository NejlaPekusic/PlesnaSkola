using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Pravdanja
{
    public partial class frmPravdanjePrint : Form
    {
        private readonly Model.Pravdanja pravdanje;

        public frmPravdanjePrint(Model.Pravdanja pravdanje)
        {
            InitializeComponent();
            this.pravdanje = pravdanje;
        }

        private void frmPravdanjePrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumOd", this.pravdanje.DatumOd.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumDo", this.pravdanje.DatumDo.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumIzdavanja", this.pravdanje.DatumIzdavanja.Value.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Svrha", this.pravdanje.Opis));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Voditelj", APIService.PrijavljeniKorisnik.ImePrezime));
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_ReportExport(object sender, Microsoft.Reporting.WinForms.ReportExportEventArgs e)
        {
           
        }
    }
}
