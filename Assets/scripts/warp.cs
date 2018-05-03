using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour {

    public Transform warptarget; // postion where to teleporte
    public GameObject questionPanel; // question panel to make it disapear
    public GameObject testdisa; // and the text to make it disapear also 


    IEnumerator OnTriggerEnter2D(Collider2D other) {
        controlos player = other.GetComponent<controlos>();
        player.moveSpeed = 0;
        screenfader sf = GameObject.FindWithTag("Fader").GetComponent<screenfader>();

        testdisa.SetActive(false);
        yield return StartCoroutine (sf.FadeToBlack());
        GameController._instance.TranstionToNextQuestion();
        questionPanel.SetActive(true);
        other.gameObject.transform.position = warptarget.position;
        Camera.main.transform.position = warptarget.position;

        yield return StartCoroutine(sf.FadeToClear());
        testdisa.SetActive(true);
        player.moveSpeed = 10;
        player.moveSpeed = player.moveSpeed + 1;
    }

}
