﻿using System.Globalization;

namespace Team_Capture.Console.TypeReader
{
	/// <summary>
	///     A default reader for <see cref="float" />
	/// </summary>
	internal sealed class FloatReader : ITypeReader
	{
		public object ReadType(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
				return 0f;

			return float.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out float result)
				? result
				: 0f;
		}
	}
}