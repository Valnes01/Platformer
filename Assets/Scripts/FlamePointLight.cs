using UnityEngine;

public class FlamePointLight : MonoBehaviour
{
    private Light flameLight;
    private float maxRadius = 7f;
    private float minRadius = 2f;
    private float radiusFlame = 2f;
    private bool isFlameUp = true;

    private void Awake()
    {
         flameLight = gameObject.GetComponent<Light>();
    }

    private void Update()
    {
        flameLight.range = radiusFlame;

        if (isFlameUp)
        {
            radiusFlame += Time.deltaTime*2;

            if(radiusFlame >= maxRadius)
            {
                isFlameUp=false;
            }
        }
        else
        {
            radiusFlame -= Time.deltaTime*2;

            if (radiusFlame <= minRadius)
            {
                isFlameUp = true;
            }
        }
    }
}
