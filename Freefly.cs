using HarmonyLib;
using MelonLoader;
using UnityEngine;
using Cinemachine;

namespace Friends
{
	public static class FreeflyMain
	{
		public static bool isFlying = false;
		public static Camera mainCam;
		public static CinemachineBrain vanillaCamBrain;
		public static FreeFlyCamera freeFlyCam;

		public static void EnableVanillaBrains(bool enabled)
		{
			if(vanillaCamBrain)
			{
				vanillaCamBrain.enabled = enabled;
			}
		}

		public static void EnableNewBrains(bool enabled)
		{
			if (freeFlyCam)
			{
				freeFlyCam.enabled = enabled;
			}
		}


	}
}
