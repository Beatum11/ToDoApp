using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class Note_Info
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NoteText { get; set; }


        #region Constructors
        public Note_Info(string noteText)
        {
            NoteText = noteText;
        }

        public Note_Info()
        {

        }

        #endregion
    }
}
