using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Abstract
{
    internal interface ICrudService
    {
        void Add(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
    }
}
