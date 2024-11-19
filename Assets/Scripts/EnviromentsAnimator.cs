using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnviromentsAnimator : MonoBehaviour
{
    private Animator animator;
    public GameObject faceMakeCanvas;
    public GameObject armorMakeCanvas;
    public GameObject Character;
    public Transform CustomizedMaleTransform;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        
    }

    public void FaceFocusButton()
    {
        animator.SetTrigger("FaceFocus");
        animator.SetBool("BackIdle", false);
        animator.SetBool("BackCreator", false);
    }

    public void BackIdle()
    {
        animator.SetBool("BackIdle", true);
        StartCoroutine(SmoothMaleTransform(17.7f, -4f, 0.6f));
    }

    public void BackCreator()
    {
        animator.SetBool("BackCreator", true);
        faceMakeCanvas.SetActive(false);
    }

    public void CreateSceneButton()
    {
        animator.SetTrigger("CreateScene");
        animator.SetBool("BackCreator", false);
    }

    public void ArmorColorSceneButton()
    {
        faceMakeCanvas.SetActive(false);
        armorMakeCanvas.SetActive(false);
        animator.SetTrigger("ArmorColor");
        animator.SetBool("BackIdle", false);
        StartCoroutine(SmoothMaleTransform(35.4f, -4f, 1.3f));
    }

    public void SubmitButton()
    {
        DontDestroyOnLoad(Character);
        Character.transform.position = new Vector2(0f, -4f);
        SceneManager.LoadScene(1);
    }

    IEnumerator SmoothMaleTransform(float x,float y,float waitSecond)
    {
        yield return new WaitForSeconds(waitSecond);
        Character.transform.position = new Vector2(x, y);
    }
}
