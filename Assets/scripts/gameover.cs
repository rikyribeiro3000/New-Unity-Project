using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public int hit = 25;
    public int rgc = 0;
    public static gameover _gameortt;
    public List<AudioClip> taunt = new List<AudioClip>();
    public int trys = 0;                                                                                // A variable that counts how many lifes u have u inicially start with 3 
    public GameObject LevelEnd;                                                                         // A game object that is here becase if the number of lifes is 0 then activate this game scene
    public GameObject textdisa;                                                                         // This one makes the text dissapear
    public Transform playerpos1;                                                      // This variable is here because of the checkpoints                                                      
    [SerializeField] private Transform respawnp;                                                        // the place where the player respawns
    [SerializeField] private Transform pussypoint;                                                      // this is the checkpoint but i think its pretty obvius
    [SerializeField] private Text text;                                                                 // this is to make the text of the lifes dissapear
    void Start()                                                                                        // on void start get the audiosource haha
    {
        if (_gameortt == null) {
             _gameortt = this;
        }
        Load();
        text.text = "X" + trys;
    }
    public void Load()
        { 
            int[] loadedtrys = Save.LoadPlayer();
            trys = loadedtrys[0];
            
        }
    void OnCollisionEnter2D(Collision2D other)                 
    {
        ///<summary>
        ///on colision with a hitbox i made previosly set minus 1 life play the haha sound and change the text of the lifes to the value of the variable
        ///if the lifes equal 0 then the textdissapears and set the levelendscene active
        ///
        ///</summary>
        addtrys();
        rgcw();
        playerpos();

     
    }
    public void addtrys()
    {
        trys++;
        text.text = "X" + trys;
        Save.Savetry(this);
    }
   public void rgcw()
    {
        rgc = Random.Range(0, 100);
        if (hit >= rgc)
        {
            transform.GetComponent<AudioSource>().clip = taunt[Random.Range(0, taunt.Count)];
            transform.GetComponent<AudioSource>().Play();
        }

    }
    public void playerpos()
    {
        if (GameController._instance.checkpoint == 0)
        {
            playerpos1.transform.position = respawnp.transform.position;
        }

        else if (GameController._instance.checkpoint == 1)
        {
            playerpos1.transform.position = pussypoint.transform.position;
        }
    }
}           

