using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI scoreText;

    private int score = 0;
    public int Score => score;

    private void Awake()
    {
     
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        if (scoreText == null)
        {
            scoreText = (TextMeshProUGUI)GetComponent<TMP_Text>();
        }

        UpdateScoreUI();
    }

    public void AddScore(int amount = 1)
    {
        score += amount;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = $"score:{score}";
        }
    }
}