using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager gameManagerObj;
    
    private void Awake()
    {

        //Ensure we have one game manager
        if (gameManagerObj == null)
        {
            gameManagerObj = this;
            DontDestroyOnLoad(this);
        }
        else if (gameManagerObj != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
