using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;


public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] InputField Username;

    private void Update()
    {
        NameSelected();
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR 
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void NameSelected()
    {
        MainManager2.Instance.Username = Username.text;
    }
    
}
