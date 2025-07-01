using UnityEngine;

public class RandomColorGems : MonoBehaviour
{
    public Color[] colors;

    void Start()
    {
        var material = GetComponent<Renderer>().material;
        if (colors.Length > 0)
        {
            Debug.Log(Random.Range(0, colors.Length - 1));
            material.color = colors[Random.Range(0, colors.Length - 1)];
        }
    }
}
