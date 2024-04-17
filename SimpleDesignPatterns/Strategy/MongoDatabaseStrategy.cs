using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.Strategy
{
    public class MongoDatabaseStrategy
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to MongoDB database");
        }

        public void Query(string query)
        {
            // Implement MongoDB query execution here
            Console.WriteLine("Executing MongoDB query: " + query);
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting from MongoDB database");
        }
    }
}
