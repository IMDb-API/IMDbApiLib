﻿namespace IMDbApiLib.Models
{
    public class WikipediaData
    {
        public WikipediaData()
        {
            ErrorMessage = string.Empty;
            PlotShort = new WikipediaDataPlot();
            PlotFull = new WikipediaDataPlot();
        }

        public WikipediaData(string id, string errorMessage)
        {
            IMDbId = id;
            ErrorMessage = errorMessage;
            PlotShort = null;
            PlotFull = null;
        }

        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string FullTitle { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string Language { get; set; }
        public string TitleInLanguage { get; set; }
        public string Url { get; set; }
        public WikipediaDataPlot PlotShort { get; set; }
        public WikipediaDataPlot PlotFull { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class WikipediaDataPlot
    {
        public WikipediaDataPlot()
        {
            PlainText = Html = string.Empty;
        }
        public string PlainText { get; set; }

        public string Html { get; set; }
    }




}
