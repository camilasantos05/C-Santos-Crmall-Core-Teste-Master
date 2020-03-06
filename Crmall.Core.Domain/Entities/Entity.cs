using System;

namespace Crmall.Core.Domain.Entities
{
    public class Entity : IEquatable<Entity>
    {
        public Entity() 
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; protected set; }

        public bool Equals(Entity input)
        {
            return Id == input.Id;
        }
    }
}
