using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class triggera : MonoBehaviour
{
    public bool triggeraa = false;
    public bool triggeraaw = false;
    public GameObject LevelEnd;
    public GameObject textdisa;
    public GameObject questionPanel;

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
                GameController._instance.TranstionToNextQuestion();
                questionPanel.SetActive(false);

            }
    }
}
