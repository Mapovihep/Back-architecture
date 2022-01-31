﻿

namespace Entities.Abstract
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id {get; set;}
        public string Name {get; set;}

        public DateTime CreatedAt { get; set; }
    }
}
