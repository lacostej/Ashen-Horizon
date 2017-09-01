namespace Niezbop.ProceduralGeneration.Height
{
    class MultiplyHeightMap : IHeightMapGenerator
    {
        public IHeightMapGenerator generatorA;
        public IHeightMapGenerator generatorB;

        public MultiplyHeightMap(IHeightMapGenerator a, IHeightMapGenerator b)
        {
            generatorA = a;
            generatorB = b;
        }

        public float HeightAt(float x, float y)
        {
            return generatorA.HeightAt(x, y) * generatorB.HeightAt(x, y);
        }
    }
}
