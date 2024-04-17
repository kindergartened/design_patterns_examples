using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.Strategy
{
    public interface IDatabaseStrategy
    {
        void Connect();
        void Query(string query);
        void Disconnect();
    }
}
