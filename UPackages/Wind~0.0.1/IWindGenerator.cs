namespace Niezbop.ProceduralGeneration.Wind
{
    public interface IWindGenerator
    {
        WindStruct WindAt(float x, float y);
    }
}

