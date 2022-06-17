using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour
{

    public GameObject money_0;
    public GameObject moneyPosition;
    public GameObject Hero;
    List<GameObject> MoneyForRemove = new List<GameObject>();

    void FixedUpdate()
    {
        if(Shop.WhipperNumber==0)
        {
            foreach(GameObject x in MoneyForRemove)
            {
                Destroy(x);
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Money")
        {
            Shop.WhipperNumber +=1;
            float y=(float)Shop.WhipperNumber/5;
            
            GameObject AllMoney = Instantiate(money_0,new Vector3(moneyPosition.transform.position.x,moneyPosition.transform.position.y+y,moneyPosition.transform.position.z),Quaternion.identity);
            AllMoney.transform.SetParent(Hero.gameObject.transform);
            MoneyForRemove.Add(AllMoney);
            Destroy(other.gameObject);
        }

    }
}
