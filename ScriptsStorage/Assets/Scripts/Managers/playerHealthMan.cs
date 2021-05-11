using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealthMan : MonoBehaviour
{
    [SerializeField] int maxHealth;
    [SerializeField] int curHealth;
    [SerializeField] Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = curHealth.ToString() + " / " + maxHealth.ToString();
    }

    public void takeDamage(int damageTaken)
    {
        curHealth = curHealth - damageTaken;
    }
}
