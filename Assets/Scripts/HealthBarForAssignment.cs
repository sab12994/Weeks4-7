using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class HealthBarForAssignment : MonoBehaviour
{
    public Slider healthBar;
    public SpriteRenderer damage;
    public int health = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //giving values to health bar
        healthBar.maxValue = health; 
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        // mouse posiiton 
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
                
        if (damage.bounds.Contains(mousePos) && Mouse.current.leftButton.wasPressedThisFrame)
        {            
            health -= 1;

            if (health <= 0)
            {
                gameObject.SetActive(false); //if the health value is 0, the game object disappears
            }
        }
               
        healthBar.value = health; //update the health bar and give new value
    }
        
}
