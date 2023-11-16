namespace ISA_1
{
    partial class ISA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonStart = new Button();
            labelA = new Label();
            inputA = new TextBox();
            inputB = new TextBox();
            inputN = new TextBox();
            dropdownD = new ComboBox();
            labelB = new Label();
            labelD = new Label();
            labelN = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            groupBoxHeader = new GroupBox();
            generationsTime = new Label();
            checkboxElite = new CheckBox();
            label3 = new Label();
            inputT = new TextBox();
            label2 = new Label();
            inputPM = new TextBox();
            label1 = new Label();
            inputPK = new TextBox();
            labelSignature = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView2 = new DataGridView();
            Lp = new DataGridViewTextBoxColumn();
            xReal = new DataGridViewTextBoxColumn();
            xBin = new DataGridViewTextBoxColumn();
            fX = new DataGridViewTextBoxColumn();
            percentage = new DataGridViewTextBoxColumn();
            buttonTests = new Button();
            dataGridView3 = new DataGridView();
            testLp = new DataGridViewTextBoxColumn();
            testN = new DataGridViewTextBoxColumn();
            testPk = new DataGridViewTextBoxColumn();
            testPM = new DataGridViewTextBoxColumn();
            testT = new DataGridViewTextBoxColumn();
            testAVG = new DataGridViewTextBoxColumn();
            isTestLoading = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(743, 15);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(43, 23);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(21, 18);
            labelA.Name = "labelA";
            labelA.Size = new Size(13, 15);
            labelA.TabIndex = 1;
            labelA.Text = "a";
            // 
            // inputA
            // 
            inputA.Location = new Point(40, 16);
            inputA.Name = "inputA";
            inputA.Size = new Size(56, 23);
            inputA.TabIndex = 2;
            inputA.Text = "-4";
            // 
            // inputB
            // 
            inputB.Location = new Point(130, 16);
            inputB.Name = "inputB";
            inputB.Size = new Size(61, 23);
            inputB.TabIndex = 3;
            inputB.Text = "12";
            // 
            // inputN
            // 
            inputN.Location = new Point(353, 15);
            inputN.Name = "inputN";
            inputN.Size = new Size(64, 23);
            inputN.TabIndex = 4;
            inputN.Text = "50";
            // 
            // dropdownD
            // 
            dropdownD.DropDownStyle = ComboBoxStyle.DropDownList;
            dropdownD.FormattingEnabled = true;
            dropdownD.Items.AddRange(new object[] { "0,1", "0,01", "0,001", "0,0001" });
            dropdownD.Location = new Point(227, 15);
            dropdownD.Name = "dropdownD";
            dropdownD.Size = new Size(84, 23);
            dropdownD.TabIndex = 5;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(110, 19);
            labelB.Name = "labelB";
            labelB.Size = new Size(14, 15);
            labelB.TabIndex = 6;
            labelB.Text = "b";
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Location = new Point(207, 19);
            labelD.Name = "labelD";
            labelD.Size = new Size(14, 15);
            labelD.TabIndex = 7;
            labelD.Text = "d";
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Location = new Point(331, 19);
            labelN.Name = "labelN";
            labelN.Size = new Size(16, 15);
            labelN.TabIndex = 8;
            labelN.Text = "N";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16 });
            dataGridView1.Location = new Point(821, 719);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(67, 52);
            dataGridView1.TabIndex = 9;
            dataGridView1.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "lp";
            Column1.Name = "Column1";
            Column1.Width = 42;
            // 
            // Column2
            // 
            Column2.HeaderText = "xreal";
            Column2.Name = "Column2";
            Column2.Width = 57;
            // 
            // Column3
            // 
            Column3.HeaderText = "fx";
            Column3.Name = "Column3";
            Column3.Width = 42;
            // 
            // Column4
            // 
            Column4.HeaderText = "gx";
            Column4.Name = "Column4";
            Column4.Width = 45;
            // 
            // Column5
            // 
            Column5.HeaderText = "pi";
            Column5.Name = "Column5";
            Column5.Width = 42;
            // 
            // Column6
            // 
            Column6.HeaderText = "qi";
            Column6.Name = "Column6";
            Column6.Width = 42;
            // 
            // Column7
            // 
            Column7.HeaderText = "r";
            Column7.Name = "Column7";
            Column7.Width = 36;
            // 
            // Column8
            // 
            Column8.HeaderText = "xreal";
            Column8.Name = "Column8";
            Column8.Width = 57;
            // 
            // Column9
            // 
            Column9.HeaderText = "xbin";
            Column9.Name = "Column9";
            Column9.Width = 55;
            // 
            // Column10
            // 
            Column10.HeaderText = "rodzice";
            Column10.Name = "Column10";
            Column10.Width = 70;
            // 
            // Column11
            // 
            Column11.HeaderText = "pc";
            Column11.Name = "Column11";
            Column11.Width = 45;
            // 
            // Column12
            // 
            Column12.HeaderText = "pokolenie";
            Column12.Name = "Column12";
            Column12.Width = 84;
            // 
            // Column13
            // 
            Column13.HeaderText = "zmutowane";
            Column13.Name = "Column13";
            Column13.Width = 94;
            // 
            // Column14
            // 
            Column14.HeaderText = "xbin po mutacji";
            Column14.Name = "Column14";
            Column14.Width = 106;
            // 
            // Column15
            // 
            Column15.HeaderText = "xreal";
            Column15.Name = "Column15";
            Column15.Width = 57;
            // 
            // Column16
            // 
            Column16.HeaderText = "fx";
            Column16.Name = "Column16";
            Column16.Width = 42;
            // 
            // groupBoxHeader
            // 
            groupBoxHeader.Controls.Add(generationsTime);
            groupBoxHeader.Controls.Add(checkboxElite);
            groupBoxHeader.Controls.Add(label3);
            groupBoxHeader.Controls.Add(inputT);
            groupBoxHeader.Controls.Add(label2);
            groupBoxHeader.Controls.Add(inputPM);
            groupBoxHeader.Controls.Add(label1);
            groupBoxHeader.Controls.Add(inputPK);
            groupBoxHeader.Controls.Add(labelN);
            groupBoxHeader.Controls.Add(buttonStart);
            groupBoxHeader.Controls.Add(labelA);
            groupBoxHeader.Controls.Add(labelD);
            groupBoxHeader.Controls.Add(inputA);
            groupBoxHeader.Controls.Add(labelB);
            groupBoxHeader.Controls.Add(inputB);
            groupBoxHeader.Controls.Add(dropdownD);
            groupBoxHeader.Controls.Add(inputN);
            groupBoxHeader.ForeColor = SystemColors.ControlText;
            groupBoxHeader.Location = new Point(248, 12);
            groupBoxHeader.Name = "groupBoxHeader";
            groupBoxHeader.Size = new Size(917, 54);
            groupBoxHeader.TabIndex = 10;
            groupBoxHeader.TabStop = false;
            // 
            // generationsTime
            // 
            generationsTime.AutoSize = true;
            generationsTime.Location = new Point(804, 24);
            generationsTime.Name = "generationsTime";
            generationsTime.Size = new Size(0, 15);
            generationsTime.TabIndex = 16;
            // 
            // checkboxElite
            // 
            checkboxElite.AutoSize = true;
            checkboxElite.Location = new Point(671, 18);
            checkboxElite.Name = "checkboxElite";
            checkboxElite.Size = new Size(48, 19);
            checkboxElite.TabIndex = 15;
            checkboxElite.Text = "Elite";
            checkboxElite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 20);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 14;
            label3.Text = "T";
            // 
            // inputT
            // 
            inputT.Location = new Point(613, 15);
            inputT.Name = "inputT";
            inputT.Size = new Size(40, 23);
            inputT.TabIndex = 13;
            inputT.Text = "100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(511, 19);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 12;
            label2.Text = "pm";
            // 
            // inputPM
            // 
            inputPM.Location = new Point(542, 15);
            inputPM.Name = "inputPM";
            inputPM.Size = new Size(40, 23);
            inputPM.TabIndex = 11;
            inputPM.Text = "0.005";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 19);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 10;
            label1.Text = "pk";
            // 
            // inputPK
            // 
            inputPK.Location = new Point(455, 15);
            inputPK.Name = "inputPK";
            inputPK.Size = new Size(43, 23);
            inputPK.TabIndex = 9;
            inputPK.Text = "0.85";
            // 
            // labelSignature
            // 
            labelSignature.AutoSize = true;
            labelSignature.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSignature.Location = new Point(556, 744);
            labelSignature.Name = "labelSignature";
            labelSignature.Size = new Size(270, 30);
            labelSignature.TabIndex = 11;
            labelSignature.Text = "INA - MateuszMarek_20456";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(33, 72);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1177, 303);
            chart1.TabIndex = 12;
            chart1.Text = "chart1";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Lp, xReal, xBin, fX, percentage });
            dataGridView2.Location = new Point(34, 400);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(510, 300);
            dataGridView2.TabIndex = 13;
            dataGridView2.Visible = false;
            // 
            // Lp
            // 
            Lp.HeaderText = "Lp";
            Lp.Name = "Lp";
            Lp.Width = 45;
            // 
            // xReal
            // 
            xReal.HeaderText = "xReal";
            xReal.Name = "xReal";
            xReal.Width = 60;
            // 
            // xBin
            // 
            xBin.HeaderText = "xBin";
            xBin.Name = "xBin";
            xBin.Width = 55;
            // 
            // fX
            // 
            fX.HeaderText = "f(x)";
            fX.Name = "fX";
            fX.Width = 50;
            // 
            // percentage
            // 
            percentage.HeaderText = "%";
            percentage.Name = "percentage";
            percentage.Width = 42;
            // 
            // buttonTests
            // 
            buttonTests.Location = new Point(623, 492);
            buttonTests.Name = "buttonTests";
            buttonTests.Size = new Size(75, 23);
            buttonTests.TabIndex = 14;
            buttonTests.Text = "Test";
            buttonTests.TextAlign = ContentAlignment.TopCenter;
            buttonTests.UseVisualStyleBackColor = true;
            buttonTests.Click += buttonTests_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { testLp, testN, testPk, testPM, testT, testAVG });
            dataGridView3.Location = new Point(759, 400);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(451, 300);
            dataGridView3.TabIndex = 15;
            // 
            // testLp
            // 
            testLp.HeaderText = "Lp";
            testLp.Name = "testLp";
            testLp.Width = 45;
            // 
            // testN
            // 
            testN.HeaderText = "n";
            testN.Name = "testN";
            testN.Width = 39;
            // 
            // testPk
            // 
            testPk.HeaderText = "pk";
            testPk.Name = "testPk";
            testPk.Width = 45;
            // 
            // testPM
            // 
            testPM.HeaderText = "pm";
            testPM.Name = "testPM";
            testPM.Width = 50;
            // 
            // testT
            // 
            testT.HeaderText = "T";
            testT.Name = "testT";
            testT.Width = 38;
            // 
            // testAVG
            // 
            testAVG.HeaderText = "avg";
            testAVG.Name = "testAVG";
            testAVG.Width = 51;
            // 
            // isTestLoading
            // 
            isTestLoading.AutoSize = true;
            isTestLoading.Location = new Point(623, 518);
            isTestLoading.Name = "isTestLoading";
            isTestLoading.Size = new Size(63, 15);
            isTestLoading.TabIndex = 16;
            isTestLoading.Text = "   Start Test";
            // 
            // ISA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 783);
            Controls.Add(isTestLoading);
            Controls.Add(dataGridView3);
            Controls.Add(buttonTests);
            Controls.Add(dataGridView2);
            Controls.Add(chart1);
            Controls.Add(labelSignature);
            Controls.Add(groupBoxHeader);
            Controls.Add(dataGridView1);
            Name = "ISA";
            Text = "INA";
            Resize += ISA_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxHeader.ResumeLayout(false);
            groupBoxHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Label labelA;
        private TextBox inputA;
        private TextBox inputB;
        private TextBox inputN;
        private ComboBox dropdownD;
        private Label labelB;
        private Label labelD;
        private Label labelN;
        private DataGridView dataGridView1;
        private GroupBox groupBoxHeader;
        private Label labelSignature;
        private Label label3;
        private TextBox inputT;
        private Label label2;
        private TextBox inputPM;
        private Label label1;
        private TextBox inputPK;
        private CheckBox checkboxElite;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Lp;
        private DataGridViewTextBoxColumn xReal;
        private DataGridViewTextBoxColumn xBin;
        private DataGridViewTextBoxColumn fX;
        private DataGridViewTextBoxColumn percentage;
        private Button buttonTests;
        private DataGridView dataGridView3;
        private Label isTestLoading;
        private DataGridViewTextBoxColumn testLp;
        private DataGridViewTextBoxColumn testN;
        private DataGridViewTextBoxColumn testPk;
        private DataGridViewTextBoxColumn testPM;
        private DataGridViewTextBoxColumn testT;
        private DataGridViewTextBoxColumn testAVG;
        private Label generationsTime;
    }
}