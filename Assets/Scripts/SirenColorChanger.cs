using UnityEngine;

public class SirenColorChanger : MonoBehaviour
{
    public Renderer targetRenderer;
    public float changeSpeed = 1f;

    private Color redColor = Color.red;
    private Color blueColor = Color.blue;
    private float t;
    private bool toRed = true;

    void Update()
    {
        t += Time.deltaTime * changeSpeed;

        if (toRed)
            targetRenderer.material.color = Color.Lerp(blueColor, redColor, t);
        else
            targetRenderer.material.color = Color.Lerp(redColor, blueColor, t);

        if (t >= 1f)
        {
            t = 0f;
            toRed = !toRed;
        }
    }
}
