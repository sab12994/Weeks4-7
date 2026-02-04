using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleBanana()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

        //if the game object is active turn it off: call setActive passing false
        //if (gameObject.activeInHierarchy == true)
        //{
        //    gameObject.SetActive(false);
        //}
        //else if (gameObject.activeInHierarchy == false)
        //{
        //    //otherwise the game object is inactive, so turn it on: call setActive passing true
        //    gameObject.SetActive(true);
        //}
    }
}
