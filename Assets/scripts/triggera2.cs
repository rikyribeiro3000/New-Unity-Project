using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class triggera2 : MonoBehaviour
{
    public bool triggeraa2 = false;
    public bool triggeraaw2 = false;
    public GameObject LevelEnd;
    public GameObject textdisa;
    public GameObject questionPanel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (triggeraa2 == true)
        {
            controlos player = other.GetComponent<controlos>();
            if (player == null)
                return;
            player.moveSpeed = 0;
            LevelEnd.SetActive(true);
            textdisa.SetActive(false);
        }
        if (triggeraaw2 == true)
        {
            GameController._instance.TranstionToNextQuestion();
            questionPanel.SetActive(false);

        }
    }
}
