using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Movement
{
    //Bu class'� kullanacak nesnenin �zerinde 'Rigidbody2D' olmak zorunda demi� olduk.
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        Rigidbody2D _rigidbody2D;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void Start()
        {
            _rigidbody2D.velocity = Vector2.left * moveSpeed;
        }
    }
}
