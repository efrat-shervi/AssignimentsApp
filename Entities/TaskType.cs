using System.Text.Json.Serialization;

namespace API.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TaskType
    {
        //משימה אישית
        Personal_task = 1,
        //-	משימת עבודה
        Work_task = 2,
        //-	משימת לימודים
        Study_task = 3
    }
}