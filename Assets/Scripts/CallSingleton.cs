using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallSingleton : MonoBehaviour
{
    [SerializeField]
    private KeyCode key;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            MySingleton.Instance.Call();
        }
        
    }
}
