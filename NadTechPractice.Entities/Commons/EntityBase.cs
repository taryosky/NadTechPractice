using System;

namespace NadTechPractice.Entities.Commons
{
    public class EntityBase
    {
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public EntityBase()
        {
            DateCreated = DateTime.Now;
        }
    }
}