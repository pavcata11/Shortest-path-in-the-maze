namespace WindowsFormsApp5
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
            this.btnStepByStep = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnShowDistance = new System.Windows.Forms.Button();
            this.btnShowShortestPath = new System.Windows.Forms.Button();
            this.lblMainInformation = new System.Windows.Forms.Label();
            this.lblShowDistance = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lnlInformation = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStepByStep
            // 
            this.btnStepByStep.Location = new System.Drawing.Point(668, 206);
            this.btnStepByStep.Name = "btnStepByStep";
            this.btnStepByStep.Size = new System.Drawing.Size(127, 31);
            this.btnStepByStep.TabIndex = 2;
            this.btnStepByStep.Text = "Step-by-step";
            this.btnStepByStep.UseVisualStyleBackColor = true;
            this.btnStepByStep.Click += new System.EventHandler(this.btnStepByStep_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(673, 151);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dijkstra";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnShowDistance
            // 
            this.btnShowDistance.Location = new System.Drawing.Point(669, 242);
            this.btnShowDistance.Name = "btnShowDistance";
            this.btnShowDistance.Size = new System.Drawing.Size(127, 31);
            this.btnShowDistance.TabIndex = 5;
            this.btnShowDistance.Text = "Show distance";
            this.btnShowDistance.UseVisualStyleBackColor = true;
            this.btnShowDistance.Click += new System.EventHandler(this.btnShowDistance_Click);
            // 
            // btnShowShortestPath
            // 
            this.btnShowShortestPath.Location = new System.Drawing.Point(669, 279);
            this.btnShowShortestPath.Name = "btnShowShortestPath";
            this.btnShowShortestPath.Size = new System.Drawing.Size(127, 46);
            this.btnShowShortestPath.TabIndex = 6;
            this.btnShowShortestPath.Text = "Show shortest path";
            this.btnShowShortestPath.UseVisualStyleBackColor = true;
            this.btnShowShortestPath.Click += new System.EventHandler(this.btnShowShortestPath_Click);
            // 
            // lblMainInformation
            // 
            this.lblMainInformation.AutoSize = true;
            this.lblMainInformation.Location = new System.Drawing.Point(608, 29);
            this.lblMainInformation.Name = "lblMainInformation";
            this.lblMainInformation.Size = new System.Drawing.Size(270, 34);
            this.lblMainInformation.TabIndex = 7;
            this.lblMainInformation.Text = "Drag with click button mouse - Create wall\r\nClick left or rigth - Path";
            // 
            // lblShowDistance
            // 
            this.lblShowDistance.AutoSize = true;
            this.lblShowDistance.Location = new System.Drawing.Point(802, 249);
            this.lblShowDistance.Name = "lblShowDistance";
            this.lblShowDistance.Size = new System.Drawing.Size(0, 17);
            this.lblShowDistance.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(755, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(59, 31);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lnlInformation
            // 
            this.lnlInformation.AutoSize = true;
            this.lnlInformation.ForeColor = System.Drawing.Color.Maroon;
            this.lnlInformation.Location = new System.Drawing.Point(681, 180);
            this.lnlInformation.Name = "lnlInformation";
            this.lnlInformation.Size = new System.Drawing.Size(155, 17);
            this.lnlInformation.TabIndex = 10;
            this.lnlInformation.Text = "Algoritum ready for use";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(668, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 31);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(668, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 31);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(741, 88);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(805, 88);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown2.TabIndex = 15;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(741, 116);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown3.TabIndex = 17;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(805, 118);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Start pos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "End pos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lnlInformation);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblShowDistance);
            this.Controls.Add(this.lblMainInformation);
            this.Controls.Add(this.btnShowShortestPath);
            this.Controls.Add(this.btnShowDistance);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnStepByStep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MazeRunner game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStepByStep;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnShowDistance;
        private System.Windows.Forms.Button btnShowShortestPath;
        private System.Windows.Forms.Label lblMainInformation;
        private System.Windows.Forms.Label lblShowDistance;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lnlInformation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

