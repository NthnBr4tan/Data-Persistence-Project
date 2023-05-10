using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public Text NameInput;
    public Text BestScoreText;

    private void Start()
    {
        MenuPersistence.Instance.LoadHighscore();
        if (MenuPersistence.Instance.HighscoreName != null)
        {
            BestScoreText.text = "Best Score : " + MenuPersistence.Instance.HighscoreName + " : " + MenuPersistence.Instance.Highscore;
        }
        
    }
    public void StartGame()
    {
        MenuPersistence.Instance.Name = NameInput.text;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        MenuPersistence.Instance.SaveHighscore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
