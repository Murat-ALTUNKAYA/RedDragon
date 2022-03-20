using RedDragon.Abstracts.Spawner;
using RedDragon.Controllers;
using RedDragon.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Spawner
{
    public class ObsticleSpawner : BaseSpawner
    {
        [SerializeField] EnemyController[] enemies;

        

        protected override void Spawn()
        {
            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex], this.transform);
        }
    }
}

