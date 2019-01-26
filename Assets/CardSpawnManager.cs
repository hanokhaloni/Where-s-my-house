using System;
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

    public void ShowCard(int id)
    {
        //Play animation
        // GetComponent(TextMesh).text = "blah";

        Card.GetComponentInChildren<TextMesh>().text = GetTextById(id);
        Card.gameObject.SetActive(true);
    }

    private string GetTextById(int id)
    {
        switch (id)
        {
            case 1: return "green";
            case 2: return "black";
            case 3: return "top";
            case 4: return "road";
            case 5: return "c++";
            case 6: return "go away";
            case 7: return "ndnd";
            case 8: return "LRRR!";
            case 9: return "4 walls";
            case 10: return "chimnee";
            case 11: return "a duck";
            case 12: return "lame";
            case 13: return "extra turn!";
            case 14: return "bugs";
            case 15: return "orcs";
            default: return "NONE!";
        }
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
