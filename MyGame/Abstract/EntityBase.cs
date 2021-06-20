using System;

namespace MyGame.Abstract
{
    public abstract class EntityBase<T>
    {
        public EntityBase()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public T Id { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
