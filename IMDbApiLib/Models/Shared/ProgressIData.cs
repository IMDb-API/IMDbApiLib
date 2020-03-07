using System;

namespace IMDbApiLib.Models
{
    public interface IProgressData : IProgress<ProgressData>
    {
        void Report(long current, long total);
    }

    public class ProgressData : Progress<ProgressData>, IProgressData
    {
        public ProgressData()
        { }

        public ProgressData(Action<ProgressData> handler) : base(handler)
        { }

        public ProgressData(long current, long total)
        {
            Current = current;
            Total = total;
        }

        public long Current { get; set; }
        public long Total { get; set; }

        public void Report(long current, long total)
        {
            var progressData = new ProgressData(current, total);
            base.OnReport(progressData);
        }
    }

}
