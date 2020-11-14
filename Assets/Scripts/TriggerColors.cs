using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColors : MonoBehaviour
{
    Renderer mat;
    [SerializeField]
    protected Color mainColor;
    [SerializeField]
    protected Color triggerColor;
    [SerializeField]
    protected bool triggerEnter;

    protected virtual void Start()
    {

        mat = GetComponent<Renderer>();
        mat.material.color = mainColor;
        Debug.Log(mat.material.ToString());

    }

    void Update()
    {

    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter");
        if (triggerEnter)
        {
            mat.material.color = triggerColor;
        }
    }

    //When the Primitive exits the collision, it will change Color
    protected virtual void OnTriggerExit(Collider other)
    {
        //Debug.Log("exit");
        if (!triggerEnter)
        {
            mat.material.color = triggerColor;
        }

    }
}
