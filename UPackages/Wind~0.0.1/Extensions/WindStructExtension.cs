using UnityEngine;

namespace Niezbop.ProceduralGeneration.Wind.Extensions
{
    public static class WindExtension
    {
        public static Vector2 ToVector2(this WindStruct wind)
        {
            return new Vector2(
                Mathf.Cos(wind.angle),
                Mathf.Sin(wind.angle)
                ) * wind.strength;
        }

        public static Vector3 ToVector3(this WindStruct wind)
        {
            return new Vector3(
                Mathf.Cos(wind.angle),
                0f,
                Mathf.Sin(wind.angle)
                ) * wind.strength;
        }

        public static WindStruct ToWindStruct(this Vector2 vector)
        {
            return new WindStruct
            {
                angle = Mathf.Atan(vector.y / vector.x),
                strength = vector.magnitude
            };
        }

        public static Vector2 Vector2At(this IWindGenerator windGenerator, float x, float y)
        {
            return windGenerator.WindAt(x, y).ToVector2();
        }

        public static Vector3 Vector3At(this IWindGenerator windGenerator, float x, float y)
        {
            return windGenerator.WindAt(x, y).ToVector3();
        }
    }
}
