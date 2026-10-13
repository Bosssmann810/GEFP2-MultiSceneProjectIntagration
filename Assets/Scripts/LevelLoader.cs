using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    bool level1loaded = false;
    bool level2loaded = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void LoadLevel1()
    {
        if (level1loaded== false)
        {
            level1loaded = true;
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        }
    }

    public void LoadLevel2()
    {
        if (level2loaded == false)
        {
            level2loaded = true;
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
