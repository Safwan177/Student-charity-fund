using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

using StudentCharityFundBLL;
namespace student
{
    public partial class frmMonthlyReport : Form
    {
        public frmMonthlyReport()
        {
            InitializeComponent();
        }

        private void frmMonthlyReport_Load(object sender, EventArgs e)
        {
            dtpDate.MaxDate = DateTime.Now;
            dtpDate.MinDate = Convert.ToDateTime("05/2024");
        }

        private void btnIssueReport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = clsUniversityStudenBLL.GetAllUniversityStudent();
            PdfDocument doc = new PdfDocument();
            doc.Info.Title = "The Monthly Report for Month " + DateTime.Now.Month.ToString();

            XFont font = new XFont("Arial", 12);
            double margin = 40;
            double lineHeight = 20;
            double startX = margin;
            double startY = margin;

            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XPen pen = new XPen(XColors.Black, 0.5); // سمك الخط 0.5، ويمكن تغييره

            // رسم رؤوس الأعمدة
            for (int col = 0; col < dt.Columns.Count; col++)
            {
                gfx.DrawString(dt.Columns[col].ColumnName, font, XBrushes.Black,
                                        new XRect(startX + col * 120 + 5, startY, 120 - 5, lineHeight),
                                        XStringFormats.CenterLeft);

                double x = startX + col * 120;
                gfx.DrawLine(pen, x, startY, x, startY + lineHeight);


            }
            gfx.DrawLine(pen, startX, startY + lineHeight, startX + dt.Columns.Count * 120, startY + lineHeight);

            startY += lineHeight;


            // طباعة الصفوف
            foreach (DataRow row in dt.Rows)
            {
                // تحقق هل المساحة انتهت؟
                if (startY + lineHeight > page.Height - margin)
                {
                    // افتح صفحة جديدة
                    page = doc.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    startY = margin;

                    // إعادة رسم رؤوس الأعمدة في الصفحة الجديدة
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        gfx.DrawString(dt.Columns[col].ColumnName, font, XBrushes.Black,
                                       new XRect(startX + col * 120, startY, 120, lineHeight),
                                       XStringFormats.CenterLeft);
                        double x = startX + col * 120;
                        gfx.DrawLine(pen, x, startY, x, startY + lineHeight);

                    }

                    startY += lineHeight;
                }

                // رسم البيانات
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    gfx.DrawString(row[col].ToString(), font, XBrushes.Black,
    new XRect(startX + col * 120 + 5, startY, 120 - 5, lineHeight),
    XStringFormats.CenterLeft);
                    double x = startX + col * 120;
                    gfx.DrawLine(pen, x, startY, x, startY + lineHeight);

                }
                gfx.DrawLine(pen, startX, startY + lineHeight, startX + dt.Columns.Count * 120, startY + lineHeight);


                startY += lineHeight;
            }

            // حفظ الملف
            string filename = "تقرير_شهري.pdf";
            doc.Save(filename);
            Process.Start(filename);
        }
    }
}
