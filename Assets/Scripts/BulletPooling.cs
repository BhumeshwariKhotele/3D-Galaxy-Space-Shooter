using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooling: MonoBehaviour
{
    Stack<GameObject> bulletPool = new Stack<GameObject>();  // created stack for bullet

    private static BulletPooling instance;

    public static BulletPooling Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<BulletPooling>();
            }
            return instance;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
