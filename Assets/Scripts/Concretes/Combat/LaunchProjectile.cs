using RedDragon.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Combat
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileControllers projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] GameObject projectileParent;
        [SerializeField] float delayProjectile = 1f;
        float _currentDelayTime;
        bool _canLaunch = false;

        private void Update()
        {
            _currentDelayTime += Time.deltaTime;

            if (_currentDelayTime > delayProjectile)
            {
                _canLaunch = true;
                _currentDelayTime = 0f;
            }
        }

        public void LaunchAction()
        {
            if (_canLaunch)
            {
                ProjectileControllers newProjectile = Instantiate(projectilePrefab, projectileTransform.position, projectileTransform.transform.rotation);
                
                newProjectile.transform.parent = projectileParent.transform;
                _canLaunch = false;
            }
        }
    }
}
