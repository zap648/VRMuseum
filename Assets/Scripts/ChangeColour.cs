using DG.Tweening;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    Renderer capsuleRenderer;
    Material capsuleMat;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        capsuleRenderer = GetComponent<Renderer>();
        capsuleMat = capsuleRenderer.material;

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchColour();
        }
    }

    public void SwitchColour()
    {
        if (rb.isKinematic)
        {
            capsuleMat.DOColor(Random.ColorHSV(), 2.0f);
        }
    }
}
