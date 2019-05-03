using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        public string Firstname { get; private set; }
        public string Surname { get; private set; }
        public string Email { get;private set; }
        public int PhoneNumber { get; private set; }
        Delivery[] Delivery;
        Payment[] Payment;
    }
}
