using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class toplanan : MonoBehaviour
{
    public int score_meyve=0;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered!");
        if (other.gameObject.CompareTag("meyve"))
        {
            Destroy(other.gameObject);
            Debug.Log("a");
            score_meyve++;
        }
    }
}
