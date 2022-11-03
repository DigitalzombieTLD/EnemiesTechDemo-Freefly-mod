using MelonLoader;
using UnityEngine;

namespace Friends
{
    public class FriendsMain : MelonMod
    {
		public static Camera gameCam;

		public override void OnApplicationStart()
		{	
			MelonLogger.Msg("Mod started");
		
		}


		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			
		}
		
		public override void OnUpdate()
		{
			InputMain.GetInput();

			if (FreeflyMain.isFlying)
			{
				FreeflyMain.freeFlyCam.LockCursor(true);
			}
		}	
	}
}
