using HarmonyLib;
using MelonLoader;
using UnityEngine;

namespace Friends
{
	public static class HarmonyMain
	{
		/*
		[HarmonyPatch(typeof(ShadowBaker), "OnStart")]
		public class ShadowBakerPAtch
		{
			public static void Prefix(ref ShadowBaker __instance)
			{
				//MelonLogger.Msg("Replacing shadow shader");
				//__instance.shader = PrefabLoader.shaderObjectShader;
				MelonLogger.Msg("ShadowBaker prefix");

				//__instance.shader = PrefabLoader.shaderObjectShader;
			}

			public static void Postfix(ref ShadowBaker __instance)
			{
				worldMaster = __instance.master;


				//MelonLogger.Msg("Replacing shadow shader");
				//__instance.shader = PrefabLoader.shaderObjectShader;
				MelonLogger.Msg("ShadowBakerLoading!!!");
				PreviewManager.Setup();
				MyModUI.selectedCategoryIndex = 0;
				MyModUI.selectedPrefabIndex = 0;
				MyModUI.UpdatePreview();
			}

		}
		*/
	}
}
