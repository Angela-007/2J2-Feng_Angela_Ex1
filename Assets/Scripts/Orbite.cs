using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float vitesseRotation = 0.01f;
    public GameObject planeteCible;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(planeteCible.transform.position, Vector3.forward, vitesseRotation);
    }
}
