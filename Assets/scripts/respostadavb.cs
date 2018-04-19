using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class respostadavb : MonoBehaviour
{
    public bool triggerbby = false;
    public bool triggerbbwy = false;
    public GameObject LevelEnd;
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
            controlos player = other.GetComponent<controlos>();
            if (player == null)
                return;
            player.moveSpeed = 0;
            LevelEnd.SetActive(true);
            textdisa.SetActive(false);
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