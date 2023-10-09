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
            lp = new DataGridViewTextBoxColumn();
            xReal1 = new DataGridViewTextBoxColumn();
            xInt1 = new DataGridViewTextBoxColumn();
            xBin = new DataGridViewTextBoxColumn();
            xInt2 = new DataGridViewTextBoxColumn();
            xReal2 = new DataGridViewTextBoxColumn();
            fX = new DataGridViewTextBoxColumn();
            groupBoxHeader = new GroupBox();
            labelSignature = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxHeader.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(690, 16);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
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
            inputA.Size = new Size(100, 23);
            inputA.TabIndex = 2;
            inputA.Text = "-4";
            // 
            // inputB
            // 
            inputB.Location = new Point(202, 16);
            inputB.Name = "inputB";
            inputB.Size = new Size(100, 23);
            inputB.TabIndex = 3;
            inputB.Text = "12";
            // 
            // inputN
            // 
            inputN.Location = new Point(542, 15);
            inputN.Name = "inputN";
            inputN.Size = new Size(100, 23);
            inputN.TabIndex = 4;
            inputN.Text = "10";
            // 
            // dropdownD
            // 
            dropdownD.DropDownStyle = ComboBoxStyle.DropDownList;
            dropdownD.FormattingEnabled = true;
            dropdownD.Items.AddRange(new object[] { "0,1", "0,01", "0,001", "0,0001" });
            dropdownD.Location = new Point(353, 15);
            dropdownD.Name = "dropdownD";
            dropdownD.Size = new Size(121, 23);
            dropdownD.TabIndex = 5;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(182, 19);
            labelB.Name = "labelB";
            labelB.Size = new Size(14, 15);
            labelB.TabIndex = 6;
            labelB.Text = "b";
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Location = new Point(333, 19);
            labelD.Name = "labelD";
            labelD.Size = new Size(14, 15);
            labelD.TabIndex = 7;
            labelD.Text = "d";
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Location = new Point(520, 19);
            labelN.Name = "labelN";
            labelN.Size = new Size(16, 15);
            labelN.TabIndex = 8;
            labelN.Text = "N";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { lp, xReal1, xInt1, xBin, xInt2, xReal2, fX });
            dataGridView1.Location = new Point(33, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(744, 343);
            dataGridView1.TabIndex = 9;
            dataGridView1.Visible = false;
            // 
            // lp
            // 
            lp.HeaderText = "lp.";
            lp.Name = "lp";
            lp.Width = 45;
            // 
            // xReal1
            // 
            xReal1.HeaderText = "x real";
            xReal1.Name = "xReal1";
            xReal1.Width = 60;
            // 
            // xInt1
            // 
            xInt1.HeaderText = "x int";
            xInt1.Name = "xInt1";
            xInt1.Width = 55;
            // 
            // xBin
            // 
            xBin.HeaderText = "x bin";
            xBin.Name = "xBin";
            xBin.Width = 58;
            // 
            // xInt2
            // 
            xInt2.HeaderText = "x int";
            xInt2.Name = "xInt2";
            xInt2.Width = 55;
            // 
            // xReal2
            // 
            xReal2.HeaderText = "x real";
            xReal2.Name = "xReal2";
            xReal2.Width = 60;
            // 
            // fX
            // 
            fX.HeaderText = "f(x)";
            fX.Name = "fX";
            fX.Width = 50;
            // 
            // groupBoxHeader
            // 
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
            groupBoxHeader.Location = new Point(12, 1);
            groupBoxHeader.Name = "groupBoxHeader";
            groupBoxHeader.Size = new Size(802, 54);
            groupBoxHeader.TabIndex = 10;
            groupBoxHeader.TabStop = false;
            // 
            // labelSignature
            // 
            labelSignature.AutoSize = true;
            labelSignature.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSignature.Location = new Point(554, 435);
            labelSignature.Name = "labelSignature";
            labelSignature.Size = new Size(270, 30);
            labelSignature.TabIndex = 11;
            labelSignature.Text = "INA - MateuszMarek_20456";
            // 
            // ISA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 504);
            Controls.Add(labelSignature);
            Controls.Add(groupBoxHeader);
            Controls.Add(dataGridView1);
            Name = "ISA";
            Text = "ISA";
            Resize += ISA_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxHeader.ResumeLayout(false);
            groupBoxHeader.PerformLayout();
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
        private DataGridViewTextBoxColumn lp;
        private DataGridViewTextBoxColumn xReal1;
        private DataGridViewTextBoxColumn xInt1;
        private DataGridViewTextBoxColumn xBin;
        private DataGridViewTextBoxColumn xInt2;
        private DataGridViewTextBoxColumn xReal2;
        private DataGridViewTextBoxColumn fX;
        private GroupBox groupBoxHeader;
        private Label labelSignature;
    }
}