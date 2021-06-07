using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{

    public Vector3 velocity;
    Rigidbody tempRigidbody;
    public float bulletSpeed;
    GameObject temp; //reference of the bullet
                     //AudioSource bulletaudio;

    void Start()
    {
        velocity = Vector3.forward;
        tempRigidbody = GetComponentInParent<Rigidbody>();
        //   bulletaudio = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    void Update()
    {
        this.transform.Translate(velocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Asteroid" || collision.gameObject.name == "Alien")
        {
            Destroy(collision.gameObject);
        }
        else
        {
            StartCoroutine("DeactivateBullet");
        }
    }

    IEnumerator DeactivateBullet()
    {
        yield return new WaitForSeconds(1f);
        if (tempRigidbody.gameObject.name == "Bullet")
        {
            BulletPooling.Instance.AddToBulletPool(tempRigidbody.gameObject);
        }
   }
}