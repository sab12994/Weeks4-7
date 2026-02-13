using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int amountOfClicks = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score.text = amountOfClicks.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveFromTheNumbers()
    {
        amountOfClicks -= 1;
        score.text = amountOfClicks.ToString();
    }
}
