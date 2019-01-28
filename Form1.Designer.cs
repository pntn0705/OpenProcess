namespace AutoControllApplicationPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCmd = new System.Windows.Forms.Button();
            this.btnGarena = new System.Windows.Forms.Button();
            this.tbCMD = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRightMouse = new System.Windows.Forms.CheckBox();
            this.cbDoubleClick = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbClickApp = new System.Windows.Forms.TextBox();
            this.btnPts = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnPP = new System.Windows.Forms.Button();
            this.btnDevC = new System.Windows.Forms.Button();
            this.btnVS = new System.Windows.Forms.Button();
            this.btnFo4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(12, 174);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(104, 23);
            this.btnCmd.TabIndex = 0;
            this.btnCmd.Text = "CMD";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnGarena
            // 
            this.btnGarena.Location = new System.Drawing.Point(12, 145);
            this.btnGarena.Name = "btnGarena";
            this.btnGarena.Size = new System.Drawing.Size(104, 23);
            this.btnGarena.TabIndex = 1;
            this.btnGarena.Text = "Garena";
            this.btnGarena.UseVisualStyleBackColor = true;
            this.btnGarena.Click += new System.EventHandler(this.btnGarena_Click);
            // 
            // tbCMD
            // 
            this.tbCMD.Location = new System.Drawing.Point(12, 12);
            this.tbCMD.Name = "tbCMD";
            this.tbCMD.Size = new System.Drawing.Size(242, 20);
            this.tbCMD.TabIndex = 2;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(298, 58);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(111, 23);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 61);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(69, 61);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tọa độ click";
            // 
            // cbRightMouse
            // 
            this.cbRightMouse.AutoSize = true;
            this.cbRightMouse.Location = new System.Drawing.Point(126, 64);
            this.cbRightMouse.Name = "cbRightMouse";
            this.cbRightMouse.Size = new System.Drawing.Size(77, 17);
            this.cbRightMouse.TabIndex = 7;
            this.cbRightMouse.Text = "Chuột phải";
            this.cbRightMouse.UseVisualStyleBackColor = true;
            // 
            // cbDoubleClick
            // 
            this.cbDoubleClick.AutoSize = true;
            this.cbDoubleClick.Location = new System.Drawing.Point(212, 62);
            this.cbDoubleClick.Name = "cbDoubleClick";
            this.cbDoubleClick.Size = new System.Drawing.Size(85, 17);
            this.cbDoubleClick.TabIndex = 8;
            this.cbDoubleClick.Text = "Double click";
            this.cbDoubleClick.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Click vào tọa độ ứng dụng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbClickApp
            // 
            this.tbClickApp.Location = new System.Drawing.Point(16, 104);
            this.tbClickApp.Name = "tbClickApp";
            this.tbClickApp.Size = new System.Drawing.Size(238, 20);
            this.tbClickApp.TabIndex = 10;
            this.tbClickApp.Text = "Qt5QWindowIcon";
            // 
            // btnPts
            // 
            this.btnPts.Location = new System.Drawing.Point(126, 144);
            this.btnPts.Name = "btnPts";
            this.btnPts.Size = new System.Drawing.Size(90, 23);
            this.btnPts.TabIndex = 11;
            this.btnPts.Text = "Photoshop";
            this.btnPts.UseVisualStyleBackColor = true;
            this.btnPts.Click += new System.EventHandler(this.btnPts_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(126, 173);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(90, 23);
            this.btnWord.TabIndex = 12;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnPP
            // 
            this.btnPP.Location = new System.Drawing.Point(222, 145);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(75, 23);
            this.btnPP.TabIndex = 13;
            this.btnPP.Text = "PowerPoint";
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // btnDevC
            // 
            this.btnDevC.Location = new System.Drawing.Point(223, 175);
            this.btnDevC.Name = "btnDevC";
            this.btnDevC.Size = new System.Drawing.Size(75, 23);
            this.btnDevC.TabIndex = 14;
            this.btnDevC.Text = "Dev-C";
            this.btnDevC.UseVisualStyleBackColor = true;
            this.btnDevC.Click += new System.EventHandler(this.btnDevC_Click);
            // 
            // btnVS
            // 
            this.btnVS.Location = new System.Drawing.Point(304, 143);
            this.btnVS.Name = "btnVS";
            this.btnVS.Size = new System.Drawing.Size(75, 23);
            this.btnVS.TabIndex = 15;
            this.btnVS.Text = "VisualStudio";
            this.btnVS.UseVisualStyleBackColor = true;
            this.btnVS.Click += new System.EventHandler(this.btnVS_Click);
            // 
            // btnFo4
            // 
            this.btnFo4.Location = new System.Drawing.Point(304, 175);
            this.btnFo4.Name = "btnFo4";
            this.btnFo4.Size = new System.Drawing.Size(75, 23);
            this.btnFo4.TabIndex = 16;
            this.btnFo4.Text = "FO4";
            this.btnFo4.UseVisualStyleBackColor = true;
            this.btnFo4.Click += new System.EventHandler(this.btnFo4_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Out Garena";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFo4);
            this.Controls.Add(this.btnVS);
            this.Controls.Add(this.btnDevC);
            this.Controls.Add(this.btnPP);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnPts);
            this.Controls.Add(this.tbClickApp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDoubleClick);
            this.Controls.Add(this.cbRightMouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.tbCMD);
            this.Controls.Add(this.btnGarena);
            this.Controls.Add(this.btnCmd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.Button btnGarena;
        private System.Windows.Forms.TextBox tbCMD;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRightMouse;
        private System.Windows.Forms.CheckBox cbDoubleClick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbClickApp;
        private System.Windows.Forms.Button btnPts;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.Button btnDevC;
        private System.Windows.Forms.Button btnVS;
        private System.Windows.Forms.Button btnFo4;
        private System.Windows.Forms.Button button2;
    }
}

