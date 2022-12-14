using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : Interactable
{
    public static bool isActive = false;
    public static int pressCounter = 0;
    public static AudioSource audioKeyPad;
   
    
    private void Awake()
    {
        audioKeyPad = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //override interact with desired functionality of this object
    protected override void Interact()
    {
        isActive = true;
        pressCounter++;

    }
}
