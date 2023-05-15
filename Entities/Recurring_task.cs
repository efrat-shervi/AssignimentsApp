using System.Text.Json.Serialization;

namespace API.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Recurring_task
    {
        //משימה חוזרת
        Recurring_task = 1,
        //משימה חד פעמית
        One_time_task = 2
    }
}