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
    private AudioSource haha;
    void Start()
    {
        haha = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        playerpos1.transform.position = respawnp.transform.position;
        vida--;
        haha.Play();
        text.text = "X" + vida;
        if (vida == 0) 
        {
            textdisa.SetActive(false);
            LevelEnd.SetActive(true);
        }

    }
}
