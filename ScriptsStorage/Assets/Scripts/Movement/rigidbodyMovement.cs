using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyMovement : MonoBehaviour
{
    [SerializeField] Animator anim;
    private Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float jumpPower;
    [SerializeField] float jumpHeight;
    [SerializeField] bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //anim.SetFloat("Speed", rb.velocity.magnitude);
        Debug.DrawRay(transform.position, Vector3.down * jumpHeight);
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit rHit;

        if(Physics.Raycast(ray, out rHit, jumpHeight))
        {
            if(rHit.collider == null)
            {
                canJump = false;
            }
            else
            {
                canJump = true;
            }
        }
        if(canJump == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpPower);
            canJump = false;
        }


    }

    private void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical") * speed;

        rb.AddRelativeForce(Vector3.forward * vertical);
    }

    void moveCharacter()
    {

    }
}
