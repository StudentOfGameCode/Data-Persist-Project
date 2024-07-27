using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public InputField nameInputField;
    public Button startButton;

    void Start()
    {
        if (nameInputField == null)
        {
            Debug.LogError("Name InputField is not assigned in the Inspector.");
            return;
        }

        if (startButton == null)
        {
            Debug.LogError("Start Button is not assigned in the Inspector.");
            return;
        }

        startButton.onClick.AddListener(SaveNameAndStartGame);
    }

    void SaveNameAndStartGame()
    {
        if (nameInputField.text == "")
        {
            Debug.LogError("Name InputField is empty.");
            return;
        }

        string playerName = nameInputField.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save(); // Save the changes
        SceneManager.LoadScene("main"); // Load the main game scene
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting!");
    }
}