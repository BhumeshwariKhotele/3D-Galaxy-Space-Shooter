using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour


{

    public float playerSpeed;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * playerSpeed * Time.deltaTime);

    }
}
