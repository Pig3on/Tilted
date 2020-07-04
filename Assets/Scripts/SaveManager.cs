using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager SaveManagerInstance;

    private IDictionary<int, LevelScore> levelScoreDict;
    private void Awake()
    {
        if (!SaveManagerInstance)
        {
            this.LoadScore();
            SaveManagerInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }else
        {
            Destroy(this.gameObject);
        }
    }


    public void LoadScore()
    {
        var path = Application.persistentDataPath + "/LevelScores.dat";
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);
            levelScoreDict = (IDictionary<int, LevelScore>)bf.Deserialize(file);
            file.Close();
        }
        else
        {
            levelScoreDict = new Dictionary<int, LevelScore>();
        }
    }
    private void SaveScoreToDisk()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/LevelScores.dat");
        bf.Serialize(file, levelScoreDict);
        file.Close();
    }

    public IDictionary<int,LevelScore> GetScore()
    {
        return levelScoreDict;
    }

    public void SaveScore(int level, LevelScore score)
    {
      
       
        if (levelScoreDict.ContainsKey(level))
        {
            levelScoreDict.Remove(level);
        }
        levelScoreDict.Add(level, score);
        this.SaveScoreToDisk();
    }
}
