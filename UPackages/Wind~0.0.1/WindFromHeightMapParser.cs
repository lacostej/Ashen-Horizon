using Niezbop.ProceduralGeneration.Height;
using UnityEngine;

namespace Niezbop.ProceduralGeneration.Wind
{
    public class WindFromHeightMapParser : IWindGenerator
    {
        private IHeightMapGenerator m_heightMapGenerator;

        public WindFromHeightMapParser(IHeightMapGenerator heightMapGenerator)
        {
            m_heightMapGenerator = heightMapGenerator;
        }

        public WindStruct WindAt(float x, float y)
        {
            float bltrDifference = m_heightMapGenerator.HeightAt(x + 1, y + 1) - m_heightMapGenerator.HeightAt(x - 1, y - 1);
            float brtlDifference = m_heightMapGenerator.HeightAt(x + 1, y - 1) - m_heightMapGenerator.HeightAt(x - 1, y + 1);

            return new WindStruct
            {
                angle = Mathf.Atan((bltrDifference + brtlDifference) / (bltrDifference - brtlDifference)),
                strength = 1f
            };
        }
    }
}
