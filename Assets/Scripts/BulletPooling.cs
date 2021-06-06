using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooling: MonoBehaviour
{
    public GameObject Bullet;
    public GameObject playerObj;
 
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

     private void Start()
    {
      PlayerMovement  playerObj = gameObject.GetComponent<PlayerMovement>();
    }

    void CreateBullets(int value)//to create the pool of tiles
    {
        for (int i = 0; i < value; i++)
        {
            bulletPool.Push(Instantiate(Bullet));
            bulletPool.Peek().SetActive(false);
        }

    }

    public void AddToBulletPool(GameObject tempObj)
    {
        bulletPool.Push(tempObj);
        bulletPool.Peek().SetActive(false);

    }

    public void SpawnBullet()
    {
        if(bulletPool.Count==0)
        {
            CreateBullets(20);
        }

        GameObject temp = bulletPool.Pop();
        temp.SetActive(true);
        temp.transform.position = playerObj.transform.position;
     
    }
}
