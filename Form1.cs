using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using static ISA_1.ISA;

namespace ISA_1
{
    public partial class ISA : Form
    {
        public ISA()
        {
            InitializeComponent();

            // Set default index of dropdown D
            this.dropdownD.SelectedIndex = 2;

            // Set style for data grid view
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;

            // Set style for groupBox Header
            this.groupBoxHeader.Paint += groupBoxHeader_Paint!;
        }

        public class EliteXreal
        {
            public int index { get; set; }
            public double xreal { get; set; }
            public double fx { get; set; }
        }

        public class ParentPair
        {
            public int IndexParent1 { get; set; }
            public string ValueParent1 { get; set; }
            public int IndexParent2 { get; set; }
            public string ValueParent2 { get; set; }
            public int Pc { get; set; }
        }

        public class MutationResult
        {
            public string XBin { get; set; }
            public string MutatedBits { get; set; }
        }

        public class ChartData
        {
            public double Min { get; set; }
            public double Max { get; set; }
            public double Avg { get; set; }
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

        private double GenerateR(Random random)
        {
            return random.NextDouble();
        }

        private int GeneratePc(int l)
        {
            Random random = new Random();
            return random.Next(0, l - 1);
        }

        public int getL(int a, int b, double d)
        {
            return (int)Math.Ceiling(Math.Log2((b - a) / d + 1));
        }

        public double FunctionValue(double x)
        {
            return (x % 1) * (Math.Cos(20 * Math.PI * x) - (Math.Sin(x)));
        }

        public (List<GeneticRow> TableLpToFx, EliteXreal ElitexReal) GetTableLpToFx(int a, int b, double d, int decimalPlaces, int n, List<double> xReals)
        {
            var resultArray = new List<GeneticRow>();
            double eliteFX = double.MinValue;
            EliteXreal elitexReal = new EliteXreal { index = 0, xreal = 0, fx = 0 };

            for (int i = 1; i <= n; i++)
            {
                double xReal = xReals.Count > 0 ? xReals[i - 1] : GenerateNumberInRangeWithPrecision(a, b, decimalPlaces);
                double functionX = FunctionValue(xReal);

                if (functionX > eliteFX)
                {
                    eliteFX = functionX;
                    elitexReal = new EliteXreal { index = i - 1, xreal = xReal, fx = functionX };
                }

                resultArray.Add(new GeneticRow { lp = i, xreal = xReal, fx = functionX });
            }

            return (resultArray, elitexReal);
        }

        public List<GeneticRow> GetTableLpToGx(List<GeneticRow> tableLpToFx, double d, string direction)
        {
            double maxVal = double.MinValue;
            double minVal = double.MaxValue;

            foreach (var row in tableLpToFx)
            {
                if (row.fx.HasValue)
                {
                    maxVal = Math.Max(maxVal, row.fx.Value);
                    minVal = Math.Min(minVal, row.fx.Value);
                }
            }

            foreach (var row in tableLpToFx)
            {
                if (row.fx.HasValue)
                {
                    if (direction == "max")
                    {
                        row.gx = row.fx.Value - minVal + d;
                    }
                    else if (direction == "min")
                    {
                        row.gx = -1 * (row.fx.Value - maxVal) + d;
                    }
                }
            }

            return tableLpToFx;
        }

        public List<GeneticRow> GetTableLpToPi(List<GeneticRow> tableLpToGx)
        {
            double sumGi = 0;

            foreach (var row in tableLpToGx)
            {
                sumGi += row.gx ?? 0;
            }

            foreach (var row in tableLpToGx)
            {
                row.pi = row.gx.HasValue ? row.gx.Value / sumGi : 0;
            }

            return tableLpToGx;
        }

        public List<GeneticRow> GetTableLpToQi(List<GeneticRow> tableLpToPi)
        {
            double qiSum = 0;

            foreach (var row in tableLpToPi)
            {
                double pi = row.pi ?? 0;
                qiSum += pi;
                row.qi = qiSum;
            }

            return tableLpToPi;
        }

        public List<GeneticRow> GetTableLpToR(List<GeneticRow> tableLpToQi)
        {
            Random random = new Random();

            foreach (var row in tableLpToQi)
            {
                row.r = GenerateR(random);
            }

            return tableLpToQi;
        }

