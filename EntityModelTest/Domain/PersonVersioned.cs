using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityModel.Test.Domain
{
    class PersonVersioned
        : VersionedEntity<long?>
    {
        public PersonVersioned(long? id)
            :base(id)
        {
            
        }
    }
}
