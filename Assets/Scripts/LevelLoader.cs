using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
