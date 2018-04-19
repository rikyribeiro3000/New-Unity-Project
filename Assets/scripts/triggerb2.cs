using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class triggerb2 : MonoBehaviour
{
    public bool triggerbb2 = false;
    public bool triggerbbw2 = false;
    public GameObject LevelEnd;
    public GameObject textdisa;
    public GameObject questionPanel;
    void OnTriggerEnter2D(Collider2D other)

    {
        if (triggerbb2 == true)
        {
            controlos player = other.GetComponent<controlos>();
            if (player == null)
                return;
            player.moveSpeed = 0;
            LevelEnd.SetActive(true);
            textdisa.SetActive(false);
        }
        if (triggerbbw2 == true)
        {
            questionPanel.SetActive(false);
            textdisa.SetActive(false);

        }

    }
}
