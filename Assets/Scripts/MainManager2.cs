using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager2 : MonoBehaviour
{
    public static MainManager2 Instance;

    public string Username;
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

}
