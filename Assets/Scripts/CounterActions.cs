using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CounterActions : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private Button incrementButton;
    [SerializeField] private Button decrementButton;

    private int currentValue;

    private void Start()
    {
        currentValue = 0;
        UpdateScore();

        incrementButton.onClick.AddListener(Increment);
        decrementButton.onClick.AddListener(Decrement);
    }

    private void Increment()
    {
            currentValue++;
            ScoreHandler();
    }

    private void Decrement()
    {
        if(currentValue <= 10 && currentValue != 0)
        {
            currentValue--;
            ScoreHandler();
        }
   
    }

    private void ScoreHandler()
    {
        UpdateScore();

        if (currentValue == 10)
        {
            SceneManager.LoadScene("EndScene");
        }
   
    }

    private void UpdateScore()
    {
        scoreText.text = currentValue.ToString();
    }
}