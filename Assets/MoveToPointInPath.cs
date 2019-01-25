using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPointInPath : MonoBehaviour
{
    public string Name;
    public string color;
    public float moveSpeed = 0.4f;
    
    public GameObject Path;
    public GameObject Player;

    Node[] nodes;

    int currentNode;

    float Timer;
    Vector3 CurrentPosition;

    // Start is called before the first frame update
    void Start()
    {
        currentNode = 0;
        nodes = Path.GetComponentsInChildren<Node>();
    }

    private void CheckNode() {
        Timer = 0;
        CurrentPosition = nodes[currentNode].transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime * moveSpeed;

        if (Player.transform.position != CurrentPosition) {
            Player.transform.position = Vector3.Lerp(Player.transform.position, CurrentPosition, Timer);
        } else {
            if (currentNode < nodes.Length)
            {
                currentNode ++;
                CheckNode();
            }
        }
    }
}
