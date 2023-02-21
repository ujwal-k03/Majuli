using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRayCast : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCamera;
    public LayerMask cameraMask;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        var ray = new Ray(mainCamera.transform.position, mainCamera.transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, maxDistance: 100, layerMask: cameraMask))
        {   
            hit.transform.GetComponent<HandleInteraction>().Hit();
        }
    }
}
