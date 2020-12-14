using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    float moveBuffer = 0.2f;
    float timer = 0f;

    References references;

    void Awake ()
    {
        references = FindObjectOfType<References>();
    }
    
    void Start()
    {
        ;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {

        timer += Time.deltaTime;

        if (timer > moveBuffer)
        {
            Vector3 movePos = this.transform.position;
            if (Input.GetAxisRaw("Vertical") > 0)
            {
                movePos = this.transform.position + Vector3.up;
            }
            if (Input.GetAxisRaw("Vertical") < 0)
            {
                movePos = this.transform.position + Vector3.down;
                this.transform.position = movePos;
            }
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                movePos = this.transform.position + Vector3.right;
                this.transform.position = movePos;
            }
            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                movePos = this.transform.position + Vector3.left;
                this.transform.position = movePos;
            }
            references.gameController.ObjectAt(movePos);
                //    this.transform.position = movePos;
                timer = 0f;
        }

    }
}
