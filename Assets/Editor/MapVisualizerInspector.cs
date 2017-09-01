using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapVisualizer))]
public class MapVisualizerInspector : Editor
{
    public override void OnInspectorGUI()
    {
        MapVisualizer visualizer = target as MapVisualizer;

        DrawDefaultInspector();

        EditorGUILayout.LabelField("Generation parameters", EditorStyles.boldLabel);
        visualizer.TextureWidth = EditorGUILayout.IntField("Texture Width", visualizer.TextureWidth);
        visualizer.TextureLength = EditorGUILayout.IntField("Texture Length", visualizer.TextureLength);
        visualizer.TextureScale = EditorGUILayout.Slider("Texture Scale", visualizer.TextureScale, 0.1f, 30f);

        EditorGUILayout.Space();
        if (GUILayout.Button("Regenerate Map"))
        {
            visualizer.Initialize();
        }
    }
}
