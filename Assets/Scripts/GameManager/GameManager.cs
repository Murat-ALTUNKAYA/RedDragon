using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Static verdi�imiz zaman garbage collector ile temizlenmez.
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        SingletonThisGameObject();
        RestartGame();
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
    public void RestartGame()
    {
        StartCoroutine(RestartGameAsync());
    }
    private IEnumerator RestartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("GameScene");
    }
}
