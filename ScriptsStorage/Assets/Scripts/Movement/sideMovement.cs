using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideMovement : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody rb;
    [SerializeField] bool canJump;
    [SerializeField] float jumpHeight;
    [SerializeField] float jumpPower;
    [SerializeField] UIManager_One uiMan;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down * jumpHeight);
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit rHit;

        if (Physics.Raycast(ray, out rHit, jumpHeight))
        {
            if (rHit.collider == null)
            {
                canJump = false;
            }
            else
            {
                canJump = true;
            }
        }
        if (canJump == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpPower);
            canJump = false;
        }
    }

    private void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal") * speed;

        rb.AddRelativeForce(Vector3.right * horizontal);
    }
}
