using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawnManager : MonoBehaviour
{
    public static CardSpawnManager instance = null;
    public GameObject Card; 
    public Transform OpenCardTransform;
    public Transform Origin;

    bool isShown=false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            //           Destroy(gameObject);
        }
        //Sets this to not be destroyed when reloading scene
        //     DontDestroyOnLoad(gameObject);

        //Get a component reference to the attached BoardManager script
        //   boardScript = GetComponent<BoardManager>();

        //Call the InitGame function to initialize the first level 
    }

    public void ShowCard()
    {
        //Play animation
        Card.gameObject.SetActive(true);
    }

    public void HideCard()
    {
        //Play animation backwards
        Card.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
