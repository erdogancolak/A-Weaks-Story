using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ArmorColorChange : MonoBehaviour
{
    public GameObject armorPart;
    public GameObject armorPart2;
    public GameObject armorPart3;
    public GameObject armorPart4;
    public GameObject armorPart5;
    public GameObject armorPart6;

    private SpriteRenderer armorPartSprite;
    private SpriteRenderer armorPartSprite2;
    private SpriteRenderer armorPartSprite3;
    private SpriteRenderer armorPartSprite4;
    private SpriteRenderer armorPartSprite5;
    private SpriteRenderer armorPartSprite6;

    private Material armorMaterial;
    private Material armorMaterial2;
    private Material armorMaterial3;
    private Material armorMaterial4;
    private Material armorMaterial5;
    private Material armorMaterial6;

    public List<Color> colors = new List<Color>();
    private int currentOption = 0;

    public string ColorIndex;

    private void Start()
    {
            
    }
    public void nextOption()
    {
        currentOption++;
        if (currentOption >= colors.Count)
        {
            currentOption = 0;
        }
        ArmorColorChanges();
    }

    public void previousOption()
    {
        currentOption--;
        if (currentOption <= -1)
        {
            currentOption = colors.Count - 1;
        }
        ArmorColorChanges();
    }

    private void ArmorColorChanges()
    {
            armorPartSprite = armorPart.GetComponent<SpriteRenderer>();
            armorMaterial = armorPartSprite.material;
            armorMaterial.SetColor(ColorIndex, colors[currentOption]);
        if (armorPart2 != null)
        {
            armorPartSprite2 = armorPart2.GetComponent<SpriteRenderer>();
            armorMaterial2 = armorPartSprite2.material;
            armorMaterial2.SetColor(ColorIndex, colors[currentOption]);
            if (armorPart3 != null)
            {
                armorPartSprite3 = armorPart3.GetComponent<SpriteRenderer>();
                armorMaterial3 = armorPartSprite3.material;
                armorMaterial3.SetColor(ColorIndex, colors[currentOption]);
                if (armorPart4 != null)
                {
                    armorPartSprite4 = armorPart4.GetComponent<SpriteRenderer>();
                    armorMaterial4 = armorPartSprite4.material;
                    armorMaterial4.SetColor(ColorIndex, colors[currentOption]);
                    if (armorPart5 != null)
                    {
                        armorPartSprite5 = armorPart5.GetComponent<SpriteRenderer>();
                        armorMaterial5 = armorPartSprite5.material;
                        armorMaterial5.SetColor(ColorIndex, colors[currentOption]);
                        if (armorPart6 != null)
                        {
                            armorPartSprite6 = armorPart6.GetComponent<SpriteRenderer>();
                            armorMaterial6 = armorPartSprite6.material;
                            armorMaterial6.SetColor(ColorIndex, colors[currentOption]);
                        }
                    }
                }
            }
        }
    }
}
