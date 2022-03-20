using RedDragon.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RedDragon.Movement
{
    //Bu class'ý kullanacak nesnenin üzerinde 'Rigidbody2D' olmak zorunda demiþ olduk.
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        //DirenctionEnum üzerinden enumslarý çekmek için>>
        [SerializeField] DirectionEnum direction;
        Rigidbody2D _rigidbody2D;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void Start()
        {
            _rigidbody2D.velocity = SelectNewDirection() * moveSpeed;
        }
        private Vector2 SelectNewDirection()
        {
            Vector2 selectedDirection;
            if (direction == DirectionEnum.Left)
            {
                selectedDirection = Vector2.left;
            }
            else
            {
                selectedDirection = Vector2.right;
            }
            return selectedDirection;
        }
    }
}
