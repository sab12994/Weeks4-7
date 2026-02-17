using TMPro;
using UnityEngine;


public class TimerForAssignment : MonoBehaviour
{
    public float time = 100;
    public float timeEnd = 0;
    public TextMeshProUGUI timerVisuals;
    public GameObject gameOver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime; 

        if(time < timeEnd) //if the time counts to 0 it starts from the beginning
        {
            gameOver.SetActive(true);
            
        }
        else
        {
            gameOver.SetActive(false);
        }



            timerVisuals.text = time.ToString(); //so the text will show the amount of time left
    }
}
