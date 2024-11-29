using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Models
{
    //specifies the type of contect available in a course
    [JsonConverter(typeof(JsonStringEnumConverter))] //helps JSON to deserialize enums
    public enum ContentType
    {
        Video,Audio,Text
    }

    //use struct - a simple value type to hold duration
    public struct ChapterDuration
    {
       public int hours {  get; set; }
       public int minutes {  get; set; }
    }
    internal class ChapterModel
    {
       
        private int _chapterid; //to be used in course model
        
        private string? _chaptername;  
        private ContentType _contentType;
        private ChapterDuration _chapterduration;

        [JsonPropertyName("chapterid")]
        public int ChapterID
        {
            get => _chapterid;
            set => _chapterid = value;
        }

        [JsonPropertyName("chaptername")]
        public string chapterName
        {
            get=>_chaptername; set => _chaptername = value;
        }

        [JsonPropertyName("chaptertype")]
        public ContentType ContentType
        {
            get=>_contentType; set => _contentType = value;
        }

        [JsonPropertyName("chapterduration")]
        public ChapterDuration ChapterDuration
        {
            get=>_chapterduration; set => _chapterduration = value;
        }

        public ChapterModel()
        {
            
        }
        public ChapterModel(string? chapterName,ContentType contentType, int duration)
        {
            _chaptername = chapterName;
            _contentType = contentType;
            _chapterduration.hours= duration/60;
            _chapterduration.minutes= duration%60;
        }

        public override string ToString() => $"Chapter ID {_chapterid} Chapter Name {_chaptername} Content Type {_contentType} " +
                                             $"Chapter Duration {_chapterduration.hours}h {_chapterduration.minutes}mins ";
    }
}
