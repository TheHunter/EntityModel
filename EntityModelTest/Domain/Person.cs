using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityModel;

namespace EntityModelTest.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Person
        : BaseEntity<int>
    {
        public Person(){}

        public Person(int key)
        {
            this.OnInit(key);
        }

        private void OnInit(int key)
        {
            this.ID = key;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Surname { get; set; }
    }
}
