using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null; 
    bool someoneWon = false;
    int CurrentPlayer = 0;


    public string Name;
    public string color;
    public float moveSpeed = 0.4f;
    
    public GameObject Path;
    public GameObject Player;

    Node[] nodes;

    int currentNodeIndex;
    public int targetNodeIndex;

    float Timer;
    Vector3 CurrentPosition;

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
        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {
        //Call the SetupScene function of the BoardManager script, pass it current level number.
        // boardScript.SetupScene(level);
        Debug.Log("InitGame");
        someoneWon = false;
    }



    
    void setTargetIndex(int targetNodeIndex) 
    {
        this.targetNodeIndex = targetNodeIndex;
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