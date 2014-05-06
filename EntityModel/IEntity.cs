using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityModel
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IEntity<out TKey>
        : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        TKey ID { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        object Key { get; }
    }
}
