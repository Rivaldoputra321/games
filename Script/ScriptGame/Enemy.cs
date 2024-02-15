using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "trash")
        {
            HealthManager.health--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
