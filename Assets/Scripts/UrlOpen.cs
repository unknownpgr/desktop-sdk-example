using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlOpen : MonoBehaviour
{
  private bool handleUrlInput(string userInput)
  {
    bool isUrlValid = Uri.IsWellFormedUriString(userInput, UriKind.Absolute);
    if (isUrlValid)
    {
      Application.OpenURL(userInput);
    }
    else
    {
      DesktopSDK.Instance.ShowMessage("You entered invalid URI. Please Try again.");
      return false;
    }

    return true;
  }

  public void OnUrlOpenClicked()
  {
    DesktopSDK.Instance.ShowPrompt("Enter URL", handleUrlInput);
  }
}
