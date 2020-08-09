using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisolverInInventory : MonoBehaviour
{
    public Text displayText;
    public int disolverAmount;
    void Start()
    {
        DisolverUpdate();

    }

    // Update is called once per frame
  
        public void DisolverUpdate()
        {
            var Player = GameObject.Find("Player");
            PlayerController playerController = Player.GetComponent<PlayerController>();
            disolverAmount = playerController.disolver;

            displayText.text = disolverAmount.ToString();

        }

}
