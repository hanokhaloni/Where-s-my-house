using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableCard : MonoBehaviour
{
    
    // Update is called once per frame
    void OnMouseDown()
    {
        Debug.Log("Clicked card");
        CardSpawnManager.instance.HideCard();    
    }
}
