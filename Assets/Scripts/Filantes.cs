using UnityEngine;

public class EtoileFilante : MonoBehaviour
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
        transform.position = new Vector2(transform.position.x, transform.position.y + vitesseY);

        if (transform.position.y > 10f)
        {
            transform.position = new Vector2(transform.position.x,-12.21f);
        } else if (transform.position.y < -12.21f)
        {
            transform.position = new Vector2(transform.position.x,10f);
        }

        float nouvelleTaille = transform.localScale.x - tauxReduction;

        if (nouvelleTaille < 0 || nouvelleTaille > 3.5f)
        {
            tauxReduction *= -1;
        }
        transform.localScale = new Vector2(nouvelleTaille, nouvelleTaille);


    }
}
