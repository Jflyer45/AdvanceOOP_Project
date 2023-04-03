using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JokeClient : MonoBehaviour
{
    #region
    public JokeAPIAdapter jokeAPI;
    public JokeSystem jokeOption;
    public TMP_Text textObj;
    public float waitTime;
    public float jokeAppearTime;
    #endregion
    public void SetUpJoke()
    {
        Joke joke = jokeAPI.GetJoke(jokeOption);
        string textToShow = "";
        if (joke.type == "onepart")
        {
            textToShow = joke.joke;
        }
        else
        {
            textToShow = joke.setup + "\n \n" + joke.delivery;
        }

        textObj.text = textToShow;
    }

    void Start()
    {
        StartCoroutine("WaitForJoke");
    }

    IEnumerator WaitForJoke()
    {
        yield return new WaitForSeconds(waitTime);
        SetUpJoke();
        yield return new WaitForSeconds(jokeAppearTime);
        textObj.text = "";
    }
}
