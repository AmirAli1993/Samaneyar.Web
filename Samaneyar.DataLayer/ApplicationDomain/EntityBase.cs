using System;

namespace Samaneyar.DataLayer.ApplicationDomain
{
  public class EntityBase
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }

        public EntityBase()
        {
            CreationDate = DateTime.Now;
        }
    }
}
