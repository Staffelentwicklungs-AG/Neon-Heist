using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenueButtonManager : MonoBehaviour
{
    [SerializeField] private string gameSceneName;

    public void StartGamePressed()
    {
        Debug.Log($"{Pressed("Play")}");
        SceneManager.LoadSceneAsync(1);
    }

    public void OptionsPressed()
    {
        var text = Pressed("Options");
        Debug.Log(text);
    }
    private string Pressed(string button)
    {
        return button + " Button Pressed";
    }

    public void QuitPressed()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
