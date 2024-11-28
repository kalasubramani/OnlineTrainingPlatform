using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Models
{
    //specifies the type of contect available in a course
    public enum ContentType
    {
        Video,Audio,Text
    }

    //use struct - a simple value type to hold duration
    public struct ChapterDuration
    {
       public int hours, minutes;
    }
    internal class ChapterModel
    {
        private int _chapterid;
        private string? _chaptername;  
        private ContentType _contentType;
        private ChapterDuration _chapterduration;

        public ChapterModel(string? chapterName,ContentType contentType, int duration)
        {
            _chaptername = chapterName;
            _contentType = contentType;
            _chapterduration.hours= duration/60;
            _chapterduration.minutes= duration%60;
        }

    }
}
