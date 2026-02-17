using TMPro;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
	[SerializeField] private TMP_InputField _InputA;
	[SerializeField] private TMP_InputField _InputB;

	public float ConvertirStringaFloat(string input)
	{
		return float.Parse(input);
	}

	public string Calcular(string Operador, float inputA, float inputB)

	{
		switch (Operador)
		{
			case "+":
				return (inputA + inputB).ToString();
				break;
			case "-":
				return (inputA - inputB).ToString();
				break;
			case "*":
				return (inputA * inputB).ToString();
				break;
			case "/":
				return (inputA / inputB).ToString();
				break;
			default:
				Debug.Log("S no pones un Operador tienes 0");
				break;



		}
	}
}