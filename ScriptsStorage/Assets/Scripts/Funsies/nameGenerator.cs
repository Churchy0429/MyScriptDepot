using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class nameGenerator : MonoBehaviour
{
    [SerializeField] string[] firstName;
    [SerializeField] string[] lastName;

    [SerializeField] Text nameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            nameText.text = firstName[Random.Range(0, firstName.Length)] + " " + lastName[Random.Range(0, lastName.Length)] + ".";
        }
    }
}
