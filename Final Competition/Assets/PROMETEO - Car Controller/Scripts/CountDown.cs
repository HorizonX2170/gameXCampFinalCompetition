using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class CountDown : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Image timeImage;
    [SerializeField] Text timeText;
    [SerializeField] float duration, currentTime;
    [SerializeField] Button restartButton;
    [SerializeField] Button quitButton;
    [SerializeField] Image elfin;
    [SerializeField] TextMeshProUGUI infoText;

    void Start()
    {
       panel.SetActive(false);
        currentTime = duration;
        timeText.text = currentTime.ToString();
        StartCoroutine(TimeIEn());
    }
    IEnumerator TimeIEn()
    {
        while(currentTime >= 0)
        {
            timeImage.fillAmount = Mathf.InverseLerp(0, duration, currentTime);
            timeText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        OpenPanel();
    }

    void OpenPanel()
    {
        timeText.text = "";
        panel.SetActive(true);

        // Show the buttons when the panel is active
        restartButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);

        // Stop the game sound when the panel is active
        AudioListener.pause = true;

        infoText.gameObject.SetActive(false);
        elfin.gameObject.SetActive(false);
        timeImage.gameObject.SetActive(false);
    }

    // Method to restart the game
    public void RestartGame()
    {
        // Resume the game sound before restarting
        AudioListener.pause = false;

        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Method to quit the game
    public void QuitGame()
    {
        // Resume the game sound before quitting
        AudioListener.pause = false;

        // Quit the application
        Application.Quit();

        // If running in the editor, stop play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
