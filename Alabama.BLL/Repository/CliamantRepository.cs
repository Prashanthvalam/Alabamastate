using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Alabama.BLL.Interface;
namespace Alabama.BLL.Repository
{
    public class CliamantRepository : ICliamantInterface
    {
        public CliamantRepository()
        { 
        
        }

        public async Task<string> getString()
        {
            return "Alabama";
        }

    }
}
