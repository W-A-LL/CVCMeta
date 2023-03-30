using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class CameraNetwork : NetworkBehaviour
{

    // Update is called once per frame
    private void Awake()
    {
        if (IsOwner)
        {
            gameObject.GetComponent<Camera>().enabled = true;
          
        }
    }

    // Update is called once per frame
   /* 
    private void Update()
    {
        if (!IsOwner) return;

        gameObject.GetComponent<Camera>().enabled = true;
    }
   */
}
