using UnityEngine;

public class UnhideComponents : MonoBehaviour
{
    //store objects that are unhidden
    public GameObject[] objectsToUnhide;

    //when button is pressed
    public void UnhideAll()
    {
        foreach (GameObject obj in objectsToUnhide)
        {
            //makes them visable
            obj.SetActive(true);
           
        }
    }
}
