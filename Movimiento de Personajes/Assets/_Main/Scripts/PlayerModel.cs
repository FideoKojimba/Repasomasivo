using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;

    public bool isMove;
    float velocidad = 5f;

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    private void Movimiento () 
    { 
        if (isMove) 
        {
            rb.linearVelocity = playerController.DireccionJugador() * velocidad;
        }
    }
}
