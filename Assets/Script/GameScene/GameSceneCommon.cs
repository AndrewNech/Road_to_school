using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneCommon : MonoBehaviour
{
    public void GetUserData()
    {
        print("Name: " + UserData.UserName);
        print("Surname: " + UserData.UserSurname);
    }
}
