﻿using UnityEngine.Rendering.Universal;

namespace Settings.URPSettings
{
	public class GraphicSettingsEditor
	{
		private readonly UniversalRenderPipelineAsset urpPipelineAsset;

		/// <summary>
		/// Allows editing of a URP assets, but it is easier
		/// </summary>
		public GraphicSettingsEditor(UniversalRenderPipelineAsset pipelineAsset)
		{
			urpPipelineAsset = pipelineAsset;
		}

		#region Quality

		public void SetHdr(bool active)
		{
			urpPipelineAsset.supportsHDR = active;
		}

		public void SetMsaaQuality(MsaaQuality msaaSampleCount)
		{
			urpPipelineAsset.msaaSampleCount = (int) msaaSampleCount;
		}

		#endregion

		#region Shadows

		public void SetShadowDistance(float distance)
		{
			urpPipelineAsset.shadowDistance = distance;
		}

		public void SetShadowCascades(ShadowCascadesOption cascadesOption)
		{
			urpPipelineAsset.shadowCascadeOption = cascadesOption;
		}

		#endregion
	}
}