using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Abstracts.Controllers
{
    public class LifeCycleController : MonoBehaviour
    {
        [SerializeField] float maxLifeTime = 5f;
        float _currentTime;

        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > maxLifeTime)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

