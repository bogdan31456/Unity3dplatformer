using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{Vector2 movementVector;
    // Start is called before the first frame update
    public float movementSpeed = 5f;
    public float jumpHeight = 15f;
    BoxCollider boxleCollider;
    Rigidbody rbody;
    public int deaths = 0;
    public Text deathText;

    /*public void KillMe()
    {
        deaths++;
        deathText.text = "Deaths: " + deaths;
    }*/
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        boxleCollider = GetComponent<BoxCollider>();
    }
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movementVector = new Vector2(horizontalInput * movementSpeed * 100 * Time.deltaTime, rbody.velocity.y);
        Debug.Log(Time.deltaTime);
        rbody.velocity = movementVector;
    }
    // Update is called once per frame
    void Update()
    {
       /* if (!boxleCollider.(LayerMask.GetMask("Ground")))
        {
            return;
        }*/
        if (Input.GetButtonDown("Jump"))
         {
               //Vector2 jumpVector = new Vector2(0f,jumpHeight);
             //    rbody.velocity += jumpVector;
             rbody.AddForce(Vector2.up * jumpHeight, ForceMode.Impulse);
         }

       /* if (characterController.isGrounded)
        {
            movementVector = transform.forward * movementSpeed * horizontalInput;
            //rotationVector = transform.up * rotationSpeed * horizontalInput;
            if (Input.GetButtonDown("Jump"))
            {
                movementVector.y = jumpHeight;
            }
        }*/
    }
}
