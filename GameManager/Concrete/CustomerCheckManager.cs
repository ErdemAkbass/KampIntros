using GameManager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Entity person)
        {
            if (person.Name.Length>3)
            {
                return true;
            }
            return false;     
        }
    }
}
