using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class triggera2 : MonoBehaviour
{
    public Transform warptarget;
    public bool triggeraa2 = false;
    public bool triggeraaw2 = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (triggeraa2 == true)
        {
            gameover._gameortt.addtrys();
            gameover._gameortt.rgcw();
            gameover._gameortt.playerpos();
            
        }
        if (triggeraaw2 == true)
        {
            GameController._instance.TranstionToNextQuestion();
            controlos player = other.GetComponent<controlos>();          
            other.gameObject.transform.position = warptarget.position;
            Camera.main.transform.position = warptarget.position;
            if (player.moveSpeed < 15) {player.moveSpeed = player.moveSpeed + 1; }
        }
    }
}
