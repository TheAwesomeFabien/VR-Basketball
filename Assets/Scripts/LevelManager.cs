using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float timeTillNextLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeTillNextLevel > 0)
        {
            timeTillNextLevel -= Time.deltaTime;
            if (timeTillNextLevel < 0)
            {
                LoadNextScene();
            }
        } else if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }
}
