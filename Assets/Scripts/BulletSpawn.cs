using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet; //reference of the bullet
//AudioSource bulletaudio;

    void Start()
    {
     //   bulletaudio = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bulletRef = Instantiate(bullet);
            bulletRef.transform.position = transform.position;
           // bulletaudio.Play();
        }

    }


}
