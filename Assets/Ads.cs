using UnityEngine;

public class Ads : MonoBehaviour
{

    public static Ads Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        DontDestroyOnLoad(Instance);
    }

    void Start()
    {
        Advertisements.Instance.Initialize();
    }

    public void ShowAds()
    {
        Advertisements.Instance.ShowInterstitial();
    }
}
