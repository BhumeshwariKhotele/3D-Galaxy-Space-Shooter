using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public GameObject currentbullet;
    Stack<GameObject> BulletPool = new Stack<GameObject>();
    private static BulletSpawn instance;

    public static BulletSpawn Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<BulletSpawn>();
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
        if (Input.GetButtonDown("Fire1"))
        {
            BulletCreation();
        }

    }
    public void CreatePool()
    {
        
            BulletPool.Push(Instantiate(bullet));
            BulletPool.Peek().SetActive(false);
            BulletPool.Peek().name = "Bullet";
        

    }
    public void AddToPool(GameObject bullettemp)
    {
        BulletPool.Push(bullettemp);
        BulletPool.Peek().SetActive(false);
    }
    public void BulletCreation()
    {
        if (BulletPool.Count == 0)
        {
            CreatePool();
        }
        GameObject temp = BulletPool.Pop();
        temp.SetActive(true);
        temp.transform.position = transform.position;
        currentbullet = temp;
    }
}