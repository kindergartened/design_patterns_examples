﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.Strategy
{
    public class Context
    {
            private IDatabaseStrategy _databaseStrategy;

            public Context(IDatabaseStrategy databaseStrategy)
            {
                _databaseStrategy = databaseStrategy;
            }

            public void SetDatabaseStrategy(IDatabaseStrategy databaseStrategy)
            {
                _databaseStrategy = databaseStrategy;
            }

            public void ExecuteQuery(string query)
            {
                _databaseStrategy.Connect();
                _databaseStrategy.Query(query);
                _databaseStrategy.Disconnect();
            }
        }
    }