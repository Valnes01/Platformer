using UnityEngine;

namespace Platformer.Inputs
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody2D playerRigidbody;
        
        private float speed = 7.0f;
        private float jumpForce = 10f;
        private float fallWarrior = 2.5f;
        private float lowJumpWarrior = 2f;

        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody2D>();
        }

        public void MoveCharacter(Vector2 movement)
        {
            playerRigidbody.velocity = new Vector2(movement.x*speed, playerRigidbody.velocity.y);
        }
        public void JumpCharacter()
        {
            playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, jumpForce);
        }

        private void Update()
        {
            if (playerRigidbody.velocity.y < 0)
            {
                playerRigidbody.velocity += Vector2.up * Physics2D.gravity.y * (fallWarrior - 1) * Time.deltaTime;
            }
            else if (playerRigidbody.velocity.y > 0 )
            {
                playerRigidbody.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpWarrior - 1) * Time.deltaTime;
            }
        }
    }
}
