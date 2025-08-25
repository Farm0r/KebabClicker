using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{
    public float score = 0f;               // Dina kebabs
    public float kebabsPerClick = 1f;      // Po�ng per klick
    public float kebabsPerSecond = 0f;     // Passiv po�ng per sekund

    public TextMeshProUGUI scoreText;      // Text som visar po�ngen

    void Start()
    {
        UpdateUI();
        // K�r AddPassive varje sekund
        InvokeRepeating(nameof(AddPassive), 1f, 1f);
    }

    // Klick p� kebab-knappen
    public void AddScore()
    {
        score += kebabsPerClick;
        UpdateUI();
    }

    // K�p grill som ger passiva kebabs
    public void BuyGrill()
    {
        float cost = 10f;
        if (score >= cost)
        {
            score -= cost;
            kebabsPerSecond += 0.1f; // Nu ger den 0.1 kebab/s
            UpdateUI();
        }
    }

    // Passiv inkomst
    void AddPassive()
    {
        score += kebabsPerSecond;
        UpdateUI();
    }

    void UpdateUI()
    {
        // Visar 1 decimal, t.ex. 12.3
        scoreText.text = "Kebabs: " + score.ToString("F1");
    }
}