        public List<GeneticRow> GetTableLpToSelectedXreal(List<GeneticRow> tableLpToR)
        {
            foreach (var row in tableLpToR)
            {
                double r = row.r ?? 0;
                bool chosenX = false;

                for (int i = 0; i < tableLpToR.Count; i++)
                {
                    double xReal = tableLpToR[i].xreal ?? 0;
                    double q = tableLpToR[i].qi ?? 0;
                    double prevQ = i == 0 ? 0 : tableLpToR[i - 1].qi ?? 0;

                    if (prevQ < r && r <= q)
                    {
                        row.xrealAfterSelection = xReal;
                        chosenX = true;
                        break;
                    }
                }

                if (!chosenX)
                {
                    row.xrealAfterSelection = null;
                }
            }

            return tableLpToR;
        }

        public List<GeneticRow> GetTableLpToXbinAfterSelection(List<GeneticRow> tableLpToXreal, int a, int b, int l)
        {
            foreach (var row in tableLpToXreal)
            {
                double? xReal = row.xrealAfterSelection;

                if (xReal == null)
                {
                    row.xbinAfterSelection = null;
                }
                else
                {
                    int xInt = realToInt(xReal.Value, a, b, l);
                    row.xbinAfterSelection = intToBin(xInt, l);
                }
            }

            return tableLpToXreal;
        }

        public List<GeneticRow> GetTableLpToParents(List<GeneticRow> tableLpToXbin, double pk)
        {
            Random random = new Random();

            if (tableLpToXbin.Count == 1)
            {
                tableLpToXbin[0].parent = null;
                return tableLpToXbin;
            }

            var parentsIndexes = new List<int>();
            var emptyParentIndexes = new List<int>();

            for (int index = 0; index < tableLpToXbin.Count; index++)
            {
                var row = tableLpToXbin[index];
                double r = GenerateR(random);
                string xBin = row.xbinAfterSelection;

                if (r <= pk && !parentsIndexes.Contains(index))
                {
                    row.parent = xBin;
                    parentsIndexes.Add(index);
                }
                else
                {
                    row.parent = null;
                    emptyParentIndexes.Add(index);
                }
            }

            if (parentsIndexes.Count == 1)
            {
                int randomParentIndex = random.Next(emptyParentIndexes.Count);
                int randomParentIndexValue = emptyParentIndexes[randomParentIndex];
                tableLpToXbin[randomParentIndexValue].parent = tableLpToXbin[randomParentIndexValue].xbinAfterSelection;
            }

            return tableLpToXbin;
        }

        public (List<GeneticRow> TableLpToPc, List<ParentPair> Pairs) GetTableLpToPc(List<GeneticRow> tableLpToParents, int l)
        {
            var parentsData = new List<ParentPair>();
            var nonNullParents = tableLpToParents
                .Select((row, index) => new { row.parent, Index = index })
                .Where(x => !string.IsNullOrEmpty(x.parent))
                .ToList();

            if (nonNullParents.Count == 0)
            {
                foreach (var row in tableLpToParents)
                {
                    row.pc = null;
                }
                return (tableLpToParents, new List<ParentPair>());
            }

            for (int i = 0; i < nonNullParents.Count; i += 2)
            {
                int indexParent1 = nonNullParents[i].Index;
                int indexParent2 = i + 1 < nonNullParents.Count ? nonNullParents[i + 1].Index : nonNullParents[0].Index;

                string parent1 = nonNullParents[i].parent;
                string parent2 = nonNullParents[i + 1 < nonNullParents.Count ? i + 1 : 0].parent;
                int pc = GeneratePc(l);

                parentsData.Add(new ParentPair
                {
                    IndexParent1 = indexParent1,
                    ValueParent1 = parent1,
                    IndexParent2 = indexParent2,
                    ValueParent2 = parent2,
                    Pc = pc
                });
            }

            foreach (var parentData in parentsData)
            {
                if (!tableLpToParents[parentData.IndexParent1].pc.HasValue)
                {
                    tableLpToParents[parentData.IndexParent1].pc = parentData.Pc;
                }

                if (!tableLpToParents[parentData.IndexParent2].pc.HasValue)
                {
                    tableLpToParents[parentData.IndexParent2].pc = parentData.Pc;
                }
            }

            foreach (var row in tableLpToParents)
            {
                if (!row.pc.HasValue)
                {
                    row.pc = null;
                }
            }

            return (tableLpToParents, parentsData);
        }

        public (string d1, int d1Index, string d2, int d2Index) CrossParents(ParentPair parents)
        {
            int pc = parents.Pc;
            string firstParentHead = parents.ValueParent1.Substring(0, pc + 1);
            string firstParentTail = parents.ValueParent1.Substring(pc + 1);

            string secondParentHead = parents.ValueParent2.Substring(0, pc + 1);
            string secondParentTail = parents.ValueParent2.Substring(pc + 1);

            string d1 = firstParentHead + secondParentTail;
            string d2 = secondParentHead + firstParentTail;

            return (d1, parents.IndexParent1, d2, parents.IndexParent2);
        }

