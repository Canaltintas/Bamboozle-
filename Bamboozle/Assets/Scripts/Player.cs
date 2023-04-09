using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform myTransform;

    private Rigidbody myRigidbody;
    private Animator myAnimator;
    public bool left, right, middle;
    public float speed = 50f;

    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        left = false;
        middle = true;
        right = false;
        //myTransform = this.gameObject.transform;
        // myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >20f)
        {
            speed = speed + 5f;
            timer = 0;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //myRigidbody.AddForce(transform.forward *speed);
        //transform.position = new Vector3(speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!right && middle)
            {
               // transform.Translate(3.68f,0,0);
               this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y,-3.68f);
              
                right = true;
                middle = false;
            }

            if (!middle && left)
            {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y,0f);
                middle = true;
                left = false;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (!left && middle)
            {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y,3.68f);
                left = true;
                middle = false;
            }

            if (!middle && right)
            {
                this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y,0f);
                middle = true;
                right = false;
            }
            
        }
    }
}
