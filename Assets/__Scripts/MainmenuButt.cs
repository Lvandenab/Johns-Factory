using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuButt : MonoBehaviour
{
    public void Onclick()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1.0f;
        
    }
}
