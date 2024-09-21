using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace game_sdk.Structures
{
    public class Section
    {
        public int? id {  get; }

        [JsonPropertyName("sectionName")]
        public string? sectionName { get; set; }

        [JsonPropertyName("teacherId")]
        public int? teacherId { get; set; } = null;

        [JsonPropertyName("teacher")]
        public Teacher? teacher { get; set; } = null;

        public Section() { }

        public Section(string? sectionName, Teacher? teacher) 
        { 
            this.sectionName = sectionName;
            this.teacherId = teacher?.id;
            this.teacher = teacher;
        }
    }
}
