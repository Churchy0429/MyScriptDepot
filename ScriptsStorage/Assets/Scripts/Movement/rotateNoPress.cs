using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateNoPress : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 rotDir;
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
        transform.Rotate(rotDir * speed);
    }
}
