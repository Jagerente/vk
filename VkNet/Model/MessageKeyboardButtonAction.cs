using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Annotations;
using Newtonsoft.Json;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model
{
	/// <summary>
	/// Информация о кнопке клавиатуры.
	/// </summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptOut)]
	public class MessageKeyboardButtonAction
	{
		/// <summary>
		/// Содержит 'text'
		/// </summary>
		[JsonProperty(propertyName: "type"), JsonConverter(typeof(SafetyEnumJsonConverter))]
		public KeyboardButtonActionType Type { get; set; } = KeyboardButtonActionType.Text;

		/// <summary>
		/// JSON строка с payload, до 255 символов
		/// </summary>
		[CanBeNull]
		[JsonProperty(propertyName: "payload", NullValueHandling = NullValueHandling.Ignore)]
		public string Payload { get; set; }

		/// <summary>
		/// Текст на кнопке, до 40 символов
		/// </summary>
		[JsonProperty(propertyName: "label")]
		public string Label { get; set; }
		
		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response"> Ответ сервера. </param>
		/// <returns> </returns>
		public static MessageKeyboardButtonAction FromJson(VkResponse response)
		{
			return new MessageKeyboardButtonAction
			{
				Type = response[key: "type"]
				,
				Payload = response[key: "payload"]
				,
				Label = response[key: "label"]
			};
		}
	}
}
