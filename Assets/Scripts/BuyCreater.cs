using System;
using UnityEngine;

public class BuyCreater : MonoBehaviour
{
    private Money Money;

    private void Awake()
    {
        Money = GetComponent<Money>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BuyTrigger")
        {
            GameObject Parent = other.transform.parent.gameObject;
            int Cost = Parent.GetComponent<CreaterOptions>().GetCost();

            if (Money._money >= Cost )
            {
                Buy(Parent.transform.GetChild(0).gameObject, Cost, other.gameObject);
            }
        }
    }

    private void Buy(GameObject obj, int cost, GameObject collider)
    {
        Money._money = Money._money - cost;
        Money.UpdateMoney();

        obj.SetActive(true);
        Destroy(collider.gameObject);

        obj.transform.GetChild(2).GetChild(0).GetComponent<CreateProduct>().ProductStart();
    }
}
