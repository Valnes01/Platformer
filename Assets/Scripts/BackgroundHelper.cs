using UnityEngine;
using UnityEngine.UI;

public class BackgroundHelper : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    private float pos = 0f;
    private RawImage background;

    private void Start()
    {
        background = GetComponent<RawImage>();
    }

    private void Update()
    {
        pos += speed;

        if (pos > 1.0F)

            pos -= 1.0F;

        background.uvRect = new Rect(pos, 0, 1, 1);
    }
}
