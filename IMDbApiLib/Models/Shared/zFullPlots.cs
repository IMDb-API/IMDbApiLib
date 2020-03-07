namespace IMDbApiLib.Models
{
    public class zFullPlots
    {
        public zFullPlots(bool rtl, string plot)
        {
            LtrPlot = null;
            RtLPlot = null;

            if (rtl)
                RtLPlot = plot;
            else
                LtrPlot = plot;
        }

        public string LtrPlot { get; set; }
        public string RtLPlot { get; set; }
    }
}
