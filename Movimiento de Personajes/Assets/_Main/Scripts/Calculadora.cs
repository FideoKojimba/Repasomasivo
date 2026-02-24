using System.Globalization;
using TMPro;
using UnityEngine;

public class Calculadora : MonoBehaviour

{
	public enum Operador
	{
		Suma,
		Resta,
		Multiplicación,
		División,
		ClearData
	}

	[Header("Inputs")]
	[SerializeField] private TMP_InputField _InputA;
	[SerializeField] private TMP_InputField _InputB;

	[Header("Outputs")]
	[SerializeField] private TMP_Text _resultado;

	[Header("Config")]
	[SerializeField] private Operador _operador;
	public void SeleccionarOperador(Operador operador)
	{
		_operador = operador;	
	}

	public void OperadorSuma()=> _operador = Operador.Suma;
	public void OperadorResta()
	{
		_operador = Operador.Resta;

		if (_operador != Operador.Suma)
			Debug.Log("No es suma");
	}
	public void OperadorMultiplicación()
	{
		_operador = Operador.Multiplicación;
	}

    public void OperadorDivision()
    {
		_operador = Operador.División;
    }

    public void OperadorClearData()
    {
        _operador = Operador.ClearData;
    }


    public void Calcular()

	{
		float.TryParse(_InputA.text, out float a);
		float.TryParse(_InputB.text, out float b);

		if(!float.TryParse(_InputA.text,out a)||!float.TryParse(_InputB.text, out b))
		{
			_resultado.text = "Agrega un cáracter válido";
			return;
		}
	

		

		switch (_operador)
		{
			case Operador.Suma:
				_resultado.text = (a + b).ToString();
				break;
			case Operador.Resta:
                _resultado.text = (a - b).ToString();
				break;
            case Operador.Multiplicación :
				_resultado.text = (a * b).ToString(); 
				break;
			case Operador.División:
				if (b ==0)
					{
					_resultado.text = "No se puede dividir en cero";
					}
				else
				{
					_resultado.text =(a/b).ToString();	
				}

                _resultado.text = (a / b).ToString();
				break;

			case Operador.ClearData:
				_InputA.text = "";
                _InputB.text = "";

                _resultado.text = "";
				break;


			default:
				_resultado.text = "Oprime un operador válido";
				break;



		}
	}
}