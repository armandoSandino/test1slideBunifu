using Root.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slide_bunifu
{
   public class PdfPropertiesSample : Report {
        public PdfPropertiesSample()
        {
        }

        public PdfPropertiesSample(Root.Reports.Formatter formatter) : base(formatter)
        {
        }
        public void loadData() {
            PdfFormatter pf = new PdfFormatter();
            pf.sTitle = "PDF Sample";
            pf.sAuthor = "Otto Mayer, mot@root.ch";
            pf.sSubject = "Sample of some PDF features";
            pf.sKeywords = "Sample PDF RSF";
            pf.sCreator = "RSF Sample Application";
            pf.dt_CreationDate = new DateTime(2002, 8, 15, 0, 0, 0, 0);
            pf.pageLayout = PageLayout.TwoColumnLeft;
            pf.bHideToolBar = true;
            pf.bHideMenubar = false;
            pf.bHideWindowUI = true;
            pf.bFitWindow = true;
            pf.bCenterWindow = true;
            pf.bDisplayDocTitle = true;

            RT.ViewPDF(new PdfPropertiesSample(pf), "PdfPropertiesSample.pdf");

        }
     protected override void Create()
        {
            FontDef fd = new FontDef(this, "Helvetica");
            FontProp fp = new FontPropMM(fd, 4);
            FontProp fp_Title = new FontPropMM(fd, 11);
            fp_Title.bBold = true;

            Page page = new Page(this);
            page.AddCenteredMM(40, new RepString(fp_Title, "PDF Properties Sample"));
            fp_Title.rSizeMM = 8;
            page.AddCenteredMM(100, new RepString(fp_Title, "First Page"));
            page.AddCenteredMM(120, new RepString(fp, "Choose <Document Properties, Summary> from the"));
            page.AddCenteredMM(126, new RepString(fp, "File menu to display the document properties"));

            page = new Page(this);
            page.AddCenteredMM(100, new RepString(fp_Title, "Second Page"));
        }

    }
}

