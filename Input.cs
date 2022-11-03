using Cinemachine;
using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace Friends
{
	public static class InputMain
	{
		public static void GetInput()
		{
			if (Input.GetKeyDown(KeyCode.F2))
			{
				if (Camera.main)
				{
					if (!FreeflyMain.vanillaCamBrain)
					{
						FreeflyMain.mainCam = Camera.main;
						FreeflyMain.vanillaCamBrain = FreeflyMain.mainCam.gameObject.GetComponent<CinemachineBrain>();
					}

					if (!FreeflyMain.freeFlyCam)
					{
						FreeflyMain.freeFlyCam = FreeflyMain.mainCam.gameObject.AddComponent<FreeFlyCamera>();
					}
				}
				else
				{
					return;
				}


				if (!FreeflyMain.isFlying)
				{
					FreeflyMain.isFlying = true;
					MelonLogger.Msg("Freefly activated!");
					FreeflyMain.EnableVanillaBrains(false);
					FreeflyMain.EnableNewBrains(true);
				}
				else
				{
					FreeflyMain.isFlying = false;
					MelonLogger.Msg("Freefly deactivated!");
					FreeflyMain.EnableNewBrains(false);
					FreeflyMain.EnableVanillaBrains(true);
					FreeflyMain.freeFlyCam.LockCursor(false);
				}
			}
		}
	}
}
