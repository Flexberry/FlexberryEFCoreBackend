using System;
using System.Collections.Generic;

namespace Cats.Model
{
    public class Cat
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Birthday { get; set; }
        public double? WeightKg { get; set; }

        public Guid? BreedId { get; set; }
        public virtual Breed? Breed { get; set; }

        public virtual ICollection<Paw> Paws { get; set; } = new HashSet<Paw>();
    }
}
