using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedList : MonoBehaviour
{
	public GameObject SetAlarm;
	public GameObject BrushTeeth;
	public GameObject EatFood;
	public int AlarmMiniGameComplete = 0;
	public int SinkMiniGameComplete = 0;
	public int FoodMiniGameComplete = 0;

	// Update is called once per frame
	void Update()
	{
		AlarmMiniGameComplete = PlayerPrefs.GetInt("SetClock");
		SinkMiniGameComplete = PlayerPrefs.GetInt("BrushTeeth");
		FoodMiniGameComplete = PlayerPrefs.GetInt("EatFood");
		if (AlarmMiniGameComplete == 1)
		{
			SetAlarm.SetActive(true);
			PlayerPrefs.SetInt("Changing", 0);
		}
		if (SinkMiniGameComplete == 1)
		{
			BrushTeeth.SetActive(true);
			PlayerPrefs.SetInt("Changing", 0);
		}
		if (FoodMiniGameComplete == 1)
		{
			EatFood.SetActive(true);
			PlayerPrefs.SetInt("Changing", 0);
		}
		if (AlarmMiniGameComplete == 0)
		{
			SetAlarm.SetActive(false);
		}
		if (SinkMiniGameComplete == 0)
		{
			BrushTeeth.SetActive(false);
		}
		if (FoodMiniGameComplete == 0)
		{
			EatFood.SetActive(false);
		}
	}
}
