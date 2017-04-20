using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerMovement : MonoBehaviour {

    public float playerSpeed;
    public float jumpSpeed;
    public Rigidbody rb;
    public bool onGround;
    public Animator anim;
    public GameObject playerCam;
    public float velocity;

    void Start()
    {
        //Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
        onGround = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Cursor.visible = true;
        }

        if (Input.GetButtonDown("Jump") && onGround == true)
        {
            rb.AddForce(Vector3.up * jumpSpeed);
            onGround = false;
            anim.SetBool("pBeeJ", true);
        }
        velocity = rb.velocity.y;
        anim.SetFloat("pBeeFall", velocity);

        if (Input.GetKeyDown("q"))
        {
            anim.SetTrigger("pBeeCry");
        }
        
        if (Input.GetKeyDown("b"))
        {
            anim.SetTrigger("pBeeDance");
        }
    }

    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        transform.Translate(moveH, 0, 0, Space.World);

        if (moveH != 0)
        {
            anim.SetBool("pBeeMove", true);
        }
        else
        {
            anim.SetBool("pBeeMove", false);
        }

        if (moveH < 0)
        {
            transform.rotation = Quaternion.AngleAxis(-90, Vector3.up);
        }
        else if (moveH > 0)
        {
            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }
    }

    void LateUpdate()
    {
        print(transform.position);
        playerCam.transform.position = transform.position + Vector3.back * 2f + Vector3.up * 0.5f;
    }

    void OnCollisionEnter(Collision groundCollide)
    {
        if (groundCollide.transform.position.y < transform.position.y)
        {
            onGround = true;
            anim.SetBool("pBeeJ", false);
            anim.SetTrigger("pBeeLanding");
        }
    }
}
