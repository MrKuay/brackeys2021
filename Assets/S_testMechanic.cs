using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_testMechanic : MonoBehaviour
{
    // Start is called before the first frame update
    public float thrust = 1.0f;
    public float upThrow = 1.0f;
    public float backThrow = 1.0f;
    public float bonusGravity = 1.0f;
    public Rigidbody rb;
    public Rigidbody Jrb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        AddBonusGravity();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddForce();
        }
    }
    void AddForce()
    {
        rb.AddForce(transform.forward * thrust, ForceMode.Impulse);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "J")
        {
            Jrb.AddForce(transform.up * upThrow, ForceMode.Impulse);
            Jrb.AddForce(-transform.forward * backThrow, ForceMode.Impulse);
        }
    }
    void AddBonusGravity()
    {
        rb.AddForce(-transform.up * bonusGravity);
        Jrb.AddForce(-transform.up * bonusGravity);
    }
}
