using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class triggera3 : MonoBehaviour
{
    public Transform warptarget;
    public bool triggeraa3 = false;
    public bool triggeraaw3 = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (triggeraa3 == true)
        {
            gameover._gameortt.addtrys();
            gameover._gameortt.rgcw();
            gameover._gameortt.playerpos();
            
        }
        if (triggeraaw3 == true)
        {
            GameController._instance.TranstionToNextQuestion();
            controlos player = other.GetComponent<controlos>();
            GameController._instance.checkpoint = 1;
            other.gameObject.transform.position = warptarget.position;
            Camera.main.transform.position = warptarget.position;
            if (player.moveSpeed < 15) { player.moveSpeed = player.moveSpeed + 1;}
        }
    }
}
