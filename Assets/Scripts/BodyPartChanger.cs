using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartChanger : MonoBehaviour
{
    public List<GameObject> CreatorsCanvas = new List<GameObject>();
    

    public void BackButton()
    {
        for(int i = 0;i < CreatorsCanvas.Count;i++)
        {
            CreatorsCanvas[i].SetActive(false);
        }
    }
    public void FaceCreator()
    {
        StartCoroutine(faceCreatorIE());
    }

    IEnumerator faceCreatorIE()
    {
        yield return new WaitForSeconds(1.3f);
        BackButton();
        CreatorsCanvas[0].SetActive(true);
    }
    
    public void ArmorCreator()
    {
        BackButton();
        CreatorsCanvas[1].SetActive(true);
    }
}
