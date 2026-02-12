using TMPro;
using UnityEngine;

public class Multiplicar : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputfileNumero1;
    [SerializeField] private TMP_InputField _inputfileNumero2;
    [SerializeField] private TMP_InputField _textResultado;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MultiplicarNumeros(float.Parse(_inputfileNumero1)
    }

    public int MultiplicarNumeros(float a,  float b)
    {
        return a * b;
    }
}
