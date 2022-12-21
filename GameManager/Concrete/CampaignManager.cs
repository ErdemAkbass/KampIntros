using GameManager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager.Concrete
{
    public class CampaignManager : ICrudService
    {
        public void Add(Entity entity)
        {
            Console.WriteLine(entity.Name+" adlı yeni bir kampanya eklendi");
        }

        public void Delete(Entity entity)
        {
            Console.WriteLine(entity.Name+"adlı kampanya sistemden silindi");
        }

        public void Update(Entity entity)
        {
            Console.WriteLine(entity.Name+"adlı kampanya şartları güncelledi");
        }
    }
}
