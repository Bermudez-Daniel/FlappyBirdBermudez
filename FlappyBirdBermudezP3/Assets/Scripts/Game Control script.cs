using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlscript : MonoBehaviour {

    public static GameControlscript instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollspeed = -15f;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }



    // Update is called once per frame
    void Update() 
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    } 
     
     
     public void BirdDied()
        {
            gameOverText.SetActive(true);
        gameOver = true;
        }
    
}
