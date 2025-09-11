using UnityEngine;

public class UIWindows : MonoBehaviour
{
    [SerializeField] private GameObject settingsWindow;
    [SerializeField] private GameObject achievmentsWindow;
    [SerializeField] private GameObject leaderboardWindow;
    [SerializeField] private GameObject privacyWindow;

    private void Start()
    {
        settingsWindow.SetActive(false);
        achievmentsWindow.SetActive(false);
        leaderboardWindow.SetActive(false);
        privacyWindow.SetActive(false);
    }

    public void OpenSettingsWindow()
    {
        settingsWindow.SetActive(true);
    }

    public void OpenAchievementsWindow()
    {
        achievmentsWindow.SetActive(true);
    }

    public void OpenLeaderboardWindow()
    {
        leaderboardWindow.SetActive(true);
    }

    public void OpenPrivacyWindow()
    {
        privacyWindow.SetActive(true);
    }

    public void CloseAchievementsWindow()
    {
        achievmentsWindow.SetActive(false);
    }

    public void CloseLeaderboardWindow()
    {
        leaderboardWindow.SetActive(false);
    }
    
    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);
    }

    public void ClosePrivacyWindow()
    {
        privacyWindow.SetActive(false);
    }
}
