using System;
using Newtonsoft.Json;

namespace AttendanceTaker
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Attendance
	{
		[JsonProperty("id")] public string Id { get; set; }

		[JsonProperty("type")] public AttendanceType Type { get; set; }

		[JsonProperty("occurredAt")]
		public DateTimeOffset OccurredAt { get; set; }

		[JsonProperty("userId")] public string UserId { get; set; }

		public string GetDateString()
		{
			return OccurredAt.DateTime.Date.ToShortDateString();
		}
	}
}
