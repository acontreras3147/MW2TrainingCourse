using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//template for objects to use during the game
public abstract class Interactable : MonoBehaviour
{
    public string messagePrompt;


    //player calls this function
    public void baseInteract() {
        Interact();
    }

    //objects that inherit this class will use this however necessary
    protected virtual void Interact() {}



}
