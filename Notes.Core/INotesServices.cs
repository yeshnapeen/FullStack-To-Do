using Notes.DB;
using System.Collections.Generic;

namespace Notes.Core
{
    public interface INotesServices
    {
        Note CreateNote(Note note);
        Note GetNote(int id);
        List<Note> GetNotes();
        void DeleteNote(int id);
        void EditNote(Note note);
    }
}
