using RedDragon.Combat;
using RedDragon.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputControllers _input;
        LaunchProjectile _launcProjectile;
        AudioSource _audioSource;
        bool _isLeftMouseClick;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launcProjectile = GetComponent<LaunchProjectile>();
            _audioSource = GetComponent<AudioSource>();
            _input = new PcInputControllers();
        }

        private void Update()
        {
            if (_input.LeftMouseClickDown)
            {
                _isLeftMouseClick = true;
            }
            if (_input.RightMouseClickDown)
            {
                _launcProjectile.LaunchAction();
            }
        }

        private void FixedUpdate()
        {
            if (_isLeftMouseClick)
            {
                _jump.JumpAction(_rigidbody2D);
                _audioSource.Play();
                _isLeftMouseClick = false;
            }
        }
    }
}
