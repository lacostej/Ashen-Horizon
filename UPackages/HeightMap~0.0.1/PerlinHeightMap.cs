using ProceduralGeneration.Noise;

namespace Niezbop.ProceduralGeneration.Height
{
    public class PerlinHeightMap : IHeightMapGenerator
    {
        private float scale;

        public PerlinHeightMap() : this(1.0f) { }
        public PerlinHeightMap(float scale)
        {
            this.scale = scale;
        }

        public float Scale
        {
            get
            {
                return scale;
            }
            set
            {
                scale = value;
            }
        }

        public float HeightAt(float x, float y)
        {
            return Perlin.Noise(x * scale, y * scale);
        }
    }
}
