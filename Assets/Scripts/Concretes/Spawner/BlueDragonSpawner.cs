using RedDragon.Abstracts.Spawner;
using RedDragon.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Spawner
{
    public class BlueDragonSpawner : BaseSpawner
    {
        [SerializeField] EnemyController enemy;

        protected override void Spawn()
        {
            Instantiate(enemy, this.transform);
        }
    }
}

