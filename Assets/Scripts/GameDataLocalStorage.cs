using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class GameDataLocalStorage
{
    private static GameData data;

    public static void SaveScore(int score)
    {
        data.score = score;
        SaveData(data);
    }
    
    public static void SaveMusic(bool musicOn)
    {
        data.musicOn = musicOn;
        SaveData(data);
    }
    
    public static void SaveData(GameData gameData)
    {
        data = gameData;
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, gameData);
        file.Close();
    }

    public static GameData LoadData() // todo synchronized
    {
        if (data != null)
        {
            return data;
        }

        string destination = Application.persistentDataPath + "/save2.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else
        {
            data = new GameData(0, true);
            return data;
        }

        BinaryFormatter bf = new BinaryFormatter();
        GameData gameData = (GameData)bf.Deserialize(file);
        file.Close();

        data = gameData;
        return gameData;
    }
}

[System.Serializable]
public class GameData
{
    public int score;
    public bool musicOn;

    public GameData(int score, bool musicOn)
    {
        this.score = score;
        this.musicOn = musicOn;
    }
}