        public List<GeneticRow> GetTableLpToCross(List<GeneticRow> tableLpToPc, List<ParentPair> pairs)
        {
            foreach (var pair in pairs)
            {
                var crossedData = CrossParents(pair);

                if (string.IsNullOrEmpty(tableLpToPc[crossedData.d1Index].cross))
                {
                    tableLpToPc[crossedData.d1Index].cross = crossedData.d1;
                }

                if (string.IsNullOrEmpty(tableLpToPc[crossedData.d2Index].cross))
                {
                    tableLpToPc[crossedData.d2Index].cross = crossedData.d2;
                }
            }

            foreach (var row in tableLpToPc)
            {
                if (string.IsNullOrEmpty(row.cross))
                {
                    row.cross = row.xbinAfterSelection;
                }
            }

            return tableLpToPc;
        }

        public MutationResult MutateBin(string xBin, double pm)
        {
            Random random = new Random();
            var xbinTab = xBin.ToCharArray();
            var mutatedBits = new List<int>();

            for (int index = 0; index < xbinTab.Length; index++)
            {
                double r = random.NextDouble();
                if (r <= pm)
                {
                    xbinTab[index] = xbinTab[index] == '0' ? '1' : '0';
                    mutatedBits.Add(index);
                }
            }

            return new MutationResult
            {
                XBin = new string(xbinTab),
                MutatedBits = string.Join(",", mutatedBits),
            };
        }

        public List<GeneticRow> GetTableLpToMutatedXbin(List<GeneticRow> tableLpToCross, double pm)
        {
            foreach (var row in tableLpToCross)
            {
                string xBin = row.cross;
                var mutatedXBinData = MutateBin(xBin, pm);
                row.mutatedBits = mutatedXBinData.MutatedBits;
                row.xbinAfterMutation = mutatedXBinData.XBin;
            }

            return tableLpToCross;
        }

        public List<GeneticRow> GetTableLpToFxAfterMutation(List<GeneticRow> tableLpToMutatedXbin, int a, int b, int l, int decimalPlaces, EliteXreal elite, bool keepElite)
        {
            foreach (var row in tableLpToMutatedXbin)
            {
                string xBin = row.xbinAfterMutation;
                int xInt = binToInt(xBin);
                double xReal = intToReal(xInt, a, b, l, decimalPlaces);
                double fx = FunctionValue(xReal);

                row.xrealAfterMutation = xReal;
                row.fxAfterMutation = fx;
            }

            if (keepElite && tableLpToMutatedXbin[elite.index].fxAfterMutation < elite.fx)
            {
                tableLpToMutatedXbin[elite.index].xrealAfterMutation = elite.xreal;
                tableLpToMutatedXbin[elite.index].fxAfterMutation = elite.fx;
            }
            else if (keepElite)
            {
                var indexes = Enumerable.Range(0, tableLpToMutatedXbin.Count)
                                        .Where(i => i != elite.index)
                                        .OrderBy(_ => Guid.NewGuid())
                                        .ToList();

                foreach (var index in indexes)
                {
                    if (tableLpToMutatedXbin[index].fxAfterMutation < elite.fx)
                    {
                        tableLpToMutatedXbin[index].xrealAfterMutation = elite.xreal;
                        tableLpToMutatedXbin[index].fxAfterMutation = elite.fx;
                        break;
                    }
                }
            }

            return tableLpToMutatedXbin;
        }

