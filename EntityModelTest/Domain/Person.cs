namespace EntityModel.Test.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Person
        : BaseEntity<int>
    {
        public Person(){}

        public Person(int key)
            :base(key)
        {
            
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
