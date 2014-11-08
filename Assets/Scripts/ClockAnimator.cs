using UnityEngine;
using System;

public class ClockAnimator: MonoBehaviour {

	public Transform hours, minutes, seconds;
	public bool analog;

	private const float
		hoursToDegrees = 360/12,
		minutesToDegrees = 360/60,
		secondsToDegrees = 360/60;

	void Update () {

		if (analog) {
			TimeSpan time = DateTime.Now.TimeOfDay;
			hours.localRotation = Quaternion.Euler (0f, 0f, (float)time.TotalHours * -hoursToDegrees);
			minutes.localRotation = Quaternion.Euler (0f, 0f, (float)time.TotalMinutes * -minutesToDegrees);
			seconds.localRotation = Quaternion.Euler (0f, 0f, (float)time.TotalSeconds * -secondsToDegrees);

		} else {

			DateTime time = DateTime.Now;
			hours.localRotation = Quaternion.Euler (0f, 0f, time.Hour * -hoursToDegrees);
			minutes.localRotation = Quaternion.Euler (0f, 0f, time.Minute * -minutesToDegrees);
			seconds.localRotation = Quaternion.Euler (0f, 0f, time.Second * -secondsToDegrees);
		}
	}
}