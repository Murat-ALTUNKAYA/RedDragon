using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        [SerializeField] private float jumpForce = 500f;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _rigidbody2D.AddForce(Vector2.up * jumpForce);
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            GameManager.Instance.RestartGame();
        }
    }
}
