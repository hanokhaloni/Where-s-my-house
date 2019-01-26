using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public bool isCorrect = false;

    void OnMouseDown()
    {
        Debug.Log("Clicked house. isCorrect:"+isCorrect);
        if (isCorrect) {
            GameManager.instance.WinGame();
        }
        else
        {
            GameManager.instance.GameOver();
        }
    }

}
