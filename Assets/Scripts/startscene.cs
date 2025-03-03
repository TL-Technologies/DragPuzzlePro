using UnityEngine;
using UnityEngine.SceneManagement;

public class startscene : MonoBehaviour
{
    public void ButtonPlay()
    {
        Ads.Instance.ShowAds();
        SceneManager.LoadScene("LevelSelection");
    }
}
