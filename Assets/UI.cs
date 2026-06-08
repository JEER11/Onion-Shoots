using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public static UI instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI ammoText;

    private int scoreValue;

    [Space]
    [SerializeField] private GunController gunController;
    [SerializeField] private GameObject TryAgainButton;



    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 1)
            timerText.text = Time.time.ToString("#,#");

    }

    public void AddScore()
    {
        scoreValue++;
        scoreText.text = scoreValue.ToString("#,#");
    }
    public void UpdateAmmoInfo(int currentBullets, int MaxBullets)
    {
        ammoText.text = currentBullets + "/" + MaxBullets;
    }

    public void OpenEndScreen()
    {
        //Debug.Log("Game Over screen activated");
        Time.timeScale = 0;
        TryAgainButton.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        //TryAgainButton.SetActive(false);
        SceneManager.LoadScene(0);
    }
}