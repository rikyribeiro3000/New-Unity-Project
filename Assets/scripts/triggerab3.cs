using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class triggerab3 : MonoBehaviour
{
    public bool triggerbb = false;
    public bool triggerbbw = false;
    public GameObject LevelEnd;
    public GameObject textdisa;
    public GameObject questionPanel;
    void OnTriggerEnter2D(Collider2D other)

    {
        if (triggerbb == true)
        {
            controlos player = other.GetComponent<controlos>();
            if (player == null)
                return;
            player.moveSpeed = 0;
            LevelEnd.SetActive(true);
            textdisa.SetActive(false);
        }
        if (triggerbbw == true)
        {
            GameController._instance.checkpoint = 1;
            questionPanel.SetActive(false);
            textdisa.SetActive(false);

        }

    }
}
