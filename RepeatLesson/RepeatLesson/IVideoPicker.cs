using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLesson
{
    public interface IVideoPicker
    {
        Task<string> GetVideoFileAsync();
    }
}
