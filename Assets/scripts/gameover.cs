using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public bool playerd = false;
    int vida = 3;
    public GameObject LevelEnd;
    public GameObject textdisa;
    [SerializeField] private Transform playerpos1;
    [SerializeField] private Transform respawnp;
    [SerializeField] private Text text;
    void OnCollisionEnter2D(Collision2D other)
    {

        vida--;
        text.text= "X" + vida;
        playerpos1.transform.position = respawnp.transform.position;
        if (vida == 0) 
        {
            textdisa.SetActive(false);
            LevelEnd.SetActive(true);
        }

    }
}
