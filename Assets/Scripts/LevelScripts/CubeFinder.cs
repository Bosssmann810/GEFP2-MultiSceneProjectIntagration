using UnityEngine;
using TMPro;
public class CubeFinder : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Cube") == null)
        {
            text.text = "Where is the cube?";
        }
        if (GameObject.FindGameObjectWithTag("Cube") != null)
        {
            text.text = "Look at that cool cube";
        }
    }
}
