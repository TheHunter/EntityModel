using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityModel
{
    /// <summary>
    /// A base class for persistent entities.
    /// </summary>
    /// <typeparam name="TKey">Type of identifier for this entity.</typeparam>
    [Serializable]
    public abstract class BaseEntity<TKey>
        : IEntity<TKey>
    {
        private TKey id;

        protected BaseEntity()
        {
            //assignedId = false;
        }

        /// <summary>
        /// Gets and sets the identifier of the calling entity.
        /// </summary>
        public virtual TKey ID
        {
            get { return this.id; }
            protected set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is BaseEntity<TKey>)
                return this.GetHashCode() == obj.GetHashCode();

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Equals(ID, default(TKey)) ? 0 : (7 * this.ID.GetHashCode());
        }

        /// <summary>
        /// It rappresents information about the current state of the calling entity.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string nameType = this.GetType().Name;
            int index = nameType.IndexOf("`", StringComparison.Ordinal);
            return string.Format("Entity Name: {0}<{1}>, ID: {2}", nameType.Substring(0, index), typeof (TKey).Name, this.ID);
        }
    }
}
