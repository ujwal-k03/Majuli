using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleInteraction : MonoBehaviour
{   
    int count = 0;
    int prevcount = -1;
    public int threshold = 200;
    bool beenHit = false;
    public Slider slider;
    public Canvas infoCanvas;
    public GameObject info;
    GameObject instantiatedInfo;
    // Start is called before the first frame update
    public void Hit()
    {   
        prevcount = count;
        count ++;
        count = Mathf.Clamp(count, 0, threshold);

        beenHit = true;
    }

    void Start()
    {
        slider.maxValue = threshold;
    }

    // Update is called once per frame
    void Update()
    {   
        if(beenHit)
            beenHit = false;
        else
            count = 0;

        slider.value = count;

        if(count == 0){
            Destroy(instantiatedInfo);
        }
        if(count == threshold && prevcount != threshold)
        {   
            instantiatedInfo = Instantiate(info, infoCanvas.transform);
            Debug.Log("Epic");
        }
    }
}
