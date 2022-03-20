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
            //Oyun içinden atama yapmak yerine farklý bi yöntem olarak yapýlabilir.
            gameOverPanel = transform.GetChild(1).gameObject;
        }
        private void Start()
        {
            //Bütün gameobject'lere bakýyor ve bunlarýn içinden Death olaný arýyor.
            //Bulduðunda da atamasýný yapýyor.
            Death death = FindObjectOfType<Death>();
            death.OnDeath += HandleOnDeath;
        }

        private void HandleOnDeath()
        {
            gameOverPanel.SetActive(true);
        }
    }
}

