using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrbFestApp.Common
{
    public class Utilities
    {
        public Task GetRemoteDataAsync()
        {
            return Task.Run(() =>  GetRemoteData());
        }

        private async Task GetRemoteData()
        {
            
        }
    }
}
