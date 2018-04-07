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

        anima = GetComponent<Animator>();


    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 0));
        playermoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            playermoving = true;
            ultimomovimento = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);

        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            playermoving = true;
            ultimomovimento = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        anima.SetFloat("X", Input.GetAxisRaw("Horizontal"));
        anima.SetFloat("Y", Input.GetAxisRaw("Vertical"));
        anima.SetBool("playermoving", playermoving);
        anima.SetFloat("ultimoX", ultimomovimento.x);
        anima.SetFloat("ultimoY", ultimomovimento.y);



    }
}
