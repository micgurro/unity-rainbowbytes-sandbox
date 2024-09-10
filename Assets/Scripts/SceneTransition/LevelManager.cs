using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace meekobytes { 
public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(int index)
    {
            SceneManager.LoadScene(index);
        }

    public void LoadMainMenu()
    {
        LoadScene(0);
    }

}
}