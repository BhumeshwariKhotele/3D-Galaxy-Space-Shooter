using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{


    Rigidbody tempRigidbody;
    //public GameObject bullet; //reference of the bullet
//AudioSource bulletaudio;

    void Start()
    {
        tempRigidbody = GetComponentInParent<Rigidbody>();
        //   bulletaudio = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            BulletPooling.Instance.SpawnBullet();
            StartCoroutine("DeactivateBullet");
        }

    }

    IEnumerator DeactivateBullet()
    {
        yield return new WaitForSeconds(5);
        BulletPooling.Instance.AddToBulletPool(tempRigidbody.gameObject);
    }

}
