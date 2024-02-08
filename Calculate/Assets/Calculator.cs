using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class Calculator : MonoBehaviour
{
    public Text text;
    bool clearPrevInput; 
    float prevInput; 


    //TODO: Leave this alone
    private EquationType equationType;

    private void Start()
    {
        Clear();
    }

    public void AddInput(string input)
    {
        
        if (clearPrevInput == true)
        {
            text.text = string.Empty;
            clearPrevInput = false; 

        }

        text.text = text.text + input;

    }

    public void SetEquationAsAdd()
    {

        prevInput = float.Parse(text.text);
        clearPrevInput = true;
        equationType = EquationType.ADD;
    }

    public void SetEquationAsSubtract()
    {
        prevInput = float.Parse(text.text);
        clearPrevInput = true;
        equationType = EquationType.SUBTRACT;
    }

    public void SetEquationAsMultiply()
    {
        prevInput = float.Parse(text.text);
        clearPrevInput = true;
        equationType = EquationType.MULTIPLY;
    }

  
    public void SetEquationAsDivide()
    {
        prevInput = float.Parse(text.text);
        clearPrevInput = true;
        equationType = EquationType.DIVIDE;
    }


    public void Add()
    {
        float answer = prevInput + float.Parse(text.text);
        text.text = answer.ToString();
        equationType = EquationType.ADD;

    }

    public void Subtract()
    {
        float answer = prevInput - float.Parse(text.text);
        text.text = answer.ToString();
        equationType = EquationType.SUBTRACT;
    }


    public void Multiply() 
    {
        float answer = prevInput * float.Parse(text.text);
        text.text = answer.ToString();
        equationType = EquationType.MULTIPLY;
    }


    public void Divide()
    {
        float answer = prevInput / float.Parse(text.text);
        text.text = answer.ToString();
        equationType = EquationType.DIVIDE;
    }


    public void Clear()
    {


        clearPrevInput = true;
        text.text = "0";
        prevInput = 0;
        equationType = EquationType.None;        
    }

    public void Calculate()
    {
        if (equationType == EquationType.ADD)
        {
            Add();
        }
        else if (equationType == EquationType.SUBTRACT)
        {
            Subtract();
        }
        else if (equationType == EquationType.MULTIPLY)
        {
            Multiply();
        }
        else if (equationType == EquationType.DIVIDE)
        {
            Divide();
        }
       
    }
    public enum EquationType
    {
        None = 0,
        ADD = 1,
        SUBTRACT = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }
}
