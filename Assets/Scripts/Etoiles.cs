using UnityEngine;

public class Etoiles : MonoBehaviour
{

    public float vitesseX = 0.01f;
    public float vitesseY = 0.01f;
    public float tauxReduction = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(vitesseX,vitesseY,0);

        float nouvelleTaille = transform.localScale.x - tauxReduction;

        if (nouvelleTaille < 0 || nouvelleTaille > 3)
        {
            tauxReduction *= -1;
        }
        transform.localScale = new Vector2(nouvelleTaille,nouvelleTaille);

        
    }
}

