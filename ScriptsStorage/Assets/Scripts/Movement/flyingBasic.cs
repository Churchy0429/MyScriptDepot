using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingBasic : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vert = Input.GetAxis("Vertical");


    }
}
