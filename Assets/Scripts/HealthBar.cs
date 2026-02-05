using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer player;
    public int health = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        //get the mouse posiiton 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //is it inside the sprite?
        if(player.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            //Y: take 1 from the health
            health -= 1;

            if (health <= 0)
            {
                gameObject.SetActive(false);
            }
        }


        //update the health bar with the new health value
        healthBar.value = health;
    }

    public void Heal()
    {
        //tur on the player game object
        gameObject.SetActive(true);
        //get health back to 5
        health = (int)healthBar.maxValue;
        //set the value of the slider to our health
        healthBar.value = health;
    }
}
