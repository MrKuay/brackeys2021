using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public bool fayeIsLeading = true;

    public KeyCode fayeInputKey;
    public KeyCode jairoInputKey;

    private bool fayeIsPressed;
    private bool jairoIsPressed;

    private float fayeInputTime;
    private float jairoInputTime;

    public float actionCooldown = 1.0f;
    private float lastActionInput;

    private bool actionIsAllowed = true;


    public Rigidbody fayeRigidbody;
    public Transform fayeTransform;
    public float fayeDashPower;
    public float fayeThrowPowerUp;
    public float fayeThrowPowerBehind;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(fayeInputKey) && !fayeIsLeading)
        {
            FayeAction();
        }

        if (Input.GetKeyDown(jairoInputKey) && fayeIsLeading)
        {
            JairoAction();
        }

        /*
        if(Time.time-lastActionInput > actionCooldown)
        {
            actionIsAllowed = true;
        }

        if (Input.GetKeyDown(fayeInputKey))
        {
            lastActionInput = Time.time;
            fayeIsPressed = true;
            fayeInputTime = Time.time;
        }
        if (Input.GetKeyDown(jairoInputKey))
        {
            lastActionInput = Time.time;
            jairoIsPressed = true;
            jairoInputTime = Time.time;
        }
        if (Input.GetKeyUp(fayeInputKey))
        {
            fayeIsPressed = false;
        }
        if (Input.GetKeyUp(jairoInputKey))
        {
            jairoIsPressed = false;
        }

        if (fayeIsPressed && jairoIsPressed && actionIsAllowed)
        {
            Debug.Log("both");
        } else if(fayeIsPressed && (Time.time-fayeInputTime) > inputDelay && fayeIsLeading && actionIsAllowed)
        {
            Debug.Log("Faye");
        } else if (jairoIsPressed && (Time.time - jairoInputTime) > inputDelay && !fayeIsLeading && actionIsAllowed)
        {
            Debug.Log("Jairo");
        }
       */

        void FayeAction()
        {
            fayeRigidbody.AddForce(fayeTransform.forward * fayeDashPower, ForceMode.Impulse);
        }

        void JairoAction()
        {
            fayeRigidbody.AddForce(fayeTransform.forward * fayeDashPower, ForceMode.Impulse);
        }

    }
}
