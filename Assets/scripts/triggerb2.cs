using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class triggerb2 : MonoBehaviour
{
    public bool triggerbb2 = false;
    public bool triggerbbw2 = false;
    public Transform warptarget;
    void OnTriggerEnter2D(Collider2D other)

    {
        if (triggerbb2 == true)
        {
            gameover._gameortt.addtrys();
            gameover._gameortt.rgcw();
            gameover._gameortt.playerpos();

        }
        if (triggerbbw2 == true)
        {
            GameController._instance.TranstionToNextQuestion();
            controlos player = other.GetComponent<controlos>();            
            other.gameObject.transform.position = warptarget.position;
            Camera.main.transform.position = warptarget.position;
            if (player.moveSpeed < 15) {player.moveSpeed = player.moveSpeed + 1; }
        }

    }
}
