using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class respostadava : MonoBehaviour
{
    public bool triggeraa = false;
    public bool triggeraaw = false;
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
        if (triggeraa == true)
        {
            gameover._gameortt.addtrys();
            gameover._gameortt.rgcw();
            gameover._gameortt.playerpos();
            
        }
        if (triggeraaw == true)
        {

            Levelwin.SetActive(true);
            yey.Play();
            questionPanel.SetActive(false);
            textdisa.SetActive(false);

        }
    }
}
