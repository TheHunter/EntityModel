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
    interface IVersioned<out TKey>
        : IEntity<TKey>
    {
        /// <summary>
        /// 
        /// </summary>
        int Version { get; }
    }
}
