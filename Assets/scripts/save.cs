using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

public static class Save
{

    public static void Savetry(gameover trys)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "/player.tet", FileMode.Create);

        PlayerData data = new PlayerData(trys);

        bf.Serialize(stream, data);
        stream.Close();
    }

    public static void deletetry()
    {
        File.Delete(Application.persistentDataPath + "/player.tet");
    }


    public static int[] LoadPlayer()
     {
         if (File.Exists(Application.persistentDataPath + "/player.tet"))
         {
             BinaryFormatter bf = new BinaryFormatter();
             FileStream stream = new FileStream(Application.persistentDataPath + "/player.tet", FileMode.Open);

             PlayerData data = bf.Deserialize(stream) as PlayerData;
             stream.Close();
             return data.trysa;
         } else
            {
            Debug.LogError("something");
            return new int[0];
            }
     }
}
[Serializable]
public class PlayerData
 {
    public int[] trysa;

     public PlayerData(gameover trys)
    {
        trysa = new int[1];
        trysa[0] = trys.trys;
    }
 }
 