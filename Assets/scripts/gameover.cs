using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public bool playerd = false;
    public int vida = 3;
    public GameObject LevelEnd;
    public GameObject textdisa;
    [SerializeField] private Transform playerpos1;
    [SerializeField] private Transform respawnp;
    [SerializeField] private Transform pussypoint;
    [SerializeField] private Text text;
    private AudioSource haha;
    void Start()
    {
        haha = GetComponent<AudioSource>();
     
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        vida--;
        haha.Play();
        text.text = "X" + vida;
        if (vida == 0) 
        {
            textdisa.SetActive(false);
            LevelEnd.SetActive(true);
        }
         if (GameController._instance.checkpoint>= 0 && GameController._instance.checkpoint <= 3)
        {
            playerpos1.transform.position = respawnp.transform.position;

        }

       else if (GameController._instance.checkpoint >= 4)
        {
            playerpos1.transform.position = pussypoint.transform.position;
        }

            

    }
}
