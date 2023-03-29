using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JokeAPIAdapter : JokeAPI, IJokeAPI
{
    public List<JokeScriptable> localJokes = new List<JokeScriptable>();

    public Joke GetJoke(JokeSystem system)
    {
        if (system == JokeSystem.cloudAPI)
        {
            return base.GetJoke();
        }
        else
        {
            JokeScriptable randomJoke = localJokes[Random.Range(0, localJokes.Count)];
            Joke joke = new Joke();
            
            if(randomJoke.type == JokeType.OnePart)
            {
                joke.type = "onepart";
            }
            else
            {
                joke.type = "twopart";
            }
            joke.joke = randomJoke.joke;
            joke.setup = randomJoke.setup;
            joke.delivery = randomJoke.delivery;

            return joke;
        }
    }
}
