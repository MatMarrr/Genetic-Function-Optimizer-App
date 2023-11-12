namespace ISA_1
{
    public class GeneticRow
    {
        public int? lp { get; set; }
        public double? xreal { get; set; }
        public double? fx { get; set; }
        public double? gx { get; set; }
        public double? pi { get; set; }
        public double? qi { get; set; }
        public double? r { get; set; }
        public double? xrealAfterSelection { get; set; }
        public string xbinAfterSelection { get; set; }
        public string parent { get; set; }
        public int? pc { get; set; }
        public string cross { get; set; }
        public string mutatedBits { get; set; }
        public string xbinAfterMutation { get; set; }
        public double? xrealAfterMutation { get; set; }
        public double? fxAfterMutation { get; set; }

        public GeneticRow()
        {
        }

        public GeneticRow(int? lp, double? xreal, double? fx, double? gx, double? pi, double? qi, double? r, double? xrealAfterSelection, string xbinAfterSelection, string parent, int? pc, string cross, string mutatedBits, string xbinAfterMutation, double? xrealAfterMutation, double? fxAfterMutation)
        {
            this.lp = lp;
            this.xreal = xreal;
            this.fx = fx;
            this.gx = gx;
            this.pi = pi;
            this.qi = qi;
            this.r = r;
            this.xrealAfterSelection = xrealAfterSelection;
            this.xbinAfterSelection = xbinAfterSelection;
            this.parent = parent;
            this.pc = pc;
            this.cross = cross;
            this.mutatedBits = mutatedBits;
            this.xbinAfterMutation = xbinAfterMutation;
            this.xrealAfterMutation = xrealAfterMutation;
            this.fxAfterMutation = fxAfterMutation;
        }

    }
}
