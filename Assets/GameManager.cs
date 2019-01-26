using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null; 
    bool someoneWon = false;
    int CurrentPlayer = 0;

    public bool shouldShowCard = false;

    public string Name;
    public string color;

   
    public float moveSpeed = 0.4f;
    
    public GameObject Path;
    public GameObject Player;

    Node[] nodes;

    int currentNodeIndex;
    int targetNodeIndex ;

    float Timer;
    Vector3 CurrentPosition;

    public GameObject gameOverPanel;
    public Text gameOverText;

     internal void WinGame()
    {
        throw new NotImplementedException();
    }

    internal void GameOver()
    {
        Debug.Log("GameManager GAME OVER!");
        string text;
        switch (targetNodeIndex) {
            case 1 : text = "You didn't even try!";
            break;
            case 2:text = "Come on! it was the yellow one!";
            break;
            case 3:text = "Now you are dead.";
            break;
            case 4:text = "Wrong House...";
            break;
            case 5:text = "House is wrong!";
            break;
            case 6:text = "HAHA! You lost!";
            break;
            case 7:text = "Winn...nah, you lost!";
            break;
            case 8:text = ":(";
            break;
            case 9:text = "Nothing to see here, move along";
            break;
            case 10:text = "You stop that!";
            break;
            case 11:text = "GRRRRR!";
            break;
            case 12:text = "This is SPARTAAAA!";
            break;
            case 13:text = "Godmode = false";
            break;
            case 14:text = "No!";
            break;
            case 15:text = "Use cheat code next time!";
            break;
            default:text = "Game Over!";
            break;
        }
        gameOverText.text = text;
        gameOverPanel.SetActive(true);
    }


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {

        }

        InitGame();
    }

    void InitGame()
    {
        Debug.Log("InitGame");
        someoneWon = false;
    }
    
    public void SetTargetIndex(int targetNodeIndex) 
    {
        this.targetNodeIndex = targetNodeIndex;
        shouldShowCard = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentNodeIndex = 0;
        nodes = Path.GetComponentsInChildren<Node>();
        CheckNode();
    }

    private void CheckNode() {
        Timer = 0;
        CurrentPosition = nodes[currentNodeIndex].transform.position;
        Debug.Log("currentNode:"+currentNodeIndex + " position:"+CurrentPosition);
    }
    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime * moveSpeed;

        if (Player.transform.position != CurrentPosition) 
        {
            Player.transform.position = Vector3.Lerp(Player.transform.position, CurrentPosition, Timer);
        }
        else 
        {
            if (targetNodeIndex != currentNodeIndex)
            {
                currentNodeIndex++;          
                if (currentNodeIndex >= nodes.Length)
                {
                    currentNodeIndex = 0;
                }  
                CheckNode();
            }
            else 
            {
                if (shouldShowCard == true) {
                    CardSpawnManager.instance.ShowCard(targetNodeIndex);    
                    shouldShowCard = false;
                }
             
            }
           
        }
        
    }

    public void ShowCard() {
        Debug.Log("Showing card");
    }

    public void TakeTurn()
    {
        //(onClick events) can either:
        //click on tile -> go to tile + show card (stop watch while card is being displayed, but add time after card watched)
        //click on house -> if it's your house you won, HOWEVER if it'snot - u lose your turn or the game pending thorough A/B testing.
        Debug.Log("CurrentPlayer:" + CurrentPlayer + " TakeTurn");
    }


    public void ClickHouse()
    {
        //Show card
        //If card is
        Debug.Log("CurrentPlayer:" + CurrentPlayer + " ClickHouse");
    }
}