using GameManager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Entities
{
    public class Customer:Entity
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public long NationalityId;

    }
}
