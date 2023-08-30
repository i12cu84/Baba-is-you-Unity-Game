using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// 맵정보 담을때 인스펙터에 어떻게 나타낼지 꾸밈.
[CustomEditor(typeof(LevelCreator))]
[ExecuteInEditMode]
public class LevelCreatorInspector : Editor
{
    Dictionary<ElementTypes, Texture> textureHolder = new Dictionary<ElementTypes, Texture>();
    private void OnEnable()
    {
        textureHolder.Add(ElementTypes.Empty, (Texture)EditorGUIUtility.Load("Assets/Sprites/empty.png"));
        textureHolder.Add(ElementTypes.Baba, (Texture)EditorGUIUtility.Load("Assets/Sprites/baba.png"));
        textureHolder.Add(ElementTypes.Wall, (Texture)EditorGUIUtility.Load("Assets/Sprites/wall.png"));
        textureHolder.Add(ElementTypes.Flag, (Texture)EditorGUIUtility.Load("Assets/Sprites/flag.png"));
        textureHolder.Add(ElementTypes.BabaString, (Texture)EditorGUIUtility.Load("Assets/Sprites/babaString.png"));
        textureHolder.Add(ElementTypes.WallString, (Texture)EditorGUIUtility.Load("Assets/Sprites/wallString.png"));
        textureHolder.Add(ElementTypes.Is, (Texture)EditorGUIUtility.Load("Assets/Sprites/isString.png"));
        textureHolder.Add(ElementTypes.You, (Texture)EditorGUIUtility.Load("Assets/Sprites/youString.png"));
        textureHolder.Add(ElementTypes.Stop, (Texture)EditorGUIUtility.Load("Assets/Sprites/stopString.png"));
        textureHolder.Add(ElementTypes.Win, (Texture)EditorGUIUtility.Load("Assets/Sprites/winString.png"));
        textureHolder.Add(ElementTypes.FlagString, (Texture)EditorGUIUtility.Load("Assets/Sprites/flagString.png"));
        textureHolder.Add(ElementTypes.Push, (Texture)EditorGUIUtility.Load("Assets/Sprites/push.png"));
    }

    ElementTypes currentSelected = ElementTypes.Empty;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GUILayout.Label("Current Selected : " + currentSelected.ToString());

        LevelCreator levelCreator = (LevelCreator)target;
        int rows = (int)Mathf.Sqrt(levelCreator.level.Count);
        GUILayout.BeginVertical();
        for(int r = 0; r < rows; r++)
        {
            GUILayout.BeginHorizontal();
            for(int c = 0; c < rows; c++)
            {
                if(GUILayout.Button(textureHolder[levelCreator.level[r * rows + c]], GUILayout.Width(25), GUILayout.Height(25)))
                {
                    levelCreator.level[r * rows + c] = currentSelected;
                }
            }
            GUILayout.EndHorizontal();
        }
        GUILayout.EndVertical();

        GUILayout.Space(20);
        GUILayout.BeginVertical();
        GUILayout.BeginHorizontal();
        int count = 0;
        foreach(KeyValuePair<ElementTypes, Texture> e in textureHolder)
        {
            count ++;
            if(GUILayout.Button(e.Value, GUILayout.Width(50), GUILayout.Height(50)))
            {
                currentSelected = e.Key;
            }
            if(count % 4 == 0)
            {
                GUILayout.EndHorizontal();
                GUILayout.BeginHorizontal();
            }
        }
        GUILayout.EndHorizontal();
        GUILayout.EndVertical();
    }
}
