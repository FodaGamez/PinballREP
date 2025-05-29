using UnityEngine;

public class ColorCycler : MonoBehaviour
{
    public float speed = 1f; // Velocidade do ciclo
    private Renderer rend;
    public float hue;

    void Start()
    {
        rend = GetComponent<Renderer>();
        
    }

    void Update()
    {
        hue += Time.deltaTime * speed;
        if (hue > 1f) hue -= 1f; 

        Color color = Color.HSVToRGB(hue, 1f, 1f); //saturação e brilho
        rend.material.color = color;
    }
   
}