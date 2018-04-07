using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour {

    public Transform warptarget;
    public GameObject questionPanel;


    IEnumerator OnTriggerEnter2D(Collider2D other) {
        controlos player = other.GetComponent<controlos>();
        player.moveSpeed = 0;
        Debug.Log("OBJECT COLIDED");
        screenfader sf = GameObject.FindWithTag("Fader").GetComponent<screenfader>();


        yield return StartCoroutine (sf.FadeToBlack());

        GameController._instance.TranstionToNextQuestion();
        questionPanel.SetActive(true);
        other.gameObject.transform.position = warptarget.position;
        Camera.main.transform.position = warptarget.position;


        yield return StartCoroutine(sf.FadeToClear());
        player.moveSpeed = 10;
        player.moveSpeed = player.moveSpeed + 1;

        Debug.Log("Pre fade in complete");
    }

}
