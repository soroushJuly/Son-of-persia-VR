using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brazier : MonoBehaviour
{
    public GameObject Fire;
    private void OnTriggerEnter(Collider other)
    {
        // Player Enter the area
        if (other.gameObject.name == "TorchHead")
        {
            Fire.SetActive(true);
        }
    }

}
