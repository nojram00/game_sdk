using game_sdk.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_sdk.Services
{
    public class StudentService
    {

        private readonly Client _client;

        public StudentService (Client client)
        {
            _client = client;
        }

        /// <summary>
        /// Displays List of Students from the Game Server.
        /// </summary>
        /// <returns>List of Students</returns>

        public async Task<List<Student>> GetStudents()
        {
            return await _client.GetAsync<List<Student>>("/api/get-students");
        }

        /// <summary>
        /// Register a new Student and save to game server
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Response</returns>

        public async Task<AddStudentResponse> AddStudent(Student student)
        {
            return await _client.PostAsync<AddStudentResponse>("/api/add-students", new
            {
                student.username,
                student.password,
                student.name,
                section_id = student?.section?.id,
                score = student?.score?.id,
                progress = student?.progress?.id,
            });
        }
    }
}
