using GameManager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
    public class GameManagers : ICrudService
    {
        public void Add(Entity entity)
        {
            Console.WriteLine(entity.Name+"adlı oyun eklendi");
        }

        public void Delete(Entity entity)
        {
            Console.WriteLine(entity.Name+"adlı oyun satıştan kaldırıldı");
        }

        public void Update(Entity entity)
        {
            Console.WriteLine(entity.Name+"adlı oyun satış şartları güncellendi");
        }
    }
}
