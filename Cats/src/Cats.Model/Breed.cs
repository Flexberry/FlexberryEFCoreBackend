using System;

namespace Cats.Model
{
    public class Breed
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? Rare { get; set; }
    }
}