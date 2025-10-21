using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    Renderer capsuleRenderer;
    Material capsuleMat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        capsuleRenderer = GetComponent<Renderer>();
        capsuleMat = capsuleRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchColour()
    {
        //capsuleMat.DOColor(Random.ColorHSV(), 2.0f).OnComplete(() =>
        //{
        //    count++;
        //    if (count == targetObjects.Count)
        //        count = 0;

        //    Move(targetObjects[count]);
        //});
    }
}
