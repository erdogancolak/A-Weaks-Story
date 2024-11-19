using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OutfitColorChanger : MonoBehaviour
{
    public SpriteRenderer bodyColorPart;
    public List<Color> colors = new List<Color>();

    private int currentColor = 0;

    public void nextOption()
    {
        currentColor++;
        if (currentColor >= colors.Count)
        {
            currentColor = 0;
        }
        bodyColorPart.color = colors[currentColor];
    }

    public void previousOption()
    {
        currentColor--;
        if (currentColor <= 0)
        {
            currentColor = colors.Count - 1;
        }
        bodyColorPart.color = colors[currentColor];
    }
}
