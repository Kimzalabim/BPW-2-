using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public Text scoreText;
    public int tapeAmount;
    public int disolverAmount;
 

    void Start()
    {
        //GameObject.Find(Player).GetComponent<PlayerController>().tape;
        TapeUpdate();
        DisolverUpdate();
    }

    void Update()
    {
        //ScoreUpdate();
    }

    public void TapeUpdate()
    {
        var Player = GameObject.Find("Player");
        PlayerController playerController = Player.GetComponent<PlayerController>();
        tapeAmount = playerController.tape;

        scoreText.text = tapeAmount.ToString();

    }

    public void DisolverUpdate()
    {
        var Player = GameObject.Find("Player");
        PlayerController playerController = Player.GetComponent<PlayerController>();
        disolverAmount = playerController.disolver;

        scoreText.text = disolverAmount.ToString();

    }
}
