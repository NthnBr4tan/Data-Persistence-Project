using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MenuPersistence : MonoBehaviour
{
    public static MenuPersistence Instance;

    public string Name;
    public string HighscoreName;
    public int Highscore;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public int Highscore;
        public string HighscoreName;
    }

    public void SaveHighscore()
    {
        SaveData data = new SaveData();
        data.Highscore = Highscore;
        data.HighscoreName = HighscoreName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighscore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighscoreName = data.HighscoreName;
            Highscore = data.Highscore;
        }
    }

}
