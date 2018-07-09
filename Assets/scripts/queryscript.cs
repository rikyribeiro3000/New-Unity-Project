using UnityEngine;
using UnityEngine.UI;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



public class queryscript : MonoBehaviour
{

    public int trys = 0;
    [SerializeField] private Text text;
    public InputField name123;
    string ConnectionString ="Server=lhcp2010.webapps.net;Database=rw2vd834_leaderboard;Uid=rw2vd834_admin;Pwd=sapato2626";


    void Start()
    {                                                                                  
        Loaded();
        text.text = "X" + trys;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("Main");
    }

    public void Test()
    {
        try
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            Save.deletetry();
        if (name123.text == "")
            {
                name123.text = "anon";
            }

            string tt = "INSERT INTO leaderboard(`mortes`, `nome`) VALUES('" +trys+"','"+ name123.text + "')";

            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(tt, connection);

                //Execute command
                cmd.ExecuteNonQuery();

            //close connection
            connection.Close();
        }
        catch (Exception error)
        {
            Debug.Log(error);
        }
    }

    public void Loaded()
    {
        int[] loadedtrys = Save.LoadPlayer();
        trys = loadedtrys[0];
    }

}
