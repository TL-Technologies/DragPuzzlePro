using UnityEngine;
using UnityEngine.SceneManagement;

public class startscene : MonoBehaviour
{
    public void ButtonPlay()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    [ContextMenu("fkejgh")]
    public void Clear()
    {
        PlayerPrefs.DeleteAll();
    }
}
