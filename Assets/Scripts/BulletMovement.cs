using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity = Vector3.forward;
    }
  

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(velocity);
    }
}