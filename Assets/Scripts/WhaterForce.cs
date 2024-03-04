using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaterForce : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if ( other.gameObject.layer == 4)
        {
            transform.GetComponent<Rigidbody>().AddForce(0, 12, 0);
        }
    }
}
