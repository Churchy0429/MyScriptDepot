using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMoveWDeathBox : MonoBehaviour
{
    [SerializeField] float camSpeed;
    [SerializeField] Transform targetPos;
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
        transform.position = Vector3.MoveTowards(transform.position, targetPos.position, camSpeed * Time.deltaTime);
    }
}
