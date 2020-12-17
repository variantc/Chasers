using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    float moveBuffer = 0.1f;
    float timer = 0f;

    References references;

    void Awake ()
    {
        references = FindObjectOfType<References>();
    }
    
    void Start()
    {
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        timer += Time.deltaTime;

        if (timer > moveBuffer)
        {
            Vector3 move = Vector3.zero;

            if (Input.GetAxisRaw("Vertical") > 0)
            {
                move = Vector3.up;
            }
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                move = Vector3.down;
            }
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                move = Vector3.right;
            }
            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                move = Vector3.left;
            }

            this.transform.position += move;
            
            timer = 0f;
        }

    }
}
