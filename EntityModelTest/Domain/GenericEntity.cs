using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityModel.Test.Domain
{
    public class GenericEntity<TKey>
        : BaseEntity<TKey>
    {

        public void SetID(TKey key)
        {
            this.ID = key;
        }

    }
}
