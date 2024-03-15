using Platformer.Inputs;
using UnityEngine;

/// <summary>
/// Класс для спрыгивания с платформ
/// </summary>
public class OneWayPlatform : MonoBehaviour
{
    private PlatformEffector2D OneWayEffector;
    private PlayerInput PlayerInput;

    private void Awake()
    {
        OneWayEffector = GetComponent<PlatformEffector2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerInput = collision.gameObject.GetComponent<PlayerInput>();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        PlayerInput.isActivatorSKeyDown = true;
        ActivateOneWayPlatform(PlayerInput.isActivatorPlatform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        PlayerInput.isActivatorSKeyDown = false;
        PlayerInput.isActivatorPlatform = false;
        ActivateOneWayPlatform(PlayerInput.isActivatorPlatform);
    }

    private void ActivateOneWayPlatform(bool isActivPlatform)
    {
        if (isActivPlatform)
        {
            OneWayEffector.rotationalOffset = 180;
        }
        else
        {
            OneWayEffector.rotationalOffset = 0;
        }
    }
}