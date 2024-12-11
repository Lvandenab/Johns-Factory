using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCube : MonoBehaviour, IInteractable {
    public GameObject item;
    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
        Interactor.tool2 = true;
        Destroy(item);
        Debug.Log(Interactor.tool2);
        
    }

}
