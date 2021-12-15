using System;

namespace IMDbApiLib.Models
{
    public class EnumDisplayNameDescription<T> where T : Enum
    {
        public EnumDisplayNameDescription()
        {

        }

        public EnumDisplayNameDescription(T enumField, string displayName, string description)
        {
            EnumField = enumField;
            DisplayName = displayName;
            Description = description;
        }

        public T EnumField { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
    }
}
