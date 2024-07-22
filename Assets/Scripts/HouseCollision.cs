using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCollision : MonoBehaviour
{
    public GameObject projectilePrefab = null;
    public AudioSource AudioSource = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // Player Enter the area
        if (other.gameObject.name == "XR Origin (XR Rig)")
        {
            AudioSource.mute = true;
        }
        Debug.Log(other.gameObject.name);
        // XR Origin XR Rig
    }
    private void OnTriggerExit(Collider other)
    {
        // Player Enter the area
        if (other.gameObject.name == "XR Origin (XR Rig)")
        {
            AudioSource.mute = false;
        }
        Debug.Log(other.gameObject.name);
    }
}
