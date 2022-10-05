using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerAction inputAction;
    Rigidbody rb;
    bool facingRight = true;

    private float distanceToGround;
    bool isGrounded = true;
    public float jump = 5f;
    public float driveSpeed = 5f;
    public Camera playerCamera;

    private bool isWalking = false;

    public GameObject projectile;
    public Transform projectilePos;

    public Transform model;

    private void Start() {

        inputAction = PlayerInputController.controller.inputAction;

        inputAction.Player.Jump.performed += cntxt => Jump();

        inputAction.Player.Turn.performed += cntxt => Turn();

        inputAction.Player.Shoot.performed += cntxt => Shoot();      

        rb = GetComponent<Rigidbody>();

        distanceToGround = GetComponent<Collider>().bounds.extents.y;
    }

    private void Jump()
    {
        if(isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            isGrounded = false;
        }
    }

    private void Turn()
    {
        facingRight = !facingRight;
        model.Rotate(Vector3.up, 180.0f);
        
    }

    private void Shoot()
    {
        if(!EditorManager.instance.editorMode)
        {
            Rigidbody bulletRb = Instantiate(projectile, projectilePos.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            bulletRb.AddForce(transform.up * 1f, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((facingRight ? Vector3.right : Vector3.left) * Time.deltaTime * driveSpeed, Space.Self);
        
        isGrounded = Physics.Raycast(transform.position, -Vector3.up, distanceToGround);
        Debug.DrawRay(transform.position, -Vector3.up * distanceToGround, Color.red);
    }
}
