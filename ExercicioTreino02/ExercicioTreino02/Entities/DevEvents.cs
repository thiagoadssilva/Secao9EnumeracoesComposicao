using ExercicioTreino02.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTreino02.Entities
{
    class DevEvents
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public StatusDevEvents Status { get; set; }

        public List<DevEventsSpeakers> Speakers { get; set; } = new List<DevEventsSpeakers>();

        public DevEvents() { }

        public DevEvents(string title, string description, DateTime startDate, DateTime endDate, StatusDevEvents status)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }

        public void AddSpeakers(DevEventsSpeakers speakers) {
            Speakers.Add(speakers);
        }

        public void RemoveSpeakers(DevEventsSpeakers speakers)
        {
            Speakers.Remove(speakers);
        }
    }
}
