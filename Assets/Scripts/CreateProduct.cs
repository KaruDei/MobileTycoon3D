using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateProduct : MonoBehaviour
{
    [SerializeField] GameObject _createdObject;
    public void ProductStart()
    {
        StartCoroutine("Production");

        //StopCoroutine("Production");
    }

    public IEnumerator Production ()
    {
        while (true)
        {
            Instantiate(_createdObject, transform.position, Quaternion.Euler(0,0,0));
            yield return new WaitForSeconds(3);
        }
    }
}
