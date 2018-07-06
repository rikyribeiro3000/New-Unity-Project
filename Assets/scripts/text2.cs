using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class text2 : MonoBehaviour {


    [SerializeField] public Text text;
    public int trys = 0;
    // Use this for initialization
    void Start () {
        Load();
        text.text = "X" + trys;
    }


    public void Load()
    {
        int[] loadedtrys = Save.LoadPlayer();
        trys = loadedtrys[0];
    }
}
