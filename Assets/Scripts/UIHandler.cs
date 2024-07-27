using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.UnloadSceneAsync("start menu");
        SceneManager.LoadScene("main");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting!");
    }
}
