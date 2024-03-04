using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class L2bm : MonoBehaviour
{
    private Rigidbody2D rb;
    public GetName gn;
        
   private void OnTriggerEnter2D(Collider2D collision)
    {
        gn.Rescore(gameObject.name);
        gn.Ren();
        if(gameObject.name == "White"){
            gameObject.transform.position = new Vector3(1, 1, 0);
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
        else
            Destroy(gameObject);
    }

}
