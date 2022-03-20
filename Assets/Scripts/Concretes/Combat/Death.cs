using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Combat
{
    public class Death : MonoBehaviour
    {
        bool _isDeath;
        public bool IdDeath => _isDeath;

        public event System.Action OnDeath;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _isDeath = true;

            OnDeath?.Invoke();

            //Zaman� durdurur ve oyunda hi�bir�ey hareket etmez.
            Time.timeScale = 0f;
        }
    }
}

