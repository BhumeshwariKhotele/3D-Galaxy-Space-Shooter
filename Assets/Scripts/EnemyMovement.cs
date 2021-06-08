using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(transform.position.z<-20f)
        {
            Destroy(this.gameObject);
        } 
    }
 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            SceneManager.LoadScene(2);

        }
    }
}
