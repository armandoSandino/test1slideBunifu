using Root.Reports;
using slide_bunifu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace slide_bunifu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Report report = new Report(new PdfFormatter());
            FontDef fd = new FontDef(report, "Helvetica");
            FontProp fp = new FontPropMM(fd, 25);
            Page page = new Page(report);
            page.AddCenteredMM(80, new RepString(fp, "Hello World!"));
            RT.ViewPDF(report, "HelloWorld.pdf");*/

            //RT.ViewPDF(new TestReport(), "ImageSample.pdf");

            //PdfPropertiesSample si = new PdfPropertiesSample();
            //si.loadData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( new Form1() );
        }
    }
}
