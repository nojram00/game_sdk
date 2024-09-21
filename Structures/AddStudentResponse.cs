using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_sdk.Structures
{
    public class AddStudentResponse
    {
        public struct StudentDto
        {
            public int id {  get; set; }
            public string name { get; set; }
            public string username { get; set; }
        }

        public string message { get; set; }
        public string token { get; set; }
        public StudentDto data {  get; set; } 
    }
}
