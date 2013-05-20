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
