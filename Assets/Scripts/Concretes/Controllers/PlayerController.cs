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
        PcInputControllers _inputControllers;
        bool _isLeftMouseClick;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _inputControllers = new PcInputControllers();
        }

        private void Update()
        {
            if (_inputControllers.LeftMouseClickDown)
            {
                _isLeftMouseClick = true;
            }
        }

        private void FixedUpdate()
        {
            if (_isLeftMouseClick)
            {
                _jump.JumpAction(_rigidbody2D);
                _isLeftMouseClick = false;
            }
        }

        private void OnCollisionEnter2D()
        {
            GameManager.Instance.RestartGame();
        }
    }
}
