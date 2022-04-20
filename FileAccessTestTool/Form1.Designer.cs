namespace FileAccessTestTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSleepBetweenReadsMillis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartRead = new System.Windows.Forms.Button();
            this.txtReadFilenames = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReadSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReadThreads = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtSleepBetweenReadsMillis);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.btnStartRead);
            this.tabPage1.Controls.Add(this.txtReadFilenames);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtReadSize);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtReadThreads);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(798, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "milliseconds";
            // 
            // txtSleepBetweenReadsMillis
            // 
            this.txtSleepBetweenReadsMillis.Location = new System.Drawing.Point(140, 68);
            this.txtSleepBetweenReadsMillis.Margin = new System.Windows.Forms.Padding(2);
            this.txtSleepBetweenReadsMillis.Name = "txtSleepBetweenReadsMillis";
            this.txtSleepBetweenReadsMillis.Size = new System.Drawing.Size(138, 23);
            this.txtSleepBetweenReadsMillis.TabIndex = 9;
            this.txtSleepBetweenReadsMillis.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sleep between reads";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 224);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 295);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnStartRead
            // 
            this.btnStartRead.Location = new System.Drawing.Point(140, 197);
            this.btnStartRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartRead.Name = "btnStartRead";
            this.btnStartRead.Size = new System.Drawing.Size(75, 23);
            this.btnStartRead.TabIndex = 6;
            this.btnStartRead.Text = "Start";
            this.btnStartRead.UseVisualStyleBackColor = true;
            this.btnStartRead.Click += new System.EventHandler(this.btnStartRead_Click);
            // 
            // txtReadFilenames
            // 
            this.txtReadFilenames.AcceptsReturn = true;
            this.txtReadFilenames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReadFilenames.Location = new System.Drawing.Point(140, 104);
            this.txtReadFilenames.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadFilenames.Multiline = true;
            this.txtReadFilenames.Name = "txtReadFilenames";
            this.txtReadFilenames.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReadFilenames.Size = new System.Drawing.Size(644, 89);
            this.txtReadFilenames.TabIndex = 5;
            this.txtReadFilenames.Text = "R:\\Fiddy FSX Scenery - backup 2013-08-14\\zoom 17 - South East Queensland\\Scenery\\" +
    "108.bgl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "File(s)";
            // 
            // txtReadSize
            // 
            this.txtReadSize.Location = new System.Drawing.Point(140, 41);
            this.txtReadSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadSize.Name = "txtReadSize";
            this.txtReadSize.Size = new System.Drawing.Size(138, 23);
            this.txtReadSize.TabIndex = 3;
            this.txtReadSize.Text = "8,192";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Read Size";
            // 
            // txtReadThreads
            // 
            this.txtReadThreads.Location = new System.Drawing.Point(140, 14);
            this.txtReadThreads.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadThreads.Name = "txtReadThreads";
            this.txtReadThreads.Size = new System.Drawing.Size(60, 23);
            this.txtReadThreads.TabIndex = 1;
            this.txtReadThreads.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Threads";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "bytes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 567);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Title";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private TextBox txtReadThreads;
        private Label label1;
        private TabControl tabControl1;
        private Button btnStartRead;
        private TextBox txtReadFilenames;
        private Label label3;
        private TextBox txtReadSize;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtSleepBetweenReadsMillis;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}