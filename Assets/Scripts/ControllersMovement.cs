using UnityEngine;
using UnityEngine.InputSystem;

public class ControllersMovement : MonoBehaviour
{
    public bool anyKeyIsPressed = false;
    public float speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        anyKeyIsPressed = Keyboard.current.anyKey.isPressed;

        //test for left arrow key: move to the left
        if (Keyboard.current.leftArrowKey.isPressed == true)
        {
            Vector2 newPos = transform.position;
            newPos.x -= speed * Time.deltaTime;
            transform.position = newPos;
        }

        //test for right arrow key: move to the right
        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            Vector2 newPos = transform.position;
            newPos.x += speed * Time.deltaTime;
            transform.position = newPos;
        }
               
    }

    public void ChangeTheSpeed()
    {
        speed += 1;
    }
}
