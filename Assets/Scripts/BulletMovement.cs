using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BulletMovement : MonoBehaviour
{
    Rigidbody rbbullet;
    float bulletspeed = 50.0f;
    public GameObject pinkParticleEffect;
    public GameObject yellowParticleEffect;
    public AudioClip sound;
    AudioSource Bulletaudio;
    ScoreBoard scoreboard;
    // Start is called before the first frame update
    void Start()
    {
        rbbullet = GetComponent<Rigidbody>();
        Bulletaudio = GetComponent<AudioSource>();
        scoreboard = GameObject.Find("ScoreDisplay").GetComponent<ScoreBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        rbbullet.velocity = Vector3.forward * bulletspeed;

        if(scoreboard.score==50)
        {
            bulletspeed = 100.0f;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Bulletaudio.clip = sound;
            Bulletaudio.Play();
            scoreboard.Increment(5);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(pinkParticleEffect, transform.position, Quaternion.identity);
        }
       else  if (collision.gameObject.CompareTag("Alien"))
        {
            Bulletaudio.clip = sound;
            Bulletaudio.Play();
            scoreboard.Increment(10);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(yellowParticleEffect, transform.position, Quaternion.identity);
        }

        else
        {

            StartCoroutine("BulletAddToPool");
        }
     
    }
    IEnumerator BulletAddToPool()
    {
        yield return new WaitForSeconds(2);

        if (rbbullet.gameObject.name == "Bullet")
        {
            BulletSpawn.Instance.AddToPool(rbbullet.gameObject);
        }
    }
}