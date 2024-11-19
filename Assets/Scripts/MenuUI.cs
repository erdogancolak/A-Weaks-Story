using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public Button StartButton;
    public Button FaceSelectButton;
    public Button hairSelectRight;
    public Button helmetSelectRight;
    public Button helmetColorSelectRight;
    public Button armorColorSelectRight;
    public Button pantColorSelectRight;
    public Button gloveColorSelectRight;
    public Button bootColorSelectRight;
    public Button capeColorSelectRight;
    void Start()
    {
        StartButton.Select();
    }

    public void faceButtonSelect()
    {
        FaceSelectButton.Select();
    }

    public void hairButtonSelect()
    {
        hairSelectRight.Select();
    }
    public void helmetButtonSelect()
    {
        helmetSelectRight.Select();
    }
    public void helmetColorButtonSelect()
    {
        helmetColorSelectRight.Select();
    }

    public void armorColorButtonSelect()
    {
        armorColorSelectRight.Select();
    }
    public void pantColorButtonSelect()
    {
        pantColorSelectRight.Select();
    }
    public void gloveColorButtonSelect()
    {
        gloveColorSelectRight.Select();
    }
    public void bootColorButtonSelect()
    {
        bootColorSelectRight.Select();
    }
    public void capeColorButtonSelect()
    {
        capeColorSelectRight.Select();
    }
}
