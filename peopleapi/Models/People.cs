using System;

namespace peopleapi.Models
{ 
    [Serializable]
    public class People
    {
        public Guid personId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public string suffix { get; set; }

        public People()
        {
            personId = Guid.NewGuid();
        }
    }
}