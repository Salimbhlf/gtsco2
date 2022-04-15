using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows;

namespace gtsco2.forms.PVfinal.raporetPv
{
    public partial class relver_final_globale : DevExpress.XtraReports.UI.XtraReport
    {
        public relver_final_globale()
        {
            InitializeComponent();
        }
        public static void print  (DataTable dt){
            relver_final_globale rpt = new relver_final_globale();
            rpt.DataSource = dt;

            rpt.load(dt);

            rpt.ShowRibbonPreview();
            }

        public void load(DataTable dt)
        {
            try
            {
                try
                {
                    xrTableCell4.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "OPS"));
                    xrTableCell3.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "MG"));
                    xrTableCell6.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Nom_Et_Prnom"));

                    //xrTableCell1.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", dt.Columns[2].ColumnName));
                    xrTableCell1.DataBindings.Add("Text", this.DataSource, dt.Columns[2].ColumnName.ToString());

                }
                catch { }
                try { xrTableCellT1.Text = dt.Columns[2].ColumnName.ToString(); } catch { }
                for (int i = 3; i <= (dt.Columns.Count - 3); i++)
                {
                    try
                    {
                        XRTableCell xrTableCell2 = new XRTableCell();
                        xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
               xrTableCell2});
                        xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
                        xrTableCell2.Multiline = true;
                        xrTableCell2.DataBindings.Add("Text", this.DataSource, dt.Columns[i].ColumnName.ToString());
                        xrTableCell2.Name = "r" + i;
                        xrTableCell2.StylePriority.UseBorders = false;
                        xrTableCell2.StylePriority.UseTextAlignment = false;
                        //xrTableCell2.Text = dt.Columns[i].ColumnName;
                        xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
                        xrTableCell2.Weight = 1D;

                    }
                    catch { }

                    try
                    {

                        XRTableCell xrTableCellT = new XRTableCell();
                        xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
               xrTableCellT});
                        xrTableCellT.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                   | DevExpress.XtraPrinting.BorderSide.Right)
                   | DevExpress.XtraPrinting.BorderSide.Bottom)));
                        xrTableCellT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        xrTableCellT.Multiline = true;
                        xrTableCellT.Name = "xrTableCell2";
                        xrTableCellT.StylePriority.UseBorders = false;
                        xrTableCellT.StylePriority.UseFont = false;
                        xrTableCellT.StylePriority.UseTextAlignment = false;
                        xrTableCellT.Text = dt.Columns[i].ColumnName.ToString();
                        xrTableCellT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                        xrTableCellT.Weight = 1D;
                    }
                    catch { }


                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
