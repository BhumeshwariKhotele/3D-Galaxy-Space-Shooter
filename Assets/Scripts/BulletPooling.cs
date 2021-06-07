using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooling: MonoBehaviour
{
    public GameObject Bullet;
   public GameObject currentbullet;

    Stack<GameObject> bulletPool = new Stack<GameObject>();  // created stack for bullet

    private static BulletPooling instance;

    public static BulletPooling Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<BulletPooling>();
            }
            return instance;
        }

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnBullet();
        }

    }
    private void Start()
    {
  
    }

   void CreateBullets()//to create the pool of tiles
    {
        
            bulletPool.Push(Instantiate(Bullet));
            bulletPool.Peek().SetActive(false);
            bulletPool.Peek().name = "Bullet";

    }

    public void AddToBulletPool(GameObject tempObj)
    {
        bulletPool.Push(tempObj);
        bulletPool.Peek().SetActive(false);

    }

    public void SpawnBullet()
    {
        if (bulletPool.Count == 0)
        {
            CreateBullets();
        }
        GameObject temp = bulletPool.Pop();
        temp.SetActive(true);
        temp.transform.position = transform.position;
        currentbullet = temp;
    }
}
