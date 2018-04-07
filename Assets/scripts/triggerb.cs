using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class triggerb : MonoBehaviour
{
    public bool triggerbb = false;
    public bool triggerbbw = false;
    public GameObject LevelEnd;
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
        }
        if (triggerbbw == true)
        {
            questionPanel.SetActive(false);

        }

    }
}
