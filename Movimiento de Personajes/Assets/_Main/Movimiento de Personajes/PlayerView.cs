using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [Header("Materiales")]

    [SerializeField] private Renderer render;
    [SerializeField] private Material material1;
    [SerializeField] private Material material2;

    [Header("Clases")]
    [SerializeField] private PlayerController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        render = GetComponent<Renderer>();
        controller = GetComponent<PlayerController>();

        controller.DireccionJugador();

    }

    // Update is called once per frame
    void Update()
    {
        CambiarColor();
        Debug.Log(controller.DireccionJugador().magnitude);
    }

    public void CambiarColor()

    {
        if (controller.DireccionJugador().magnitude > 0)
        {
            render.material.color = Color.red;
        }
    }
}
