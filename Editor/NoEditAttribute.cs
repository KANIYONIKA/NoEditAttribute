using UnityEngine;

public class NoEditAttribute : PropertyAttribute
{
    public float indent;

    public NoEditAttribute(float indent)
    {
        this.indent = indent;
    }
}