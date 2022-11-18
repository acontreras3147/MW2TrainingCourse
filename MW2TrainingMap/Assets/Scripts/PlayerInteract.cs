using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    public float distance = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //assigning this cam instance to the same as playerLook
        cam = GetComponent<PlayerLook>().cam;
        //use raycast to help detect collisions

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
    }
}
