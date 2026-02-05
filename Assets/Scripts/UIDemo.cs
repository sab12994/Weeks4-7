using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIDemo : MonoBehaviour
{
    SpriteRenderer sr; //the red square sprite
    public Image image; //the image on the UI canvas
    public int howManyClicks = 0;
    public TextMeshProUGUI score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();     
        score.text = howManyClicks.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            ChangeColor();
        }
        
    }

    public void SetScaleBig(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

    public void ChangeColor()
    {
        sr.color = Random.ColorHSV();
        image.color = sr.color;
    }

    public void SetSize(float size)
    {
        transform.localScale = Vector3.one * size;
    }

    public void AddToTheNumber()
    {
        howManyClicks += 1;
        score.text = howManyClicks.ToString();
    }

    //public void SetRotation(float size)
    //{
    //    transform.eulerAngles = Vector3.one * size; //not completed, check out how rotation works
    //}
}
