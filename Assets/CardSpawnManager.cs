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
            case 1: return "no grass";
            case 2: return "!black";
            case 3: return "cross";
            case 4: return "white";
            case 5: return "!high";
            case 6: return "no orcs";
            case 7: return "no blood";
            case 8: return "white roof";
            case 9: return "4 walls";
            case 10: return "chimnee";
            case 11: return "a duck";
            case 12: return "one wall is white";
            case 13: return "extra turn!";
            case 14: return "bugs";
            case 15: return "A duck";
            default: return "GUESS!";
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
