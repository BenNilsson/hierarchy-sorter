using System.Linq;
using UnityEditor;
using UnityEngine;

public class SortItemsByName : EditorWindow
{
    [MenuItem("GameObject/A-Z Sort &s")]
    public static void SortObjects()
    {
        if (Selection.gameObjects.Length > 0)
        {
            int initialIndex = Selection.gameObjects[0].transform.GetSiblingIndex();

            // Sort
            GameObject[] sortedObjects = Selection.gameObjects.OrderBy(go => go.name).ToArray();
            for (int i = 0; i < sortedObjects.Length; i++)
            {
                sortedObjects[i].transform.SetSiblingIndex(initialIndex + i);
            }
        }
        else Debug.LogError("[A-Z Sort Error]: No objects selected in Hierarchy Window to sort");
    }
}
