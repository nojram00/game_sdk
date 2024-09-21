using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace game_sdk.Structures
{
    public class Student
    {
        public int? id { get; }

        [JsonPropertyName("name")]
        public required string name {  get; set; }

        [JsonPropertyName("username")]
        public required string username { get; set; }

        [JsonPropertyName("password")]
        public string? password { get; set; }

        [JsonPropertyName("section")]
        public Section? section { get; set; }

        [JsonPropertyName("score")]
        public Score? score { get; set; }

        [JsonPropertyName("progress")]
        public Progress? progress { get; set; }

        public Student () { }

        public Student(string name, string username, string password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }

        public Student(string name, string username, string password, Section section, Score score, Progress progress)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.section = section;
            this.score = score;
            this.progress = progress;
        }
        
    }
}
