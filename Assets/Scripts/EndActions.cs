using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndActions : MonoBehaviour
{
    [SerializeField] private TMP_Text msgText;
    [SerializeField] private Button retryButton;
    [SerializeField] private Button resetButton;

    void Start()
    {
        string username = PlayerPrefs.GetString("username", "Player");
        msgText.text = $"Congratulations, {username}! You reached 10!";

        retryButton.onClick.AddListener(RetryAction);
        resetButton.onClick.AddListener(ResetAction);
    }

    private void RetryAction()
    {
        SceneManager.LoadScene("Game");
    }

    private void ResetAction()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("WelcomeMenu");
    }
}
