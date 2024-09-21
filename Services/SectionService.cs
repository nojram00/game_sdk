using game_sdk.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_sdk.Services
{
    public class SectionService
    {
        private readonly Client _client;
        public SectionService (Client client)
        {
            _client = client;
        }

        /// <summary>
        /// Displays the List of Sections Available
        /// </summary>
        /// <returns></returns>
        public async Task<List<Section>> GetSections()
        {
            return await _client.GetAsync<List<Section>>("api/sections");
        }

    }
}
