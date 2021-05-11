using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Team Roster", menuName = "Team")]
public class teamRoster : ScriptableObject
{
    [SerializeField] string teamCity;
    [SerializeField] string teamName;
    [SerializeField] string teamAbb;

    public teamPlayer[] players;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
