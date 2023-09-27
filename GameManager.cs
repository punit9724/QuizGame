using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    [SerializeField]
    GameObject SelectionPanel, GamePanel;
    [SerializeField]
    Catogry[] Cat;
    [SerializeField]
    TextMeshProUGUI QuestionText;
    [SerializeField]
    TextMeshProUGUI[] OptionText;
    int selectedFeild,QuestionNo;

    //private void Start()
    //{
    //    for (int i = 0; i < Cat.Length; i++)
    //    {
    //        Debug.Log(Cat[i].CatName);
    //        for (int j = 0; j < Cat[i].AllQuestions.Length; j++)
    //        {
    //            Debug.Log(Cat[i].AllQuestions[j].QuestionName);
    //            for(int k = 0;k < Cat[i].AllQuestions[j].AllOptions.Length; k++)
    //            {
    //                Debug.Log(Cat[i].AllQuestions[j].AllOptions[k].OPTIONS);
    //            }
    //            Debug.Log(Cat[i].AllQuestions[j].Answers); 
    //        }
    //    }
    //}

    public void QuestionSet()
    {
        Debug.Log(Cat[selectedFeild].CatName);
       
            QuestionText.text = Cat[selectedFeild]. AllQuestions[QuestionNo].QuestionName;
        
        for (int k = 0; k < Cat[selectedFeild].AllQuestions[QuestionNo].AllOptions.Length; k++)
        {
            OptionText[k].text=(Cat[selectedFeild].AllQuestions[QuestionNo].AllOptions[k].OPTIONS);
        }
        Debug.Log(Cat[selectedFeild].AllQuestions[QuestionNo].Answers);

    }

    public void CheckAnswer(TextMeshProUGUI cehckanswer)
    {
        string Ans = Cat[selectedFeild].AllQuestions[QuestionNo].Answers;
        Ans = Ans.Replace(" ", "");
        string selectedOPtion = cehckanswer.text.Replace(" ", "");
        if (Cat[selectedFeild].AllQuestions.Length > QuestionNo + 1)
        {
            if(selectedOPtion==Ans)
            {
                QuestionNo++;
                QuestionSet();  
            }
            else
            {
                Debug.Log("answer is false");
            }
        }
    }

    public void SelectionPanelOpen()
    {
        SelectionPanel.SetActive(true);
        GamePanel.SetActive(false);
    }

    public void GamePanelOpen(int cat)
    {
        
        GamePanel.SetActive(true);
        SelectionPanel.SetActive(false);
        selectedFeild = cat;
        QuestionSet();
    } 

    public void MainPanelOpen()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
