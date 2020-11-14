using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingleton : MonoBehaviour
{
    private static MySingleton instance;
    public static MySingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<MySingleton>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(MySingleton).Name;
                    instance = obj.AddComponent<MySingleton>();
                }
            }
            return instance;
        }
    }

    public virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as MySingleton;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Call()
    {
        Debug.Log("Singleton is being called");
    }
    
}