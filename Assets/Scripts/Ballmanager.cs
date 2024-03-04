using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ballmanager : MonoBehaviour
{
    private Rigidbody2D rb;
    public GetName gn;
        
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.name == "White"){
            gameObject.transform.position = new Vector3(1, 1, 0);
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
        else
            Destroy(gameObject);
    }

}
