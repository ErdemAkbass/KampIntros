using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Entity person);
    }
}
