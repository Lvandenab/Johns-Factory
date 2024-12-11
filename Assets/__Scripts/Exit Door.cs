using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interactcube2 : MonoBehaviour, IInteractable
{
    public GameObject item;
    public void Interact()
    {
        if (Interactor.tool1 == true && Interactor.tool2 == true && Interactor.tool3 == true)
        {
            Debug.Log("end game");
            SceneManager.LoadScene("WinScreen");
            Time.timeScale = 1.0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Destroy(item);
        }
        

    }

}