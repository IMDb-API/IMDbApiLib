using System.Collections.Generic;

namespace IMDbApiLib.Models
{
    public class FullCastData
    {
        public FullCastData()
        {
            ErrorMessage = string.Empty;
            Actors = new List<ActorShort>();
            Directors = new CastShort("Director");
            Writers = new CastShort("Writer");
            Others = new List<CastShort>();
        }

        public FullCastData(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Actors = new List<ActorShort>();
            Directors = new CastShort("Director");
            Writers = new CastShort("Writer");
            Others = new List<CastShort>();
        }

        public FullCastData(string id, string errorMessage) : this(errorMessage)
        {
            IMDbId = id;
        }

        public string IMDbId { get; set; }
        public string Title { set; get; }
        public string FullTitle { set; get; }
        public string Type { set; get; }
        public string Year { get; set; }
        public CastShort Directors { get; set; }
        public CastShort Writers { get; set; }
        public List<ActorShort> Actors { get; set; }
        public List<CastShort> Others { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CastShort
    {
        public CastShort(string job)
        {
            Job = job;
            Items = new List<CastShortItem>();
        }

        public string Job { get; set; }
        public List<CastShortItem> Items { get; set; }
    }

    public class CastShortItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ActorShort
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string AsCharacter { get; set; } = "";
    }
}