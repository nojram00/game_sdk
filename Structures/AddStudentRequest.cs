using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_sdk.Structures
{
    public class AddStudentRequest
    {
        public string? username { get; set; }
        public string? password { get; set; }
        public int sectionId { get; set; } = 0;
        public int score_id { get; set; } = 0;
        public int progressId { get; set; } = 0;
    }
}
