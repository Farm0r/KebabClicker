using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public float score = 0f;
    public float kebabsPerClick = 1f;
    public float kebabsPerSecond = 0f;

    public TextMeshProUGUI scoreText;

    [Header("Uppgraderingar")]
    public Upgrade[] upgrades;            // Lista med alla uppgraderingar
    public Button[] upgradeButtons;       // Knappar kopplade till varje uppgradering
    public TextMeshProUGUI[] upgradeTexts; // Text på varje knapp

    void Start()
    {
        UpdateUI();
        InvokeRepeating(nameof(AddPassive), 1f, 1f);
        RefreshUpgradeButtons();
    }

    public void AddScore()
    {
        score += kebabsPerClick;
        UpdateUI();
        RefreshUpgradeButtons();
    }

    public void BuyUpgrade(int index)
    {
        if (index < 0 || index >= upgrades.Length) return;

        Upgrade upg = upgrades[index];
        if (score >= upg.cost)
        {
            score -= upg.cost;
            kebabsPerSecond += upg.bonusPerSec;

            // Öka kostnaden varje gång (t.ex. 15% dyrare)
            upg.cost *= 1.15f;

            UpdateUI();
            RefreshUpgradeButtons();
        }
    }

    void AddPassive()
    {
        score += kebabsPerSecond;
        UpdateUI();
        RefreshUpgradeButtons();
    }

    void UpdateUI()
    {
        scoreText.text = "Kebabs: " + score.ToString("F1");
    }

    void RefreshUpgradeButtons()
    {
        for (int i = 0; i < upgrades.Length; i++)
        {
            if (upgradeTexts.Length > i)
                upgradeTexts[i].text = $"{upgrades[i].name} (+{upgrades[i].bonusPerSec}/s) Kostar: {upgrades[i].cost:F1}";

            if (upgradeButtons.Length > i)
                upgradeButtons[i].interactable = score >= upgrades[i].cost;
        }
    }
}

