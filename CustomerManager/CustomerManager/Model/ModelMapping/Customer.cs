using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.Model.ModelMapping
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool Active { get; set; }
        public string Comments { get; set; }
    }
}
