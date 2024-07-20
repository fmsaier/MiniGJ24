using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Link" )
            return;
        Destroy(other.transform.parent.gameObject);
        Destroy(gameObject);
    }
}
