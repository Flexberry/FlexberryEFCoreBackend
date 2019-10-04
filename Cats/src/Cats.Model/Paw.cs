using System;

namespace Cats.Model
{
    public class Paw
    {
        public Guid Id { get; set; }
        public PawType Type { get; set; }
        public int? Size { get; set; }

        public Guid CatId { get; set; }
        public Cat Cat { get; set; } = null!;
    }
}