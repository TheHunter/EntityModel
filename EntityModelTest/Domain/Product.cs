using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityModel.Notifiers;

namespace EntityModelTest.Domain
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
