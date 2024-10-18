using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{

    [SerializeField] private Text currentScoreTxt;
    [SerializeField] private Text HighScoreTxt;

    private float currentScore = 0f;
    private float highScore = 0f;
    private float highestPoint = 0f;


    private Rigidbody2D _rb2d;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;
    
    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Score();
    }

    public void Shoot()
    {

        if (fuel > 9f)
        {
            fuel -= 10f;
            _rb2d.AddForce(Vector2.up * SPEED, ForceMode2D.Impulse);
        }

    }

    void Score()
    {
        currentScore = transform.position.y;; 

        if (currentScore > highestPoint)
        {
            highestPoint = currentScore;
            highScore = highestPoint;
        }

        currentScoreTxt.text = $"{currentScore.ToString("F0")} M";
        HighScoreTxt.text = $"HIGH: {highScore.ToString("F0")} M";
    }

    public void Click()
    {
        SceneManager.LoadScene("RocketLauncher");
    }
}
