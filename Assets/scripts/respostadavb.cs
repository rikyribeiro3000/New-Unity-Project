using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class respostadavb : MonoBehaviour
{
    public bool triggerbby = false;
    public bool triggerbbwy = false;
    public GameObject textdisa;
    public GameObject Levelwin;
    public GameObject questionPanel;
    private AudioSource yey;

    void Start()
    {
        yey = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (triggerbby == true)
        {
            gameover._gameortt.addtrys();
            gameover._gameortt.rgcw();
            gameover._gameortt.playerpos();
            
        }
            if (triggerbbwy == true)
        {

            Levelwin.SetActive(true);
            yey.Play();
            textdisa.SetActive(false);
            questionPanel.SetActive(false);

        }

    }
}