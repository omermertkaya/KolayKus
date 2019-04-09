using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;         //A reference to our game control script so we can access it statically.     
    public GameObject gameOvertext;             //A reference to the object that displays the text which appears when the player dies.
    public GameObject CanvasTwo;
    public Text scoreText;
    public bool gameOver = false;               //Is the game over?
    public float scrollSpeed = -1.5f;

    private int score = 0;



    void Awake()
    {
        //If we don't currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if (instance != this)
            //...destroy this one because it is a duplicate.
            Destroy(gameObject);
    }

    void Update()
    {
       //if (gameOver == true && Input.GetMouseButtonDown(0))
       // {
       //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      //}

    }

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "PUAN:" + score.ToString();
        SoundManager.PlaySound("sfx_point");

        
    }


    public void BirdDied()
    {
        //Activate the game over text.
        gameOvertext.SetActive(true);
        CanvasTwo.SetActive(true);
        //Set the game to be over.
        gameOver = true;
        
    }
}