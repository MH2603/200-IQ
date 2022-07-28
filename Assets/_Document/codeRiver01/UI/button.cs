using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class button : MonoBehaviour
{

    public GameObject Menu;

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ON()
    {
        Menu.SetActive(true);
    }

    public void OFF()
    {
        Menu.SetActive(false);
    }


    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }


    public void QuitScene()
    {
        Application.Quit();
    }
}
