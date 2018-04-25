using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class respostadava : MonoBehaviour
{
    public bool triggeraa = false;
    public bool triggeraaw = false;
    public GameObject textdisa;
    public GameObject LevelEnd;
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
            controlos player = other.GetComponent<controlos>();
            if (player == null)
                return;
            player.moveSpeed = 0;
            LevelEnd.SetActive(true);
            textdisa.SetActive(false);
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