        public (List<GeneticRow> FullTable, List<double> LastXreals, ChartData GenerationChartData) MakeGeneration(int a, int b, double d, int decimalPlaces, int n, List<double> xReals, double pk, double pm, string direction, int l, bool keepElite)
        {
            (List<GeneticRow> TableLpToFx, EliteXreal ElitexReal) tableLpToFxData = GetTableLpToFx(a, b, d, decimalPlaces, n, xReals);
            List<GeneticRow> tableLpToFx = tableLpToFxData.TableLpToFx;
            EliteXreal eliteXreal = tableLpToFxData.ElitexReal;

            List<GeneticRow> tableLpToGx = GetTableLpToGx(tableLpToFx, d, direction);
            List<GeneticRow> tableLpToPi = GetTableLpToPi(tableLpToGx);
            List<GeneticRow> tableLpToQi = GetTableLpToQi(tableLpToPi);
            List<GeneticRow> tableLpToR = GetTableLpToR(tableLpToQi);
            List<GeneticRow> tableLpToSelectedXreal = GetTableLpToSelectedXreal(tableLpToR);
            List<GeneticRow> tableLpToXbinAfterSelection = GetTableLpToXbinAfterSelection(tableLpToSelectedXreal, a, b, l);
            List<GeneticRow> tableLpToParents = GetTableLpToParents(tableLpToXbinAfterSelection, pk);

            (List<GeneticRow> TableLpToPc, List<ParentPair> Pairs) tableLpToPcData = GetTableLpToPc(tableLpToParents, l);
            List<GeneticRow> tableLpToPc = tableLpToPcData.TableLpToPc;
            List<ParentPair> pairs = tableLpToPcData.Pairs;

            List<GeneticRow> tableLpToCross = GetTableLpToCross(tableLpToPc, pairs);
            List<GeneticRow> tableLpToMutatedXbin = GetTableLpToMutatedXbin(tableLpToCross, pm);
            List<GeneticRow> tableLpToFxAfterMutation = GetTableLpToFxAfterMutation(tableLpToMutatedXbin, a, b, l, decimalPlaces, eliteXreal, keepElite);

            List<double> lastXReals = tableLpToFxAfterMutation.Select(row => row.xrealAfterMutation.GetValueOrDefault()).ToList();
            List<double> lastFx = tableLpToFxAfterMutation.Select(row => row.fxAfterMutation.GetValueOrDefault()).ToList();

            double max = lastFx.Max();
            double min = lastFx.Min();
            double avg = lastFx.Average();

            ChartData generationChartData = new ChartData { Min = min, Max = max, Avg = avg };

            return (tableLpToFxAfterMutation, lastXReals, generationChartData);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            // Clear data table
            this.dataGridView1.Rows.Clear();
            this.dataGridView2.Rows.Clear();

            // Initialize variables
            int a = 0, b = 0, n = 0, t = 0;
            double pk = 0, pm = 0;
            bool keepElite = false;
            string direction = "max";
            var decimalPrecisionData = getDecimalPrecisionData();

            // Set variables values
            int.TryParse(this.inputA.Text, out a);
            int.TryParse(this.inputB.Text, out b);
            int.TryParse(this.inputN.Text, out n);
            int.TryParse(this.inputT.Text, out t);
            int decimalPlaces = decimalPrecisionData.decimalPlaces;

            double d = decimalPrecisionData.precision;
            double.TryParse(this.inputPK.Text.Replace(".", ","), out pk);
            double.TryParse(this.inputPM.Text.Replace(".", ","), out pm);

            keepElite = this.checkboxElite.Checked;
            int l = this.getL(a, b, d);

            // Chart setup
            chart1.Series.Clear();

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.IsStartedFromZero = false;
            chartArea.AxisY.IsStartedFromZero = false;

            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Interval = t / 10;

            chartArea.AxisY.Minimum = -3;
            chartArea.AxisY.Maximum = 3;
            chartArea.AxisY.Interval = 1;

            var series1 = new Series("Min f(x)") { ChartType = SeriesChartType.Line, Color = System.Drawing.Color.Red };
            var series2 = new Series("Max f(x)") { ChartType = SeriesChartType.Line, Color = System.Drawing.Color.Blue };
            var series3 = new Series("Average f(x)") { ChartType = SeriesChartType.Line, Color = System.Drawing.Color.Orange };

            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);

            List<double> insertXreals = new List<double>();

            for (int i = 0; i < t; i++)
            {
                (List<GeneticRow> FullTable, List<double> LastXreals, ChartData GenerationChartData) generation = MakeGeneration(a, b, d, decimalPlaces, n, insertXreals, pk, pm, direction, l, keepElite);
                foreach (GeneticRow row in generation.FullTable)
                {

                    double minVal = generation.GenerationChartData.Min;
                    double maxVal = generation.GenerationChartData.Max;
                    double avgVal = generation.GenerationChartData.Avg;

                    series1.Points.AddXY(i, minVal);
                    series2.Points.AddXY(i, maxVal);
                    series3.Points.AddXY(i, avgVal);

                    if (i == t - 1)
                    {
                        this.dataGridView1.Rows.Add(row.lp, row.xreal, row.fx, row.gx, row.pi, row.qi, row.r, row.xrealAfterSelection, row.xbinAfterSelection, row.parent, row.pc, row.cross, row.mutatedBits, row.xbinAfterMutation, row.xrealAfterMutation, row.fxAfterMutation);
                    }

                }
                insertXreals = generation.LastXreals;
            }

