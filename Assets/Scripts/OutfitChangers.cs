using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChangers : MonoBehaviour
{
    public SpriteRenderer bodyPart;
    public SpriteRenderer bodyPart2;
    public SpriteRenderer bodyPart3;
    public SpriteRenderer bodyPart4;
    public SpriteRenderer bodyPart5;
    public SpriteRenderer bodyPart6;

    public List<Sprite> firstOptions = new List<Sprite>();
    public List<Sprite> secondOptions = new List<Sprite>();
    public List<Sprite> thirdOptions = new List<Sprite>();
    public List<Sprite> fourthOptions = new List<Sprite>();
    public List<Sprite> fifthOptions = new List<Sprite>();
    public List<Sprite> sixthOptions = new List<Sprite>();

    public List<Texture2D> colorMask = new List<Texture2D>();

    private Material material;
    private Material material2;
    private Material material3;
    private Material material4;
    private Material material5;
    private Material material6;

    private int currentOption = 0;


    public void nextOption()
    {
        currentOption++;
        if (currentOption >= firstOptions.Count)
        {
            currentOption = 0;
        }
            UpdateOutfits();
    }

    public void previousOption()
    {
        currentOption--;
        if (currentOption <= -1 )
        {
            currentOption = firstOptions.Count - 1;
        }
            UpdateOutfits();
    }


    private void UpdateOutfits()
    {
        ApplySpriteAndMask(bodyPart, firstOptions, currentOption);

        if (bodyPart2 != null) ApplySpriteAndMask(bodyPart2, secondOptions, currentOption);
        if (bodyPart3 != null) ApplySpriteAndMask(bodyPart3, thirdOptions, currentOption);
        if (bodyPart4 != null) ApplySpriteAndMask(bodyPart4, fourthOptions, currentOption);
        if (bodyPart5 != null) ApplySpriteAndMask(bodyPart5, fifthOptions, currentOption);
        if (bodyPart6 != null) ApplySpriteAndMask(bodyPart6, sixthOptions, currentOption);
    }

    private void ApplySpriteAndMask(SpriteRenderer spriteRenderer, List<Sprite> options, int optionIndex)
    {
        spriteRenderer.sprite = options[optionIndex];

        MaterialPropertyBlock propertyBlock = new MaterialPropertyBlock();
        spriteRenderer.GetPropertyBlock(propertyBlock);

        if (colorMask[optionIndex] != null)
        {
            propertyBlock.SetTexture("_ColorMask", colorMask[optionIndex]);
        }
        spriteRenderer.SetPropertyBlock(propertyBlock);
    }
}
