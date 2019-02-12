using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Common : MonoBehaviour
{
    public InputField name;
    public InputField surname;
    public InputField _class;
    public InputField school;

    public GameObject[] wrongLabels;
    public void StartGame()
    {
        wrongLabels[4].SetActive(false);
        if (ValidateFields())
        {
            SaveUserData();
            SceneManager.LoadScene(1);
        }
    }
    private bool ValidateFields()
    {
        if (wrongLabels[0].activeSelf|| wrongLabels[1].activeSelf || wrongLabels[2].activeSelf || wrongLabels[3].activeSelf)
        {
            wrongLabels[4].SetActive(true);
            return false;
        }
        return true;
    }
    private void SaveUserData()
    {
        UserData.UserName = name.text;
        UserData.UserSurname = surname.text;
        UserData.UserClass = _class.text;
        UserData.UserSchool = school.text;
        print("Data saved");
    }
    public void CheckName()
    {
        if(!(new Regex("^[А-Яа-я]+$").IsMatch(name.text)))
        {
            wrongLabels[0].SetActive(true);
        }
        else
        {
            wrongLabels[0].SetActive(false);
        }
    }
    public void CheckSurname()
    {
        if (!(new Regex("^[А-Яа-я]+$").IsMatch(surname.text)))
        {
            wrongLabels[1].SetActive(true);
        }
        else
        {
            wrongLabels[1].SetActive(false);
        }
    }
    public void CheckClass()
    {
        if (!(new Regex("^[А-Яа-я0-9 ]+$").IsMatch(_class.text)))
        {
            wrongLabels[2].SetActive(true);
        }
        else
        {
            wrongLabels[2].SetActive(false);
        }
    }
    public void CheckSchool()
    {
        if (!(new Regex("^[А-Яа-я0-9 ]+$").IsMatch(school.text)))
        {
            wrongLabels[3].SetActive(true);
        }
        else
        {
            wrongLabels[3].SetActive(false);
        }
    }

}
