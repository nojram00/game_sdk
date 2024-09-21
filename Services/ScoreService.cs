using game_sdk.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_sdk.Services
{
    public class ScoreService
    {
        private readonly Client _client;

        public ScoreService(Client client)
        {
            _client = client;
        }

        public async Task<UpdateScoreResponse> UpdateScore(int studentId, Score score)
        {
            return await _client.PostAsync<UpdateScoreResponse>($"/api/update-score/{studentId}", score);
        }
    }
}
