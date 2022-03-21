using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;


    //Static verdi�imiz zaman garbage collector ile temizlenmez.
    public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChanged;
    private void Awake()
    {
        SingletonThisGameObject();
    }


    private void SingletonThisGameObject()
    {
        //Singleton dizayn patern oldu�u i�in bu ismi tercih ettik.
        if (Instance == null)
        {
            //Mevcut class'�n referansini atadik.
            Instance = this;
            //Uzerinde oldugumuz bu nesneyi yok etme.
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //Ikinci obje olu�ursa yoket.
            Destroy(this.gameObject);
        }
    }
    public void IncreaseScore()
    {
        score += 10;
        OnScoreChanged?.Invoke(score);
    }
    public void StartGame()
    {
        score = 0;
        Time.timeScale = 1f;
        StartCoroutine(StartGameAsync());
    }
    private IEnumerator StartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("GameScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ReturnMenu()
    {
        StartCoroutine(ReturnMenuAsync());
    }
    public IEnumerator ReturnMenuAsync()
    {
        yield return SceneManager.LoadSceneAsync("MenuScene");
    }
}
