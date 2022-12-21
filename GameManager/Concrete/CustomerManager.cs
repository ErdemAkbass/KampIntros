using GameManager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
    public class CustomerManager : ICrudService
    {
        ICustomerCheckService _customerCheckService;
            public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Add(Entity entity)
        {
            if (_customerCheckService.CheckIfRealPerson(entity))
            {
                Console.WriteLine(entity.Name+"Adlı müşteri eklendi");
            }
            else
            {
                Console.WriteLine("Bu gerçek bir kişi değil");
            }
            
        }

        public void Delete(Entity entity)
        {
            Console.WriteLine(entity.Name+"kullanıcı adlı üye silindi");
        }

        public void Update(Entity entity)
        {
            Console.WriteLine(entity.Name+"kullanıcı adlı üye bilgileri güncellendi");
        }
    }
}
