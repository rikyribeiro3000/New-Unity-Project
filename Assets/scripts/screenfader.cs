using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenfader : MonoBehaviour {

    Animator anim;
    public bool isFading = false;

    // Use this for initialization
    void Start() {
        anim = GetComponent<Animator>();
    }

    public IEnumerator FadeToClear()
    {
        isFading = true;
        anim.SetTrigger("Fadein");

        while (isFading)
            yield return null;
    }

    public IEnumerator FadeToBlack(){
        isFading = true;
        anim.SetTrigger("Fadeout");

        while (isFading)
            yield return null;
    }

    void AnimationComplete()
    {
        isFading = false;
    }
}
