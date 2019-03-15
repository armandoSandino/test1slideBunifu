using Root.Reports;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slide_bunifu
{
    class TestReport : Report
    {
        protected override void Create()
        {
            FontDef fd = new FontDef(this, "Arial");
            FontProp fp = new FontPropMM(fd, 2.1);
            FontProp fp_Title = new FontPropMM(fd, 18);
            fp_Title.bBold = true;
            BrushProp bp = new BrushProp(this, System.Drawing.Color.LightGray);
            PenProp pp = new PenProp(this, 0.2, Color.FromArgb(235, 235, 235));

            new Page(this);
            Double rY = 40;
            //exception
            page_Cur.AddCenteredMM(rY, new RepString(fp_Title, "Image Sample"));
            fp_Title.rSizeMM = 4;

            System.IO.Stream stream = GetType().Assembly.GetManifestResourceStream("ReportSamples.Image.jpg");

            page_Cur.AddMM(20, 90, new RepImageMM(stream, 40, Double.NaN));
            page_Cur.AddMM(20, 95, new RepString(fp, "W = 40mm, H = auto."));
            page_Cur.AddMM(67, 90, new RepImageMM(stream, 40, 20));
            page_Cur.AddMM(67, 95, new RepString(fp, "W = 40mm, H = 20mm"));
            page_Cur.AddMM(114, 90, new RepImageMM(stream, Double.NaN, 30));
            page_Cur.AddMM(114, 95, new RepString(fp, "W = auto., H = 30mm"));
            page_Cur.AddMM(161, 90, new RepImageMM(stream, 30, 30));
            page_Cur.AddMM(161, 95, new RepString(fp, "W = 30mm, H = 30mm"));
            rY += 150;

            // adjust the size of a bounding rectangle
            RepRect dr = new RepRectMM(bp, 80, 60);
            page_Cur.AddMM(20, rY, dr);
            RepImage di = new RepImageMM(stream, 70, Double.NaN);
            page_Cur.AddMM(25, rY - 5, di);
            dr.rHeightMM = di.rHeightMM + 10;

            // rotated image
            di = new RepImageMM(stream, 40, 30);
            di.RotateTransform(-15);
            page_Cur.AddMM(120, rY - 33, di);

            // rotated image with rectangle
            StaticContainer sc = new StaticContainer(RT.rMM(45), RT.rMM(35));
            page_Cur.AddMM(145, rY - 35, sc);
            sc.RotateTransform(15);
            sc.AddMM(0, 35, new RepRectMM(bp, 45, 35));
            sc.AddMM(1.25, 33.75, new RepLineMM(pp, 42.5, 0));
            sc.AddMM(1.25, 1.25, new RepLineMM(pp, 42.5, 0));
            sc.AddAlignedMM(22.5, RepObj.rAlignCenter, 17.5, RepObj.rAlignCenter, new RepImageMM(stream, 40, 30));
            rY += 30;

            // alignment sample
            page_Cur.AddMM(20, rY, new RepString(fp_Title, "Alignment"));
            rY += 18;
            Int32 rX = 100;
            Double rD = 20;
            bp.color = Color.DarkSalmon;
            page_Cur.AddMM(rX, rY + rD, new RepRectMM(bp, rD, rD));
            page_Cur.AddAlignedMM(rX, RepObj.rAlignRight, rY, RepObj.rAlignBottom, new RepImageMM(stream, 20, Double.NaN));
            page_Cur.AddAlignedMM(rX, RepObj.rAlignRight, rY + rD, RepObj.rAlignTop, new RepImageMM(stream, 20, Double.NaN));
            page_Cur.AddMM(rX + rD, rY, new RepImageMM(stream, 20, Double.NaN));  // default
            page_Cur.AddAlignedMM(rX + rD, RepObj.rAlignLeft, rY + rD, RepObj.rAlignTop, new RepImageMM(stream, 20, Double.NaN));
            page_Cur.AddAlignedMM(rX + rD / 2, RepObj.rAlignCenter, rY + rD / 2, RepObj.rAlignCenter, new RepImageMM(stream, 10, Double.NaN));
        }


    }
}
