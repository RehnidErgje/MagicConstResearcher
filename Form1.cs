using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace MagicConstResearcher
{
    public delegate int GetProgress();
    public partial class Form1 : Form
    {
        private event GetProgress ProgressWatch;
        private Thread _workThread;
        private readonly Dictionary<int, AbstractResearcher> researchers;
        private MethodPropertyDataHandler MethodPropertyDH;

        public Form1()
        {
            InitializeComponent();
            researchers = new Dictionary<int, AbstractResearcher>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMethod.Items.Clear();
            var assembly = Assembly.GetExecutingAssembly();
            var classlist = assembly.GetTypes();
            var researchlist = from current in classlist
                               where current.BaseType != null && current.BaseType.Name == "AbstractResearcher"
                               orderby current.Name
                               select current.Name;
            foreach (var researchname in researchlist)
                comboBoxMethod.Items.Add(researchname);
            MethodPropertyDH = new MethodPropertyDataHandler("MethodPropertyData.xml");
        }

        private void refreshResearch_Click(object sender, EventArgs e)
        {
            if (_workThread == null || !_workThread.IsAlive)
            {
                ResearchPage researchPage = new ResearchPage(comboBoxMethod.Text, tabControl);
                tabControl.TabPages[tabControl.SelectedIndex].Controls.RemoveAt(0);
                tabControl.TabPages[tabControl.SelectedIndex].Controls.Add(researchPage);
                _workThread = new Thread(ResearchCreateThreadMethod);
                _workThread.Start(researchPage);
            }
        }

        private void deleteResearch_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl.TabCount > 0)
            //{
            //    comboBoxMethod.SelectedIndex = comboBoxMethod.FindString((tabControl.TabPages[tabControl.SelectedIndex].Controls[0] as ResearchPage).Title);
            //    var researchPage = tabControl.TabPages[tabControl.SelectedIndex].Controls[0] as ResearchPage;
            //    if (researchPage.Researchs.Count > 0)
            //    {
            //        limitA.Text = (researchPage.Researchs[0].limitA.ToString());
            //        limitB.Text = (researchPage.Researchs[0].limitB.ToString());
            //        return;
            //    }
            //}
            //comboBoxMethod.SelectedIndex = 0;
            //limitA.Text = "0.125";
            //limitB.Text = "4";
        }

        private void CreateResearch_Click(object sender, EventArgs e)
        {
            if (_workThread == null || !_workThread.IsAlive)
            {
                ResearchPage researchPage = new ResearchPage(comboBoxMethod.Text, tabControl);
                TabPage tabResearch = new TabPage("Research №" + (tabControl.TabCount + 1));
                tabResearch.Controls.Add(researchPage);
                tabControl.TabPages.Add(tabResearch);
                tabControl.SelectedIndex = tabControl.TabCount - 1;
                _workThread = new Thread(ResearchCreateThreadMethod);
                _workThread.Start(researchPage);
            }
        }

        private void AddGraph(object sender, EventArgs e)
        {
            if (_workThread == null || !_workThread.IsAlive)
            {
                var researchPage = (tabControl.TabPages[tabControl.SelectedIndex].Controls[0] as ResearchPage);
                _workThread = new Thread(ResearchAddThreadMethod);
                _workThread.Start(researchPage);
            }
        }

        private void TimerTick(object source, ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                toolStripProgressBar1.Value = ProgressWatch();
            }));
        }

        private void ResearchCreateThreadMethod(object input)
        {
            int index = 0;
            Invoke(new MethodInvoker(() => { index = comboBoxMethod.SelectedIndex; }));
            Timer aTimer = new Timer();
            aTimer.Elapsed += TimerTick;
            var researchPage = input as ResearchPage;
            ProgressWatch += researchers[index].GetResearchProgress;
            aTimer.Interval = 1;
            aTimer.Enabled = true;
            ResearchResult result;
            if (Property3.Text == "")
                result = researchers[index].GetResult(
                    Single.Parse(limitA.Text),
                    Single.Parse(limitB.Text),
                    Double.Parse(Property1.Text),
                    Double.Parse(Property2.Text)
                    );
            else
                result = researchers[index].GetResult(
                    Single.Parse(limitA.Text),
                    Single.Parse(limitB.Text),
                    Double.Parse(Property1.Text),
                    Double.Parse(Property2.Text),
                    Double.Parse(Property3.Text)
                    );
            Invoke(new MethodInvoker(() =>
            {
                researchPage.ResearchCreate(result);
                researchPage.GraphRefresh();
            }
            ));
            aTimer.Enabled = false;
            Invoke(new MethodInvoker(() => { toolStripProgressBar1.Value = 100; }));
            ProgressWatch -= researchers[index].GetResearchProgress;

        }
        private void ResearchAddThreadMethod(object input)
        {
            int index = 0;
            Invoke(new MethodInvoker(() => { index = comboBoxMethod.SelectedIndex; }));
            Timer aTimer = new Timer();
            aTimer.Elapsed += TimerTick;
            var researchPage = input as ResearchPage;
            ProgressWatch += researchers[index].GetResearchProgress;
            aTimer.Interval = 1;
            aTimer.Enabled = true;
            ResearchResult result = researchers[index].GetResult(
                Single.Parse(limitA.Text),
                Single.Parse(limitB.Text),
                Double.Parse(Property1.Text),
                Double.Parse(Property2.Text)
                );
            Invoke(new MethodInvoker(() =>
            {
                researchPage.ResearchAdd(result);
                researchPage.GraphRefresh();
            }
            ));
            aTimer.Enabled = false;
            Invoke(new MethodInvoker(() => { toolStripProgressBar1.Value = 100; }));
            ProgressWatch -= researchers[index].GetResearchProgress;

        }
        private void comboBoxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!researchers.ContainsKey(comboBoxMethod.SelectedIndex))
                researchers.Add(comboBoxMethod.SelectedIndex, AbstractResearcher.CreateReasearch(comboBoxMethod.Text));
            double temp;
            temp = researchers[comboBoxMethod.SelectedIndex].property1;
            if (temp == 0)
                Property1.Visible = false;
            else
            {
                Property1.Visible = true;
                Property1.Text = temp.ToString();
            }
            temp = researchers[comboBoxMethod.SelectedIndex].property2;
            if (temp == 0)
                Property2.Visible = false;
            else
            {
                Property2.Visible = true;
                Property2.Text = temp.ToString();
            }
            temp = researchers[comboBoxMethod.SelectedIndex].property3;
            if (temp == 0)
                Property3.Visible = false;
            else
            {
                Property3.Visible = true;
                Property3.Text = temp.ToString();
            }
            comboBox1.Items.Clear();
            IEnumerable<string> loadProperty =
                from element in MethodPropertyDH.PropertySetList
                where element.Value.MethodName == comboBoxMethod.SelectedItem.ToString()
                select element.Key;
            foreach (string name in loadProperty)
            {
                comboBox1.Items.Add(name);
            }
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            else
            {
                comboBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SaveName.Text == "")
            {
                MessageBox.Show("Enter Name");
                SaveName.Select();
                return;
            }
            MethodPropertyDH.AddPropertySet(SaveName.Text,
                                            Property1.Text,
                                            Property2.Text,
                                            Property3.Text,
                                            comboBoxMethod.SelectedItem.ToString());
            comboBox1.Items.Clear();
            IEnumerable<string> loadProperty =
                from element in MethodPropertyDH.PropertySetList
                where element.Value.MethodName == comboBoxMethod.SelectedItem.ToString()
                select element.Key;
            foreach (string name in loadProperty)
            {
                comboBox1.Items.Add(name);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("No save files");
                return;
            }
            var temp = MethodPropertyDH.PropertySetList[comboBox1.SelectedItem.ToString()];
            Property1.Text = temp.Property1;
            Property2.Text = temp.Property2;
            Property3.Text = temp.Property3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SaveName.Text == "")
            {
                MessageBox.Show("Enter Name");
                SaveName.Select();
                return;
            }
            MethodPropertyDH.DeletePropertySet(SaveName.Text);
            comboBox1.Items.Clear();
            IEnumerable<string> loadProperty =
                from element in MethodPropertyDH.PropertySetList
                where element.Value.MethodName == comboBoxMethod.SelectedItem.ToString()
                select element.Key;
            foreach (string name in loadProperty)
            {
                comboBox1.Items.Add(name);
            }
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            else
            {
                comboBox1.Text = "";
            }
        }

        private void tabControl_ControlAdded(object sender, ControlEventArgs e)
        {
                AddGraphButton.Enabled = true;
                refreshResearchButton.Enabled = true;
                deleteResearchButton.Enabled = true;
        }

        private void tabControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (tabControl.TabCount == 1)
            {
                AddGraphButton.Enabled = false;
                refreshResearchButton.Enabled = false;
                deleteResearchButton.Enabled = false;
            }
        }

        private void OnlyDigitKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
