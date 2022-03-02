using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    private float elapsed = 0f;
    private Rigidbody2D rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
            rigidbody2D = GetComponent<Rigidbody2D>();
            
            Vector2 impulse = new Vector2(0, 680);
            rigidbody2D.AddForce(impulse);
       
    }

    // Update is called once per frame
    void Update()
    {
     elapsed += Time.deltaTime;
     if (elapsed >= 4f) {
         elapsed = elapsed % 4f;
			Destroy(gameObject);
     }   
    }
}
