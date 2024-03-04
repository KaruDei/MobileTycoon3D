using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellZone : MonoBehaviour
{
    [SerializeField] private Money Money;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "product")
        {
            
            Money._money += 10;
            Money.UpdateMoney();
            Destroy(other.gameObject);
        }
    }
}
