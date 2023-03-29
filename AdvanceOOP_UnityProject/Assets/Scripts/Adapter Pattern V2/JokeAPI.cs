using UnityEngine;
using UnityEditor;
using Models;
using Proyecto26;
using System.Collections.Generic;
using UnityEngine.Networking;
using Newtonsoft.Json;

public class JokeAPI : MonoBehaviour
{
	private readonly string basePath = "https://v2.jokeapi.dev/joke/Any?blacklistFlags=nsfw";
	private RequestHelper currentRequest;
	[TextArea()]
	public string result;
	public Joke joke;

	public void RequestJoke()
	{
		RestClient.Get(basePath).Then(res => {
			result = res.Text;
			joke = JsonConvert.DeserializeObject<Joke>(result);
		});
	}

    private void Start()
    {
		RequestJoke();
    }

	public Joke GetJoke()
    {
		return this.joke;
    }
}

[System.Serializable]
public class Joke
{
	public string type;
	public string joke;
	public string setup;
	public string delivery;
}
