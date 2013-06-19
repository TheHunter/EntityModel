using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityModel
{
    /// <summary>
    /// A base class for versioned persistent entities.
    /// </summary>
    /// <typeparam name="TKey">The type of key for this class.</typeparam>
    public abstract class VersionedEntity<TKey>
        : BaseEntity<TKey>, IVersioned<TKey>
    {
        /// <summary>
        /// The cuurent version for this object.
        /// </summary>
        private int version;

        /// <summary>
        /// The current version for the calling object.
        /// </summary>
        public virtual int Version
        {
            get { return this.version; }
            protected set { this.version = value; }
        }

        /// <summary>
        /// Returns a String object that represents the calling versioned object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + string.Format(", current version: {0}", this.Version);
        }
    }
}
