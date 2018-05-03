using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlos : MonoBehaviour
{

    public float moveSpeed;

    private Animator anima;

    public bool playermoving;
    private Vector2 ultimomovimento;

    void Start()
    {
        //get the component animator
        anima = GetComponent<Animator>();


    }

    void Update()
    {
        //player default setting is not moving so its false
        playermoving = false;
        //if the input is horizontal wich means the x is bigger then 0.5 or smaller then -0.5 then transform the position of the player multiplying the movespeed and the deltatime 
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playermoving = true;
            ultimomovimento = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);

        }
        ////if the input is horizontal wich means the y is bigger then 0.5 or smaller then -0.5 then transform the position of the player multiplying the movespeed and the deltatime 
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            playermoving = true;
            ultimomovimento = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        //this block of anima just says that if the input was vertical then play one of the animations  also have the bolean playermoving wich says
        //if the player is idle or not and if it is ultimoX and ultimoY will check if i has to face up,down,left or ritgh
        anima.SetFloat("X", Input.GetAxisRaw("Horizontal"));
        anima.SetFloat("Y", Input.GetAxisRaw("Vertical"));
        anima.SetBool("playermoving", playermoving);
        anima.SetFloat("ultimoX", ultimomovimento.x);
        anima.SetFloat("ultimoY", ultimomovimento.y);



    }
}
