using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour {

    public bool menusenabled = true;
    public bool escapemode = false;
    public GameObject EscapeUI;

    // Used for Escape Menu Activiation
    public void EscMenu()
    {

        


    }
    // Used for Quitting the Escape Menu
    public void QuitEscMenu()
    {

        Debug.Log("QuitEscMenu()");


    }

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {

        
        if (menusenabled == true)

        {
            if (escapemode == false)
            {
                if (Input.GetKey(KeyCode.Escape))
                    // Note to Self: Always use KeyCode. To get Advanced Keyboard Inputs
                {

                    EscMenu();

                    escapemode = true;
                    // Used for Disabling the Escape Menu

                }

            }

            if (escapemode == true)
            {

                if (Input.GetKey(KeyCode.Escape))
                {

                    QuitEscMenu();

                    escapemode = false;
                    // Goes back to normal

                }

            }

        }

    }
}