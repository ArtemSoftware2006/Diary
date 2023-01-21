using Diary.Data.Entity;

namespace Diary.Data.Interfaces
{
    public interface INoteSpecification
    {
        bool Specificed(Note note);
    }
}