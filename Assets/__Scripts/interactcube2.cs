using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCube : MonoBehaviour, IInteractable {
    public GameObject item;
    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
        Interactor.tool3 = true;
        Destroy(item);
        Debug.Log(Interactor.tool3);
        
    }

}
