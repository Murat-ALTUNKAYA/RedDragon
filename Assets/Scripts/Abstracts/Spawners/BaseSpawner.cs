using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Abstracts.Spawner
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;
        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpawnTime = 1f;

        float _curentSpawnTime;
        float _timeBoundary;

        private void Start()
        {
            ResetTimes();
        }

        private void Update()
        {
            _curentSpawnTime += Time.deltaTime;

            if (_curentSpawnTime > _timeBoundary)
            {
                Spawn();
                ResetTimes();
            }
        }

        protected abstract void Spawn()

        private void ResetTimes()
        {
            _curentSpawnTime = 0f;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}

