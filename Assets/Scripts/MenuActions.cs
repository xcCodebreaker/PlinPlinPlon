using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuActions : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private Button playButton;
    [SerializeField] private TMP_Text errorText;

    private void Start()
    {
        playButton.onClick.AddListener(PlayButton);
        errorText.gameObject.SetActive(false);
    }

    private void PlayButton()
    {
        string enteredName = nameInputField.text.Trim();

        if (string.IsNullOrEmpty(enteredName))
        {
            errorText.gameObject.SetActive(true);
            return;
        }

        SceneManager.LoadScene("Game");
    }
}