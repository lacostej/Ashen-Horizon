using ProceduralGeneration.Noise;

namespace Niezbop.ProceduralGeneration.Height
{
    public class RandomHeightMap : IHeightMapGenerator
    {
        private System.Random random;

        public RandomHeightMap() : this(System.DateTime.Now.Second) { }
        public RandomHeightMap(int seed)
        {
            random = new System.Random(seed);
        }

        public float HeightAt(float x, float y)
        {
            return ((float)random.Next(100)) / 100;
        }
    }
}
