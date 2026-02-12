using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;
    public Rigidbody rb;
    float velocidad = 5f;

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    private void Movimiento () 
    { 
        
            rb.linearVelocity = playerController.DireccionJugador() 
                * velocidad;
    
    }
}
