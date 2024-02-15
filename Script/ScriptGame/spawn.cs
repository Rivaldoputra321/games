using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField]
        private GameObject[] trash;

        private BoxCollider2D col;

        float x1, x2;

    void Awake(){
        col = GetComponent<BoxCollider2D> ();
        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;
    }
    void Start()
    {
        StartCoroutine (Spawn(1f));

    }

    IEnumerator Spawn(float time){
         yield return new WaitForSecondsRealtime (time);

         Vector3 temp = transform.position;
         temp.x = Random.Range (x1, x2);
         Instantiate (trash[Random.Range(0, trash.Length)], temp, Quaternion.identity);

         StartCoroutine (Spawn(Random.Range(1f, 2f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
