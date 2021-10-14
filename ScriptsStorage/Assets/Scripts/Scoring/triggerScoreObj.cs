using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScoreObj : MonoBehaviour
{
    [SerializeField] int pointValue;
    [SerializeField] SCOREmANAGER scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreMan").GetComponent<SCOREmANAGER>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            scoreManager.score = scoreManager.score + pointValue;
            gameObject.SetActive(false);

        }
    }
}
