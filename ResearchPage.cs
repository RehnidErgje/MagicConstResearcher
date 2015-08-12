using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using ZedGraph;
using Application = Microsoft.Office.Interop.Word.Application;

namespace MagicConstResearcher
{
    public partial class ResearchPage : UserControl
    {
        private TabControl parent;
        public int Count { get; private set; }
        public double[] X;
        public List<double[]> Y = new List<double[]>();
        public List<double[]> AbsoluteError = new List<double[]>();
        public List<double[]> RelativeError = new List<double[]>();
        public List<string> names = new List<string>();

    private readonly Color[] colors = new Color[]
        {
            Color.Red, Color.Blue, Color.Green, Color.DarkViolet, Color.DeepPink, 
            Color.OrangeRed, Color.Olive, Color.Yellow
        };
        private List<maxResultBlok> maxresult = new List<maxResultBlok>();
        private GraphPane pane;
        public string Title;
        public ResearchPage(string title,TabControl _parent)
        {
            InitializeComponent();
            Title = title;
            pane = Graph.GraphPane;
            pane.XAxis.Title = "x";
            pane.XAxis.IsShowGrid = true;
            pane.YAxis.IsShowGrid = true;
            GraphType.SelectedIndex = 1;
            xAxicType.SelectedIndex = 0;
            Count = 0;
            parent = _parent;
        }

        public void GraphRefresh()
        {
            if (Y.Count > 0)
            {
                switch (GraphType.SelectedIndex)
                {
                    case 0: pane.YAxis.Title = "Δx"; break;
                    case 1: pane.YAxis.Title = "δx"; break;
                    case 2: pane.YAxis.Title = "y"; break;
                }
                Graph.AxisChange();
                double scale = pane.YAxis.Max;
                for (int i = 0; i < 20; i++)
                    if (scale < 1)
                    {
                        scale *= 10;
                    }
                    else
                    {
                        pane.YAxis.ScaleMag = -i; break;
                    }
                pane.Title = Title;
                Graph.AxisChange();
                Graph.Invalidate();
                pane.Title = names[0];
                for (int i = 1; i < names.Count; i++)
                {
                    pane.Title += " & " + names[i];
                }
            }
        }
        public void GraphAdd(int i)
        {
            switch (GraphType.SelectedIndex)
            {
                case 0: pane.AddCurve(names[i], X, AbsoluteError[i], colors[i], SymbolType.None); break;
                case 1: pane.AddCurve(names[i], X, RelativeError[i], colors[i], SymbolType.None); break;
                case 2: pane.AddCurve(names[i], X, Y[i], colors[i], SymbolType.None); break;
            }
        }
        public void ResearchAdd(ResearchResult input)
        {
            Y.Add(input.Y);
            AbsoluteError.Add(input.AbsoluteError);
            RelativeError.Add(input.RelativeError);
            names.Add(input.Name);
            GraphAdd(Count);
            maxresult.Add(new maxResultBlok(
                                    input.Name,
                                    pane.CurveList[pane.CurveList.Count - 1].Color,
                                    input.xmax,
                                    input.xmin,
                                    input.max,
                                    input.min,
                                    this)
                                 );
            maxresult.Last().index = maxresult.Count - 1;
            curseBox.Controls.Add(maxresult.Last());
            Count++;
        }

        public void ResearchRemove(int index)
        {
            if (curseBox.Controls.Count == 1)
            {
                parent.TabPages.RemoveAt(parent.SelectedIndex);
            }
            pane.CurveList.RemoveAt(index);
            Y.RemoveAt(index);
            AbsoluteError.RemoveAt(index);
            RelativeError.RemoveAt(index);
            names.RemoveAt(index);
            maxresult.RemoveAt(index);
            curseBox.Controls.RemoveAt(index);
            Count--;
            GraphRefresh();
            for (int i = 0; i < maxresult.Count; i++)
                maxresult[i].index = i;
        }

        public void ResearchCreate(ResearchResult input)
        {
            X = input.X;
            pane.XAxis.Min = X[0];
            pane.XAxis.Max = X[X.Length - 1];
            ResearchAdd(input);
        }
        private void GraphType_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if(Count>0)
                {
                    pane.CurveList.Clear();
                    for (int i = 0; i < Count; i++)
                        GraphAdd(i);
                    GraphRefresh();
                }
            }

        }
        private void xAxicType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Count > 0)
            {
                switch (xAxicType.SelectedIndex)
                {
                    case 0: Graph.GraphPane.XAxis.Type = AxisType.Linear; break;
                    case 1: Graph.GraphPane.XAxis.Type = AxisType.Log; break;
                }
                GraphRefresh();
            }
        }

        private void Save(object sender, EventArgs e)
        {
            Graph.Image.Save(@"Result\" + pane.Title + ".png");
            Application app = new Application();
            Document doc = app.Documents.Add(Visible: true);
            Paragraph paragraph = doc.Paragraphs.First;
            doc.Paragraphs.Add();
            Table table = doc.Range().Tables.Add(paragraph.Range, names.Count + 1, 3);
            table.Borders.Enable = 1;
            foreach (Row row in table.Rows)
            {
                if (row.Index == 1)
                {
                    row.Cells[1].Range.Text = "Метод";
                    row.Cells[2].Range.Text = "Max";
                    row.Cells[3].Range.Text = "Min";
                    foreach (Cell cell in row.Cells)
                    {
                        cell.Range.Font.Name = "Calibri";
                        cell.Range.Font.Size = 11;
                    }
                }
                else
                {
                    row.Cells[1].Range.Text = names[row.Index-2];
                    row.Cells[2].Range.Text = maxresult[row.Index - 2].max;
                    row.Cells[3].Range.Text = maxresult[row.Index - 2].min;
                    foreach (Cell cell in row.Cells)
                    {
                        cell.Range.Font.Name = "Calibri";
                        cell.Range.Font.Size = 11;
                    }
                }
            }
            paragraph = doc.Paragraphs[1];
            object f = false;
            object t = true;
            object range = paragraph.Range;
            
            doc.InlineShapes.AddPicture(Path.GetFullPath(@"Result\" + pane.Title + ".png"), ref f, ref t, ref range);
            doc.Save();
            doc.Close();
            app.Quit();
        }
        private void Graph_MouseMove(object sender, MouseEventArgs e)
        {
            double x, y, y2;
            Graph.GraphPane.ReverseTransform(e.Location, out x, out y, out y2);
            string text = string.Format("X: {0:F10};\tY: {1:E10}", x, y);
            mouselabel.Text = text;

        }

        private void Graph_MouseEnter(object sender, EventArgs e)
        {
            mouselabel.Visible = true;
        }

        private void Graph_MouseLeave(object sender, EventArgs e)
        {
            mouselabel.Visible = false;
        }
    }
}
