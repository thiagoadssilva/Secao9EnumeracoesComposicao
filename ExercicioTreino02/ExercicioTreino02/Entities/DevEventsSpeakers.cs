using ExercicioTreino02.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTreino02.Entities
{
    class DevEventsSpeakers
    {
        public string Name { get; set; }
        public string TalkTitle{ get; set; }
        public string TalkDescription { get; set;}

        public StatusDevEvents Status{ get; set; }
    }
}
