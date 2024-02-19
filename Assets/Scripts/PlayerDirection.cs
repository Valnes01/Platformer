using UnityEngine;

public class PlayerDirection : MonoBehaviour
{
    private Animator PlayerAnimator;
    private SpriteRenderer PlayerRenderer;
    private Rigidbody2D PlayerRigidbody;

    private bool isRightMovement = false;

    private void Awake()
    {
        PlayerAnimator = GetComponent<Animator>();
        PlayerRenderer = GetComponent<SpriteRenderer>();
        PlayerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void CheckDirectionCharacter()
    {
        if (PlayerRigidbody.velocity.x > 0.1f)
        {
            isRightMovement = false;
        }
        else if (PlayerRigidbody.velocity.x < -0.1f)
        {
            isRightMovement = true;
        }
        PlayerRenderer.flipX = isRightMovement;
    }

    private void CheckRunCharacter()
    {
        if (PlayerRigidbody.velocity.x > 0)
        {
            PlayerAnimator.SetBool("isRunWarrior", true);
        }
        else if (PlayerRigidbody.velocity.x < 0)
        {
            PlayerAnimator.SetBool("isRunWarrior", true);
        }
        else if (PlayerRigidbody.velocity.x == 0)
        {
            PlayerAnimator.SetBool("isRunWarrior", false);
        }
    }
         
    private void CheckJumpCharacter()
    {
        if(PlayerRigidbody.velocity.y > 0)
        {
            PlayerAnimator.SetBool("isWarriorJump", true);
        }
        else if(PlayerRigidbody.velocity.y < 0)
        {
            PlayerAnimator.SetBool("isWarriorDown", true);
        }
        else if (PlayerRigidbody.velocity.y == 0)
        {
            PlayerAnimator.SetBool("isWarriorDown", false);
            PlayerAnimator.SetBool("isWarriorJump", false);
        }
    }

    private void Update()
    {
        CheckDirectionCharacter();
        CheckJumpCharacter();
        CheckRunCharacter();
    }

}
