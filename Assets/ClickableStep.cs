using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableStep : MonoBehaviour
{
    public int id;
    public float speed;

    bool playTransform = false;

    float Timer;

     void OnMouseDown()
    {
        Debug.Log("Clicked"+id);
        GameManager.instance.targetNodeIndex = id;
    }

    // void Update()
    // {
    //     Timer += Time.deltaTime * speed;

    //     if (playTransform) {
    //         transform.position = Vector3.Lerp(Player.transform.position, CurrentPosition, Timer);
    //     }


    // }
}
