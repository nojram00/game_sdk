using game_sdk.Services;
using game_sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_sdk
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Start();
        }

        public static async void Start()
        {
            var api_client = new Client("https://game-server-nu.vercel.app");
            var studentService = new StudentService(api_client);

            var students = await studentService.GetStudents();

            Console.WriteLine(students);
        }
    }
}
