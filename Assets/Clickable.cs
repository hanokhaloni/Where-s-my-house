using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public int id;

     void OnMouseDown()
    {
        Debug.Log("Clicked"+id);
    }
}
