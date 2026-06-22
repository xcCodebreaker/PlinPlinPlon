using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndActions : MonoBehaviour
{
    [SerializeField] private TMP_Text msgText;
    [SerializeField] private Button retryButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button resetButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        msgText.text = $"Congratulations, you wasted your time clicking buttons";

        retryButton.onClick.AddListener(retryAction);
        quitButton.onClick.AddListener(quitAction);
        resetButton.onClick.AddListener(resetAction);
    }

    private void retryAction()
    {
        SceneManager.LoadScene("Game");
    }

    private void quitAction()
    {
        SceneManager.LoadScene("WelcomeMenu");
    }

    private void resetAction()
    {
        SceneManager.LoadScene("WelcomeMenu");
    }
}
