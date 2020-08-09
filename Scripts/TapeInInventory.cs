using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TapeInInventory : MonoBehaviour
{
    public Text displayText;
    public int tapeAmount;
    void Start()
    {
        TapeUpdate();
    }
    public void TapeUpdate()
    {
        var Player = GameObject.Find("Player");
        PlayerController playerController = Player.GetComponent<PlayerController>();
        tapeAmount = playerController.tape;

        displayText.text = tapeAmount.ToString();

    }


}
