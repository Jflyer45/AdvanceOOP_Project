using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JokeClient : MonoBehaviour
{
    public JokeAPIAdapter jokeAPI;
    public JokeSystem jokeOption;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMP_Text>().text = jokeAPI.GetJoke(jokeOption).type;
    }
}
