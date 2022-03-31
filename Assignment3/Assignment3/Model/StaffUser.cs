using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Model
{
    class StaffUser : User
    {
        public enum Role
        {
            role1,
            role2,
            role3
        }
        Role role { get; set; }

        public override string ToString()
        {
            return this.ToString();
        }
    }
}
