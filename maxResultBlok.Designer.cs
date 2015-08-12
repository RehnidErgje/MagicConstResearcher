namespace MagicConstResearcher
{
    partial class maxResultBlok
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
            this.label1 = new System.Windows.Forms.Label();
            this.xN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xP = new System.Windows.Forms.TextBox();
            this.maxNLabel = new System.Windows.Forms.Label();
            this.maxN = new System.Windows.Forms.TextBox();
            this.maxPLabel = new System.Windows.Forms.Label();
            this.maxP = new System.Windows.Forms.TextBox();
            this.Border = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "x =";
            // 
            // xN
            // 
            this.xN.Location = new System.Drawing.Point(190, 45);
            this.xN.Name = "xN";
            this.xN.Size = new System.Drawing.Size(60, 20);
            this.xN.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "x =";
            // 
            // xP
            // 
            this.xP.Location = new System.Drawing.Point(190, 19);
            this.xP.Name = "xP";
            this.xP.Size = new System.Drawing.Size(60, 20);
            this.xP.TabIndex = 16;
            // 
            // maxNLabel
            // 
            this.maxNLabel.AutoSize = true;
            this.maxNLabel.Location = new System.Drawing.Point(8, 48);
            this.maxNLabel.Name = "maxNLabel";
            this.maxNLabel.Size = new System.Drawing.Size(38, 13);
            this.maxNLabel.TabIndex = 15;
            this.maxNLabel.Text = "min  = ";
            // 
            // maxN
            // 
            this.maxN.Location = new System.Drawing.Point(39, 45);
            this.maxN.Name = "maxN";
            this.maxN.Size = new System.Drawing.Size(124, 20);
            this.maxN.TabIndex = 14;
            // 
            // maxPLabel
            // 
            this.maxPLabel.AutoSize = true;
            this.maxPLabel.Location = new System.Drawing.Point(8, 22);
            this.maxPLabel.Name = "maxPLabel";
            this.maxPLabel.Size = new System.Drawing.Size(38, 13);
            this.maxPLabel.TabIndex = 13;
            this.maxPLabel.Text = "max = ";
            // 
            // maxP
            // 
            this.maxP.Location = new System.Drawing.Point(39, 19);
            this.maxP.Name = "maxP";
            this.maxP.Size = new System.Drawing.Size(124, 20);
            this.maxP.TabIndex = 12;
            // 
            // Border
            // 
            this.Border.Controls.Add(this.button1);
            this.Border.Controls.Add(this.maxP);
            this.Border.Controls.Add(this.label1);
            this.Border.Controls.Add(this.maxPLabel);
            this.Border.Controls.Add(this.xN);
            this.Border.Controls.Add(this.maxN);
            this.Border.Controls.Add(this.label2);
            this.Border.Controls.Add(this.maxNLabel);
            this.Border.Controls.Add(this.xP);
            this.Border.Dock = System.Windows.Forms.DockStyle.Left;
            this.Border.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(269, 84);
            this.Border.TabIndex = 20;
            this.Border.TabStop = false;
            this.Border.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Image = global::MagicConstResearcher.Properties.Resources.close_button;
            this.button1.Location = new System.Drawing.Point(250, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maxResultBlok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Border);
            this.Name = "maxResultBlok";
            this.Size = new System.Drawing.Size(275, 84);
            this.Border.ResumeLayout(false);
            this.Border.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xP;
        private System.Windows.Forms.Label maxNLabel;
        public System.Windows.Forms.TextBox maxN;
        private System.Windows.Forms.Label maxPLabel;
        private System.Windows.Forms.TextBox maxP;
        private System.Windows.Forms.GroupBox Border;
        private System.Windows.Forms.Button button1;
    }
}
