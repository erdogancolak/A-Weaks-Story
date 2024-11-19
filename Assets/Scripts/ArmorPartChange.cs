using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPartChange : MonoBehaviour
{
    public List<GameObject> ArmorParts = new List<GameObject>();

    private int currentPart = 0;
    
    public void nextOption()
    {
        ArmorParts[currentPart].SetActive(false);
        currentPart++;
        if (currentPart >= ArmorParts.Count)
        {
            currentPart = 0;
        }
        ArmorParts[currentPart].SetActive(true);
        
    }
    public void previousOption()
    {
        ArmorParts[currentPart].SetActive(false);
        currentPart--;
        if (currentPart <= -1)
        {
            currentPart = ArmorParts.Count - 1;
        }
        ArmorParts[currentPart].SetActive(true);
    }
}
