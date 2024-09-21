using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_sdk.Structures
{
    public class Progress
    {
        public int? id { get; }
        public int quantumMastery { get; set; }
        public int ecologyMastery { get; set; }
        public int momentumMastery { get; set; }
        public int teraMastery { get; set; }

        public Progress() { }

        public Progress(int quantumMastery, int ecologyMastery, int momentumMastery, int teraMastery) 
        {
            this.quantumMastery = quantumMastery;
            this.ecologyMastery = ecologyMastery;
            this.teraMastery = teraMastery;
            this.momentumMastery = momentumMastery;
        }
    }
}
