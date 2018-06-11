using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class triggera : MonoBehaviour
{
    public Transform warptarget; //place where the target transports to
    public bool triggeraa = false;  // 2 boleans to check if the question is true or false and thus set triggeraa a or aw true
    public bool triggeraaw = false; // 2 boleans to check if the question is true or false and thus set triggeraa a or aw true

    void OnTriggerEnter2D(Collider2D other) //this only hapens if something colides with it 
    {
       if (triggeraa == true)   // if trigger a is true do all this functions 
       {
        gameover._gameortt.addtrys();
        gameover._gameortt.rgcw();
        gameover._gameortt.playerpos();

        }
       if (triggeraaw == true) //else do this functions 
       {
            GameController._instance.TranstionToNextQuestion(); //changes the question
            controlos player = other.GetComponent<controlos>(); //gets component of the player
            other.gameObject.transform.position = warptarget.position; //sets the player position to the warptarget position
            Camera.main.transform.position = warptarget.position; //transforms the camera position to the warptarget position
            if (player.moveSpeed < 15) { player.moveSpeed = player.moveSpeed + 1; } //player movespeed goes up by one until it hits 15 it starts with 10 

        }
    }
}
