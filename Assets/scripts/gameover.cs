using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public bool playerd = false;
    int vida = 3;
    public GameObject LevelEnd;
    private Transform playerpos1;
    private Transform respawnp;
    void OnCollisionEnter2D(Collision2D other)
    {

        vida--;
        Debug.Log(vida);
        playerpos1.transform.position = respawnp.transform.position;
        if (vida == 0) 
        {
            LevelEnd.SetActive(true);
        }

    }
}
