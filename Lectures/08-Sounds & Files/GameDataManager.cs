using System.IO;
using UnityEngine;

public class GameDataManager
{
    private GameData data;
    private string file = "gamedata.txt";

    public GameData Data => data;

    public void Load()
    {
        data = new GameData();
        string json = ReadFromFIle(file);
        JsonUtility.FromJsonOverwrite(json, data);
    }

    public void Save()
    {
        string json = JsonUtility.ToJson(data);
        WriteToFile(file, json);
    }

    private void WriteToFile(string fileName, string json)
    {
        string path = Application.persistentDataPath + "/" + fileName;
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }

    private string ReadFromFIle(string fileName)
    {
        string path = Application.persistentDataPath + "/" + fileName;
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else
        {
            Debug.LogWarning("File not found");
        }
        return "Success";
    }
}