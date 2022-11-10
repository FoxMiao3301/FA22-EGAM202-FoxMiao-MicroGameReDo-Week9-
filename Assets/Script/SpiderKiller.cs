using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderKiller : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "spider" && other.isTrigger)
        {

            Destroy(other.gameObject);
        }
    }
}
