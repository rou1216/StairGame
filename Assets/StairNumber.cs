using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairNumber : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        int n = 0;
        if (other.gameObject.CompareTag("Stairs"))
        {
            Destroy(other.gameObject);
            n++;
        }
    }
}
