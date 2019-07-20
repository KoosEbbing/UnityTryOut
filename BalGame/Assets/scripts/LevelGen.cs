using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Transfer");
    }
     IEnumerator Transfer()
        {
            yield return new WaitForSeconds(1);
        gameObject.transform.parent.position = new Vector3(0, -.5f, gameObject.transform.position.z + 200);
        }
    }



