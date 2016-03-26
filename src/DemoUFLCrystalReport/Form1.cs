using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoUFLCrystalReport
{
    public partial class FrmPreview : Form
    {
        public FrmPreview()
        {
            InitializeComponent();
            PreviewReport();
        }

        private void PreviewReport()
        {
            // set sample data penjualan
            var listOfJual = new List<Jual>();

            listOfJual.Add(new Jual { tanggal = new DateTime(2016,3, 1), nota = "12311", total = 100000 });
            listOfJual.Add(new Jual { tanggal = new DateTime(2016,3, 5), nota = "12422", total = 202500 });
            listOfJual.Add(new Jual { tanggal = new DateTime(2016,3, 8), nota = "12533", total = 303000 });
            listOfJual.Add(new Jual { tanggal = new DateTime(2016,3, 10), nota = "12644", total = 405000 });
            listOfJual.Add(new Jual { tanggal = new DateTime(2016, 3, 12), nota = "12755", total = 506000 });

            var report = new CrNota();

            // set data source report
            report.Database.Tables["Jual"].SetDataSource(listOfJual);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
