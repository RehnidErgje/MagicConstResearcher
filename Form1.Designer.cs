namespace MagicConstResearcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputResearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.limitB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.limitA = new System.Windows.Forms.TextBox();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.refreshResearchButton = new System.Windows.Forms.Button();
            this.deleteResearchButton = new System.Windows.Forms.Button();
            this.AddGraphButton = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Property3 = new System.Windows.Forms.TextBox();
            this.Property2 = new System.Windows.Forms.TextBox();
            this.Property1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputResearchButton
            // 
            this.inputResearchButton.Location = new System.Drawing.Point(12, 87);
            this.inputResearchButton.Name = "inputResearchButton";
            this.inputResearchButton.Size = new System.Drawing.Size(129, 29);
            this.inputResearchButton.TabIndex = 0;
            this.inputResearchButton.Text = "Створити";
            this.inputResearchButton.UseVisualStyleBackColor = true;
            this.inputResearchButton.Click += new System.EventHandler(this.CreateResearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "а =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.limitB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.limitA);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Межі обчислення";
            // 
            // limitB
            // 
            this.limitB.Location = new System.Drawing.Point(34, 50);
            this.limitB.Name = "limitB";
            this.limitB.Size = new System.Drawing.Size(84, 20);
            this.limitB.TabIndex = 4;
            this.limitB.Text = "4";
            this.limitB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b =";
            // 
            // limitA
            // 
            this.limitA.Location = new System.Drawing.Point(34, 24);
            this.limitA.Name = "limitA";
            this.limitA.Size = new System.Drawing.Size(84, 20);
            this.limitA.TabIndex = 2;
            this.limitA.Text = "0.125";
            this.limitA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitKeyPress);
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DisplayMember = "1";
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(3, 16);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(147, 21);
            this.comboBoxMethod.TabIndex = 3;
            this.comboBoxMethod.Tag = "";
            this.comboBoxMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethod_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Метод:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 649);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1456, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Research Progress";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // tabControl
            // 
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1297, 649);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 6;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlAdded);
            this.tabControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlRemoved);
            // 
            // refreshResearchButton
            // 
            this.refreshResearchButton.Enabled = false;
            this.refreshResearchButton.Location = new System.Drawing.Point(12, 157);
            this.refreshResearchButton.Name = "refreshResearchButton";
            this.refreshResearchButton.Size = new System.Drawing.Size(129, 29);
            this.refreshResearchButton.TabIndex = 7;
            this.refreshResearchButton.Text = "Обновити";
            this.refreshResearchButton.UseVisualStyleBackColor = true;
            this.refreshResearchButton.Click += new System.EventHandler(this.refreshResearch_Click);
            // 
            // deleteResearchButton
            // 
            this.deleteResearchButton.Enabled = false;
            this.deleteResearchButton.Location = new System.Drawing.Point(12, 192);
            this.deleteResearchButton.Name = "deleteResearchButton";
            this.deleteResearchButton.Size = new System.Drawing.Size(129, 29);
            this.deleteResearchButton.TabIndex = 8;
            this.deleteResearchButton.Text = "Видалити";
            this.deleteResearchButton.UseVisualStyleBackColor = true;
            this.deleteResearchButton.Click += new System.EventHandler(this.deleteResearch_Click);
            // 
            // AddGraphButton
            // 
            this.AddGraphButton.Enabled = false;
            this.AddGraphButton.Location = new System.Drawing.Point(12, 122);
            this.AddGraphButton.Name = "AddGraphButton";
            this.AddGraphButton.Size = new System.Drawing.Size(129, 29);
            this.AddGraphButton.TabIndex = 9;
            this.AddGraphButton.Text = "Додати";
            this.AddGraphButton.UseVisualStyleBackColor = true;
            this.AddGraphButton.Click += new System.EventHandler(this.AddGraph);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.groupBox1);
            this.ControlPanel.Controls.Add(this.panel1);
            this.ControlPanel.Controls.Add(this.panel2);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(1303, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(153, 649);
            this.ControlPanel.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.SaveName);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Property3);
            this.groupBox1.Controls.Add(this.Property2);
            this.groupBox1.Controls.Add(this.Property1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 368);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // SaveName
            // 
            this.SaveName.Location = new System.Drawing.Point(70, 313);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(80, 20);
            this.SaveName.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Property3
            // 
            this.Property3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Property3.Location = new System.Drawing.Point(3, 56);
            this.Property3.Name = "Property3";
            this.Property3.Size = new System.Drawing.Size(147, 20);
            this.Property3.TabIndex = 3;
            this.Property3.Visible = false;
            this.Property3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitKeyPress);
            // 
            // Property2
            // 
            this.Property2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Property2.Location = new System.Drawing.Point(3, 36);
            this.Property2.Name = "Property2";
            this.Property2.Size = new System.Drawing.Size(147, 20);
            this.Property2.TabIndex = 2;
            this.Property2.Visible = false;
            this.Property2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitKeyPress);
            // 
            // Property1
            // 
            this.Property1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Property1.Location = new System.Drawing.Point(3, 16);
            this.Property1.Name = "Property1";
            this.Property1.Size = new System.Drawing.Size(147, 20);
            this.Property1.TabIndex = 1;
            this.Property1.Visible = false;
            this.Property1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitKeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxMethod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 54);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.refreshResearchButton);
            this.panel2.Controls.Add(this.AddGraphButton);
            this.panel2.Controls.Add(this.deleteResearchButton);
            this.panel2.Controls.Add(this.inputResearchButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 227);
            this.panel2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "New name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 671);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputResearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox limitB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox limitA;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button refreshResearchButton;
        private System.Windows.Forms.Button deleteResearchButton;
        private System.Windows.Forms.Button AddGraphButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Property2;
        private System.Windows.Forms.TextBox Property1;
        private System.Windows.Forms.TextBox Property3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TextBox SaveName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;

    }
}

