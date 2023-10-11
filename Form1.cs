using System;
using System.Reflection.Metadata.Ecma335;

namespace ISA_1
{
    public partial class ISA : Form
    {
        bool staticData = false;
        public ISA()
        {
            InitializeComponent();

            // Set default index of dropdown D
            this.dropdownD.SelectedIndex = 2;

            // Set style for data grid view
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;

            // Set style for groupBox Header
            this.groupBoxHeader.Paint += groupBoxHeader_Paint!;
        }

        public (double precision, int decimalPlaces) getDecimalPrecisionData()
        {
            string precision = this.dropdownD.SelectedItem.ToString()!;

            switch (precision)
            {
                case "0,1":
                    return (0.1, 1);
                case "0,01":
                    return (0.01, 2);
                case "0,001":
                    return (0.001, 3);
                case "0,0001":
                    return (0.0001, 4);
                default:
                    return (0, 0);
            }
        }

        public string forceDecimalPlaces(double number, int decimalPlaces)
        {
            string formatString = "0." + new string('0', decimalPlaces);
            return number.ToString(formatString);
        }

        public int realToInt(double realNumber, int a, int b, int l)
        {
            return (int)Math.Floor((1 / (double)(b - a)) * (realNumber - a) * (Math.Pow(2, l) - 1));
        }

        public string intToBin(int intNumber, int l)
        {
            string binVal = Convert.ToString(intNumber, 2);
            int missingBits = l - binVal.Length;

            for (int i = 0; i < missingBits; ++i)
            {
                binVal = binVal.Insert(0, "0");
            }

            return binVal;
        }

        public int binToInt(string binNumber)
        {
            return Convert.ToInt32(binNumber, 2);
        }

        public double intToReal(int intNumber, int a, int b, int l, int decimalPlaces)
        {
            return Math.Round(((double)intNumber * (double)(b - a)) / (Math.Pow(2, l) - 1) + a, decimalPlaces);
        }

        public double GenerateNumberInRangeWithPrecision(int a, int b, int decimalPlaces)
        {

            Random random = new Random();

            double number = random.NextDouble() * (b - a) + a;

            return Math.Round(number, decimalPlaces);
        }

        public int getL(int a, int b, double d)
        {
            return (int)Math.Ceiling(Math.Log2((b - a) / d + 1));
        }

        public double xF(double x)
        {
            return (x % 1) * (Math.Cos(20 * Math.PI * x) - (Math.Sin(x)));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Clear data table
            this.dataGridView1.Rows.Clear();

            // Initialize variables
            int a = 0, b = 0, n = 0;
            var decimalPrecisionData = getDecimalPrecisionData();

            // Set variables value
            int.TryParse(this.inputA.Text, out a);
            int.TryParse(this.inputB.Text, out b);
            int.TryParse(this.inputN.Text, out n);
            double d = decimalPrecisionData.precision;
            int decimalPlaces = decimalPrecisionData.decimalPlaces;

            if (staticData)
            {
                a = -2;
                b = 3;
                d = 0.001;
                decimalPlaces = 3;
            }

            int l = this.getL(a, b, d);

            for (int i = 1; i <= n; ++i)
            {
                // Initialize variables
                int xIntFirst, xIntSecond;
                double xRealFirst, xRealSecond, xF;
                string xBin;

                // Set variables value
                xRealFirst = this.GenerateNumberInRangeWithPrecision(a, b, decimalPlaces);

                if (staticData)
                {
                    xRealFirst = -1.012;
                }

                xIntFirst = this.realToInt(xRealFirst, a, b, l);
                xBin = this.intToBin(xIntFirst, l);
                xIntSecond = this.binToInt(xBin);
                xRealSecond = this.intToReal(xIntSecond, a, b, l, decimalPlaces);
                xF = this.xF(xRealSecond);

                // Add table row with values
                this.dataGridView1.Rows.Add(i, this.forceDecimalPlaces(xRealFirst,decimalPlaces), xIntFirst, xBin, xIntSecond, this.forceDecimalPlaces(xRealSecond,decimalPlaces), xF);
            }

            // Show table
            this.dataGridView1.Visible = true;
        }

        private void ISA_Resize(object sender, EventArgs e)
        {
            // Set groupBoxHeader and dataGridView1 position to center on resize 
            this.groupBoxHeader.Left = this.Width / 2 - this.groupBoxHeader.Width / 2;
            this.dataGridView1.Left = this.Width / 2 - this.dataGridView1.Width / 2;

            // Set labelSignature position to right on resize 
            this.labelSignature.Left = this.Width - this.labelSignature.Width - 25;
        }

        private void groupBoxHeader_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(SystemColors.Control);
        }
    }
}