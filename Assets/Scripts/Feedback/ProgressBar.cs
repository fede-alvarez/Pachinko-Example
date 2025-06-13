using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [Header("Settings")]
    public float maxExperience = 100.0f;
    
    [Header("UI")]
    public TMP_Text experienceText;
    public Image progressBar;
    
    private float _experience;
    private bool _experienceAdded = false;
    
    public void AddExperience(float exp)
    {
        _experienceAdded = true;
        _experience += exp;
        UpdateTextValues();
    }

    private void Update()
    {
        bool hasReachedValue = Mathf.Approximately(progressBar.fillAmount, _experience / maxExperience);
        if (!hasReachedValue)
        {
            progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, _experience / maxExperience, Time.deltaTime * 2.0f);
        }
    }

    private void UpdateTextValues()
    {
        experienceText.text = _experience.ToString() + " / " + maxExperience.ToString();
    }
}
