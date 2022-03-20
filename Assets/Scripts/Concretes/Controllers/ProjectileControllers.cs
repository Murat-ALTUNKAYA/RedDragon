using RedDragon.Abstracts.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedDragon.Controllers
{
    public class ProjectileControllers : LifeCycleController
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //�arp��ma yapt���m�zda kar�� taraf�n getcomponent'ini als�n ve enemy'e atas�n.
            EnemyController enemy = collision.GetComponent<EnemyController>();
            if (enemy != null)
            {
                GameManager.Instance.IncreaseScore();
                Destroy(enemy.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}
