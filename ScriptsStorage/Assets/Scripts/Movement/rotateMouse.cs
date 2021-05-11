using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateMouse : MonoBehaviour
{
    [SerializeField] float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rot = Input.GetAxis("Mouse X") * turnSpeed;

        transform.Rotate(new Vector3(0, rot));
    }
}
