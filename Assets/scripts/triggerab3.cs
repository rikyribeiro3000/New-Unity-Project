using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class triggerab3 : MonoBehaviour
{
    public Transform warptarget;
    public bool triggerbb = false;
    public bool triggerbbw = false;
    void OnTriggerEnter2D(Collider2D other)

    {
        if (triggerbb == true)
        {
            gameover._gameortt.addtrys();
            gameover._gameortt.rgcw();
            gameover._gameortt.playerpos();
            
        }
        if (triggerbbw == true)
        {
            GameController._instance.TranstionToNextQuestion();
            controlos player = other.GetComponent<controlos>();
            
            other.gameObject.transform.position = warptarget.position;
            Camera.main.transform.position = warptarget.position;
            if (player.moveSpeed < 15) {player.moveSpeed = player.moveSpeed + 1; }

        }

    }
}
