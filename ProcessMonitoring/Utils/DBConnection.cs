using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace ProcessMonitoring.Utils
{
    class DBConnection
    {

        static private int id = 100;
        static private ConnectionMultiplexer redis = null;
        static public IDatabase db
        {
            get
            {
                if(redis == null)
                {
                    redis = ConnectionMultiplexer.Connect("localhost");
                }
                return redis.GetDatabase(id);
            }
        }
    }

}
