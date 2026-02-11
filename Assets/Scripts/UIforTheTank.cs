using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class UIforTheTank : MonoBehaviour
{
    SpriteRenderer tank;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tank = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetTheRandomColor()
    {
        tank.color = Random.ColorHSV();
    }

    public void ChangeTheSize(float scale)
    {
        
        transform.localScale = Vector3.one * scale;
        
    }



}
