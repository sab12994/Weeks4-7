using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> OnRandomNumber;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hazard.bounds.Contains(transform.position))
        {
            if (isInHazard == true)
            {
                //still in the hazard
            }
            else
            {
                //entered he hazard
                //do something
                OnEnterSensor.Invoke();
                isInHazard = true;
            }
         }
        else
        {
            if(isInHazard == true)
            {
                //exited the hazard
                //do something
                OnExitSensor.Invoke();
                isInHazard = false;
                OnRandomNumber.Invoke(Random.Range(0, 10));
            }
            else
            {
                //still outside of the hazard
            }
        }
    }

    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
