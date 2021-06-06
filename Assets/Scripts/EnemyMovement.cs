using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement: MonoBehaviour
{
    private Transform myTransform;
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;

    }

    // Update is called once per frame
    void Update()
    {
        myTransform.Translate(Vector3.back * speed * Time.deltaTime);

    }
  /*  private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            Destroy(gameObject);
        }
    }
}
