using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standardStateMachine : MonoBehaviour
{
    public enemyStates currentState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case enemyStates.idle:
                {
                    break;
                }
            case enemyStates.moveToPoint:
                {
                    break;
                }
            case enemyStates.aggro:
                {
                    break;
                }
            case enemyStates.attack:
                {
                    break;
                }
            case enemyStates.takeDamage:
                {
                    break;
                }
            case enemyStates.death:
                {
                    break;
                }
        }
    }

    public enum enemyStates
    {
        idle,
        moveToPoint,
        aggro,
        attack,
        takeDamage,
        death,
    }
}
