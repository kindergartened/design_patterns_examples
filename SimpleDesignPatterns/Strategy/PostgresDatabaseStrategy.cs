using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.Strategy
{
    public class PostgresDatabaseStrategy
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to PostgreSQL database");
        }

        public void Query(string query)
        {
            // Implement PostgreSQL query execution here
            Console.WriteLine("Executing PostgreSQL query: " + query);
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from PostgreSQL database");
        }
    }
}
