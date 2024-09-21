using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace game_sdk.Structures
{
    public class Score
    {
        public int? id {  get; }

        [JsonPropertyName("preTest")]
        public int? preTest { get; set; }

        [JsonPropertyName("postTest")]
        public int? postTest { get; set; }

        public Score() { }
        public Score(int? preTest, int? postTest) 
        {
            this.preTest = preTest;
            this.postTest = postTest;
        }
    }
}
