using RedDragon.Controllers;
using RedDragon.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Spawner
{
    public class ObsticleSpawner : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;
        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpawnTime = 1f;
        [SerializeField] EnemyController[] enemies;

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

        private void Spawn()
        {
            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex], this.transform);
        }
        private void ResetTimes()
        {
            _curentSpawnTime = 0f;
            _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}

