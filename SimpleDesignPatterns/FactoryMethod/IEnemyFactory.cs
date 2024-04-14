using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatterns
{
    /// <summary>
    /// Абстракция для фабрики
    /// </summary>
    public interface IEnemyFactory
    {
        /// <summary>
        /// Каждая конкретная фабрика должна реализовывать свой способ создания объекта
        /// </summary>
        IEnemy Create();    
    }
}
