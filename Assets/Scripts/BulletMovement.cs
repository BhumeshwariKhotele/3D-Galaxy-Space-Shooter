using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BulletMovement : MonoBehaviour
{
    Rigidbody rbbullet;
    float bulletspeed = 50.0f;
    public GameObject ParticleEffectPrefab;
    int Score;

    // Start is called before the first frame update
    void Start()
    {
        rbbullet = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        rbbullet.velocity = Vector3.forward * bulletspeed;


    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Score += 5;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(ParticleEffectPrefab, transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.CompareTag("Alien"))
        {
            Score += 10;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(ParticleEffectPrefab, transform.position, Quaternion.identity);
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