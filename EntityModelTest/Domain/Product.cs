using EntityModel.Notifiers;

namespace EntityModel.Test.Domain
{
    public class Product
        : ObservableEntity<int?>
    {
        private string owner;

        public string Category { get; set; }

        public string Owner
        {
            get { return owner; }
            set
            {
                string oldValue = owner;
                this.owner = value;
                if (((owner == null && oldValue != null) || (owner != null && oldValue == null)) || (owner != null && oldValue != null && !owner.Equals(oldValue)))
                    this.OnPropertyChanged("owner");
            }
        }
    }
}
