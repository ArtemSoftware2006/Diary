using Diary.Data.Entity;
using System.Data;

namespace Diary.Data.Interfaces
{
    public interface INoteSpecification
    {
        bool Quary(Note note);
    }
}