using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        print(collision.gameObject.name);
    }

/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
    }*/
}
