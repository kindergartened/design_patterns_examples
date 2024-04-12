using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns.FactoryMethod
{
    /// <summary>
    /// Абстракция для фабрики
    /// </summary>
    interface IEnemyFactory
    {
        /// <summary>
        /// Каждая конкретная фабрика должна реализовывать свой способ создания объекта
        /// </summary>
        /// <returns></returns>
        IEnemy Create();    
    }
}
