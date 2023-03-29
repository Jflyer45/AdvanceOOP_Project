using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Joke", order = 1)]
public class JokeScriptable : ScriptableObject
{
	public JokeType type;
	public string joke;
	public string setup;
	public string delivery;
}

public enum JokeType
{
	OnePart, TwoPart
}
