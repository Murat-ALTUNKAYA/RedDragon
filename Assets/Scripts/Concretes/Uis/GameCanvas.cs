using RedDragon.Combat;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        private void Awake()
        {
            //Oyun i�inden atama yapmak yerine farkl� bi y�ntem olarak yap�labilir.
            gameOverPanel = transform.GetChild(1).gameObject;
        }
        private void Start()
        {
            //B�t�n gameobject'lere bak�yor ve bunlar�n i�inden Death olan� ar�yor.
            //Buldu�unda da atamas�n� yap�yor.
            Death death = FindObjectOfType<Death>();
            death.OnDeath += HandleOnDeath;
        }

        private void HandleOnDeath()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