            Dictionary<double, int> xRealsFrequency = new Dictionary<double, int>();

            foreach (double item in insertXreals)
            {
                if (xRealsFrequency.ContainsKey(item))
                {
                    xRealsFrequency[item]++;
                }
                else
                {
                    xRealsFrequency[item] = 1;
                }
            }

            IEnumerable<KeyValuePair<double, int>> sortedxRealsFrequency = xRealsFrequency.OrderByDescending(pair => pair.Value);

            int lp = 1;
            foreach (KeyValuePair<double, int> pair in sortedxRealsFrequency)
            {
                string xBin = intToBin(realToInt(pair.Key, a, b, l), l);
                double fx = FunctionValue(pair.Key);
                double percentage = (double)pair.Value / insertXreals.Count;
                this.dataGridView2.Rows.Add(lp, pair.Key, xBin, fx, percentage * 100 + " %(" + pair.Value + "/" + insertXreals.Count() + ")");
                lp++;
            }

            //this.dataGridView1.Visible = true;
            this.dataGridView2.Visible = true;

            stopwatch2.Stop();
            TimeSpan ts = stopwatch2.Elapsed;
            this.generationsTime.Text = string.Format(ts.Milliseconds + "ms");

        }

        public class TestResult
        {
            public int n { get; set; }
            public double pk { get; set; }
            public double pm { get; set; }
            public int t { get; set; }
            public double avg { get; set; }
        }

        private async void buttonTests_Click(object sender, EventArgs e)
        {
            this.isTestLoading.Text = "Running";

            this.dataGridView3.Rows.Clear();
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            List<int> testN = new List<int> { 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 };
            List<double> testPk = new List<double> { 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9 };
            List<double> testPm = new List<double> { 0.0001, 0.0005, 0.001, 0.0015, 0.002, 0.0025, 0.003, 0.0035, 0.004, 0.0045, 0.005, 0.0055, 0.006, 0.0065, 0.007, 0.0075, 0.008, 0.0085, 0.009, 0.0095, 0.01 };
            List<int> testT = new List<int> { 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150 };

            //List<int> testN = new List<int> { 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80 };
            //List<double> testPk = new List<double> { 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9 };
            //List<double> testPm = new List<double> { 0.0001, 0.0005, 0.001, 0.005, 0.01 };
            //List<int> testT = new List<int> { 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150 };

            int lValue = this.getL(-4, 12, 0.001);
            int paramsCombinations = testN.Count() * testPk.Count() * testPm.Count() * testT.Count();

            List<TestResult> testResult = new List<TestResult>();
            List<Task> tasks = new List<Task>();

            foreach (int n in testN)
            {
                foreach (double pk in testPk)
                {
                    foreach (double pm in testPm)
                    {
                        foreach (int t in testT)
                        {
                            tasks.Add(Task.Run(() =>
                            {
                                List<double> allResultMax = new List<double>();
                                for (int i = 0; i < 1; i++)
                                {
                                    List<double> insertXreals = new List<double>();
                                    for (int nIter = 0; nIter < t; nIter++)
                                    {
                                        (List<GeneticRow> FullTable, List<double> LastXreals, ChartData GenerationChartData) generation = MakeGeneration(-4, 12, 0.001, 3, n, insertXreals, pk, pm, "max", lValue, true);

                                        insertXreals = generation.LastXreals;
                                        allResultMax.Add(generation.GenerationChartData.Max);
                                    }
                                }

                                lock (testResult)
                                {
                                    testResult.Add(new TestResult
                                    {
                                        n = n,
                                        pk = pk,
                                        pm = pm,
                                        t = t,
                                        avg = allResultMax.Average()
                                    });
                                    if (testResult.Count % 100 == 0)
                                    {
                                        Debug.WriteLine(testResult.Count + "/" + paramsCombinations + " tested " + (paramsCombinations - testResult.Count) + " left");
                                    }
                                }
                            }));
                        }
                    }
                }
            }

            await Task.WhenAll(tasks);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            var sortedResults = testResult.OrderByDescending(tr => tr.avg).ThenBy(tr => tr.t).ToList();

            this.Invoke(new Action(() =>
            {
                this.isTestLoading.Text = string.Format("Czas wykonania:\n{0} godzin \n{1} minut \n{2} sekund", ts.Hours, ts.Minutes, ts.Seconds);
                ;
                for (int lp = 1; lp <= 50; lp++)
                {
                    var result = sortedResults[lp - 1];
                    this.dataGridView3.Rows.Add(lp, result.n, result.pk, result.pm, result.t, result.avg);
                }
            }));
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