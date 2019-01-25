using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
                                                            // private BoardManager boardScript;                       //Store a reference to our BoardManager which will set up the level.


    bool someoneWon = false;
int CurrentPlayer  = 0;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }
        //If instance already exists and it's not this:
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
        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {
        //Call the SetupScene function of the BoardManager script, pass it current level number.
        // boardScript.SetupScene(level);
someoneWon = false;

        while (someoneWon)
        {
            CurrentPlayer = 1;
            TakeTurn();
            CurrentPlayer = 2;
            TakeTurn();

        }

    }



    //Update is called every frame.
    void Update()
    {

    }



    public void TakeTurn()
    {

        //(onClick events) can either:
        //click on tile -> go to tile + show card (stop watch while card is being displayed, but add time after card watched)
        //click on house -> if it's your house you won, HOWEVER if it'snot - u lose your turn or the game pending thorough A/B testing.
    }

    public void ClickTile() 
    {
        //Show card
        //If card is
    }
}