using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("~ik");
    }
}