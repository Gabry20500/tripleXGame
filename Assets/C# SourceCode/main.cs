using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;
using Random = UnityEngine.Random;

public class main : MonoBehaviour
{
    //Error message
    [SerializeField] private Image ErrorPannel;
    [SerializeField] private Text ErrorTitle;
    [SerializeField] private Text ErrorMessage;
    [SerializeField] private Button ErrorOKButton;
    
    //InputField to enter the numbers
    [SerializeField]private InputField inputfield = null;
    private string input;
    
    //Texts to write the Results
    [SerializeField] private Text Result1;
    [SerializeField] private Text Result2;
    [SerializeField] private Text Result3;
    
    //Texts to print the sum and multiplication of unknowns
    [SerializeField]private Text SumText;
    [SerializeField]private Text MoltiplicationText;
    
    

    int min = 1, max = 10;
    int counter = 3;
    private List<int> RandNum = new List<int>(3);
    
    
    // Start is called before the first frame update
    void Start()
    {

        ErrorMessageDeactovation();
            
        GenerateRandomNum();
    }

    private void GenerateRandomNum()
    {
        PrintX();
        
        int rand;
        for(int i = 0; i < 3; i++)
        {
            rand = Random.Range(min, max);
            RandNum.Add(rand);
        }
        
        int sum = NumSum();
        int mol = NumMoltiplication();
        
        SumText.text = sum.ToString();
        MoltiplicationText.text = mol.ToString();
    }

    private int NumSum()
    {
        int SumRes = 0;

        for(int i = 0; i< 3; i++)
        {
            SumRes = SumRes + RandNum[i];
        }

        return SumRes;
    }

    private int NumMoltiplication()
    {
        int MoltiplicationRes = 1;

        for (int i = 0; i < 3; i++)
        {
            MoltiplicationRes = MoltiplicationRes * RandNum[i];
        }

        return MoltiplicationRes;
    }

    public void ReadInputField(string s)
    {
        input = s;
    }

    private void ErrorMessageActovation()
    {
        ErrorPannel.gameObject.SetActive(true);
        ErrorTitle.gameObject.SetActive(true);
        ErrorMessage.gameObject.SetActive(true);
        ErrorOKButton.gameObject.SetActive(true);
    }
    public void ErrorMessageDeactovation()
    {
        ErrorPannel.gameObject.SetActive(false);
        ErrorTitle.gameObject.SetActive(false);
        ErrorMessage.gameObject.SetActive(false);
        ErrorOKButton.gameObject.SetActive(false);
    }
    
    // Update is called once per frame
    private int xa = 3;
    private int value = 0;
    void Update()
    {
        do
        {
            Debug.Log("Counter: " + counter);
            for (int i = 0; i < xa; i++)
            {
                Debug.Log("Value: " + RandNum[i]);
                if (input == RandNum[i].ToString())
                {
                    PrintResults(i);
                    counter = counter - 1;
                    int.TryParse(input, out value);
                    inputfield.Select();
                    inputfield.text = "";
                    RandNum.Remove(value);
                    input = null;
                    xa = xa - 1;
                }
                else  if(input != RandNum.ToString() && input != null)
                {
                    ErrorMessageActovation();
                    input = null;
                    inputfield.Select();
                    inputfield.text = "";
                }
            } 
        } while ( counter > 3);

        if (counter == 0)
        {
            max = max + 5;
            counter = 3;
            GenerateRandomNum();
        }
    }

    private void PrintResults(int x)
    {
        switch (counter)
        {
           case 1: 
               Result3.text = RandNum[x].ToString();
               break;
           
           case 2:
               Result2.text = RandNum[x].ToString();
               break;
           case 3 :
               Result1.text = RandNum[x].ToString();
               break;
        }
        
    }

    private void PrintX()
    {
        string XValue = "X";
        Result1.text = XValue;
        Result2.text = XValue;
        Result3.text = XValue;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
