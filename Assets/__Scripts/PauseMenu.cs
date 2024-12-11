using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Menu;
    public static bool Paused;

    private void Start()
    {
        Menu.SetActive(false);
        Paused = false;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Paused)
            {
                Time.timeScale = 0.0f;
                Menu.SetActive(true);
                Paused=true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

            }
            else
            {
                Time.timeScale = 1.0f;
                Menu.SetActive(false);
                Paused=false;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
