using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager_One : MonoBehaviour
{
    [SerializeField] GameObject statusPanel;
    [SerializeField] Text status;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deathFunc()
    {
        statusPanel.SetActive(true);
        status.text = "You Lose";
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
