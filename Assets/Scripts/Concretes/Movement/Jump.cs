using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Movement
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] float jumpForce = 350f;

        public void JumpAction(Rigidbody2D rigidbody2D)
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(Vector2.up * jumpForce);
        }
    }
}

