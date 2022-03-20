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
            //Çarpýþma yaptýðýmýzda karþý tarafýn getcomponent'ini alsýn ve enemy'e atasýn.
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
