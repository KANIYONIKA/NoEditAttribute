using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(NoEditAttribute))]
public class NoEditDrawer : PropertyDrawer
{
    private NoEditAttribute NoEditAttribute => (NoEditAttribute)attribute;

    public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
    {
        var newPos = _position;
        newPos.x = _position.x + (NoEditAttribute.indent * 7.25f);
        EditorGUI.BeginDisabledGroup(true);
        EditorGUI.PropertyField(newPos, _property, _label);
        EditorGUI.EndDisabledGroup();
    }
}
#endif