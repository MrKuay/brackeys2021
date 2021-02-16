using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_testMechanic2D : MonoBehaviour
{
    // Start is called before the first frame update
    public float thrust = 1.0f;
    public float upThrow = 1.0f;
    public float backThrow = 1.0f;
    public Rigidbody2D rb;
    public Rigidbody2D Jrb;
    public Transform Jtrans;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddForce();
            //transform.position = new Vector3(0, -2f, 0);
            
        }
    }
    void AddForce()
    {
        rb.AddForce(transform.forward * thrust, ForceMode2D.Impulse);
        Jrb.AddForce(new Vector2(Jtrans.position.x-1, Jtrans.position.y+1) * upThrow, ForceMode2D.Impulse);
        //Jrb.AddForce(-transform.forward * backThrow, ForceMode2D.Impulse);
    }


}
