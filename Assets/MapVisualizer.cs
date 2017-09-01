using Niezbop.ProceduralGeneration.Height;
using Niezbop.ProceduralGeneration.Wind;
using UnityEngine;

public class MapVisualizer : MonoBehaviour
{
    private IHeightMapGenerator hmGenerator;

    public Gradient colors;
    private int texWidth, texLength;
    private float texScale;
    public MeshRenderer meshRenderer;

    public int TextureWidth
    {
        get { return texWidth; }
        set
        {
            texWidth = value;
            Initialize();
        }
    }

    public int TextureLength
    {
        get { return texLength; }
        set
        {
            texLength = value;
            Initialize();
        }
    }

    public float TextureScale
    {
        get { return texScale; }
        set
        {
            texScale = value;
            Initialize();
        }
    }

    public void OnEnable()
    {
        Initialize();
    }

    public void Initialize()
    {
        hmGenerator = new PerlinHeightMap(texScale);
        SetTexture();
    }

    public void SetTexture()
    {
        if (meshRenderer == null) return;
        if (texWidth <= 0 || texLength <= 0) return;
        if (texScale == 0f) return;

        Texture2D tex = new Texture2D(texWidth, texLength);

        for (int i = 0; i < texWidth; i++)
        {
            for (int j = 0; j < texLength; j++)
            {
                tex.SetPixel(i, j, colors.Evaluate(hmGenerator.HeightAt(((float)i) / texWidth, ((float)j) / texLength)));
            }
        }

        tex.Apply();
        tex.wrapMode = TextureWrapMode.Clamp;
        tex.filterMode = FilterMode.Point;
        tex.name = "Procedural texture";

        meshRenderer.sharedMaterial.mainTexture = tex;
    }
}
