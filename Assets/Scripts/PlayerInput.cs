using UnityEngine;

namespace Platformer.Inputs                           
{
    [RequireComponent(typeof(PlayerMovement))]

    public class PlayerInput : MonoBehaviour
    {
        private const string horizontalAxis = "Horizontal";

        private Vector2 movement;
        private PlayerMovement PlayerMovement;

        private void Awake()
        {
            PlayerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(horizontalAxis);

            movement = new Vector2(horizontal, 0);
        }

        private void FixedUpdate()
        {
            PlayerMovement.MoveCharacter(movement);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerMovement.JumpCharacter();
            }
        }
    }
}
