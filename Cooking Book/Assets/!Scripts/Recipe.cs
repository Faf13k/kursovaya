using UnityEngine;

[CreateAssetMenu(menuName="Recipe")]
public class Recipe : ScriptableObject
{
    public string Name;
    [TextArea(10, 1000)] public string Description;
    public Sprite Icon;
}
