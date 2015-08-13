namespace MagicConstResearcher
{
    partial class ResearchPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Graph = new ZedGraph.ZedGraphControl();
            this.mouselabel = new System.Windows.Forms.Label();
            this.GraphType = new System.Windows.Forms.ComboBox();
            this.GraphTypeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xAxicType = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.curseBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Graph.IsShowPointValues = false;
            this.Graph.Location = new System.Drawing.Point(3, 0);
            this.Graph.Name = "Graph";
            this.Graph.PointValueFormat = "G";
            this.Graph.Size = new System.Drawing.Size(982, 620);
            this.Graph.TabIndex = 0;
            this.Graph.MouseEnter += new System.EventHandler(this.Graph_MouseEnter);
            this.Graph.MouseLeave += new System.EventHandler(this.Graph_MouseLeave);
            this.Graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Graph_MouseMove);
            // 
            // mouselabel
            // 
            this.mouselabel.AutoSize = true;
            this.mouselabel.Location = new System.Drawing.Point(633, 573);
            this.mouselabel.Name = "mouselabel";
            this.mouselabel.Size = new System.Drawing.Size(0, 13);
            this.mouselabel.TabIndex = 1;
            // 
            // GraphType
            // 
            this.GraphType.FormattingEnabled = true;
            this.GraphType.Items.AddRange(new object[] {
            "Абсолютна похибка",
            "Відносна похибка",
            "Результат"});
            this.GraphType.Location = new System.Drawing.Point(994, 27);
            this.GraphType.Name = "GraphType";
            this.GraphType.Size = new System.Drawing.Size(286, 21);
            this.GraphType.TabIndex = 2;
            this.GraphType.SelectedIndexChanged += new System.EventHandler(this.GraphType_SelectedIndexChanged);
            // 
            // GraphTypeLabel
            // 
            this.GraphTypeLabel.AutoSize = true;
            this.GraphTypeLabel.Location = new System.Drawing.Point(995, 11);
            this.GraphTypeLabel.Name = "GraphTypeLabel";
            this.GraphTypeLabel.Size = new System.Drawing.Size(41, 13);
            this.GraphTypeLabel.TabIndex = 3;
            this.GraphTypeLabel.Text = "Графік";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(995, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Вісь Абцис";
            // 
            // xAxicType
            // 
            this.xAxicType.FormattingEnabled = true;
            this.xAxicType.Items.AddRange(new object[] {
            "Лінійна",
            "Логарифмічна"});
            this.xAxicType.Location = new System.Drawing.Point(994, 67);
            this.xAxicType.Name = "xAxicType";
            this.xAxicType.Size = new System.Drawing.Size(286, 21);
            this.xAxicType.TabIndex = 12;
            this.xAxicType.SelectedIndexChanged += new System.EventHandler(this.xAxicType_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1163, 563);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(106, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Зробити Звіт";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // curseBox
            // 
            this.curseBox.AutoScroll = true;
            this.curseBox.Location = new System.Drawing.Point(994, 94);
            this.curseBox.Name = "curseBox";
            this.curseBox.Size = new System.Drawing.Size(300, 453);
            this.curseBox.TabIndex = 15;
            // 
            // ResearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.curseBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xAxicType);
            this.Controls.Add(this.GraphTypeLabel);
            this.Controls.Add(this.GraphType);
            this.Controls.Add(this.mouselabel);
            this.Controls.Add(this.Graph);
            this.Name = "ResearchPage";
            this.Size = new System.Drawing.Size(1297, 620);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl Graph;
        private System.Windows.Forms.Label mouselabel;
        private System.Windows.Forms.ComboBox GraphType;
        private System.Windows.Forms.Label GraphTypeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox xAxicType;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FlowLayoutPanel curseBox;
    }
}
