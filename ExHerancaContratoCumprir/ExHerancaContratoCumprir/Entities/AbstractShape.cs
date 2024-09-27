using ExHerancaContratoCumprir.Entities.Enums;

namespace ExHerancaContratoCumprir.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
