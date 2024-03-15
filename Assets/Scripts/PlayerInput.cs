using UnityEngine;

namespace Platformer.Inputs                           
{
    [RequireComponent(typeof(PlayerMovement))]

    public class PlayerInput : MonoBehaviour
    {
        public bool isActivatorSKeyDown = false;
        public bool isActivatorPlatform = false;
        public bool isActivatorEKyeDown = false;
        public bool isActiveEButton = false;

        private const string horizontalAxis = "Horizontal";
        private PlayerMovement PlayerMovement;
        private Vector2 movement;

        private void Awake()
        {
            PlayerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(horizontalAxis);

            movement = new Vector2(horizontal, 0);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerMovement.JumpCharacter();
            }
        }

        private void FixedUpdate()
        {
            PlayerMovement.MoveCharacter(movement);

            if (isActivatorSKeyDown)
            {
                if (Input.GetKey(KeyCode.S))
                {
                    isActivatorPlatform = true;
                }
            }

            if (isActivatorEKyeDown)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    isActiveEButton = true;
                }
                else
                {
                    isActiveEButton = false;
                }
            }
        }
    }
}
