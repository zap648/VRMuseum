using DG.Tweening;
using UnityEngine;

public class CelestialBodies : MonoBehaviour
{
    public float radiusKm;
    public float solarDistKm;
    public float yearInDays;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localPosition = new Vector3(solarDistKm, 0.0f, 0.0f) / 1000.0f;
        transform.localScale = new Vector3(radiusKm, radiusKm, radiusKm) / 1000.0f;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
