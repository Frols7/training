﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTest
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstname = null;
        private string lastname = null;

        public ContactData (string firstname)
        {
            this.firstname = firstname;
        }

        public bool Equals(ContactData otherFirst)
        {
            if (Object.ReferenceEquals(otherFirst, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, otherFirst))
            {
                return true;
            }
            return FirstName == otherFirst.FirstName;
           
        }

        public bool Equals2(ContactData otherLast)
        {
            if (Object.ReferenceEquals(otherLast, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, otherLast))
            {
                return true;
            }
            return LastName == otherLast.LastName;

        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode();
        }
        public override string ToString()
        {
            return FirstName;
        }

        public int CompareTo(ContactData otherFirst)
        {
            if (Object.ReferenceEquals(otherFirst, null))
            {
                return 1;
            }
            return FirstName.CompareTo(otherFirst.FirstName);
        }
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
    }
}
