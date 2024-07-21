using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    private Animator animator;
    private bool fire = true;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Link" || !fire)
            return;
        Destroy(other.transform.parent.gameObject);
        fire = false;
        animator.SetTrigger("trigger");
    }
}
