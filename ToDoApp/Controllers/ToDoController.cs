using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Data;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {

        #region Basic Info
        private static Context context;

        public ToDoController(Context Context)
        {
            context = Context;
        }
        #endregion

        public IActionResult Index()
        {
            List<Note_Info> notes = context.Notes.ToList();
            return View(notes);
        }


        /// <summary>
        /// This method is responsible for creating/updating notes
        /// </summary>
        /// <param name="noteText"></param>
        /// <returns></returns>
        public IActionResult CreateNote(string noteText)
        {
            context.Notes.Add(new Note_Info(noteText));
            context.SaveChanges();
            List<Note_Info> notes = context.Notes.ToList();
            return RedirectToAction(nameof(Index));
        }


        /// <summary>
        /// Here you can delete your note/task
        /// </summary>
        /// <param name="noteText"></param>
        /// <returns></returns>
        public IActionResult DeleteNote(string noteText)
        {
            var note = context.Notes.FirstOrDefault(x => x.NoteText == noteText);
            context.Notes.Remove(note);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        /// <summary>
        /// Here you can edit your note/task
        /// </summary>
        /// <param name="noteText"></param>
        /// <returns></returns>
        public IActionResult Edit(string noteText)
        {
            var note = context.Notes.FirstOrDefault(x => x.NoteText == noteText);
            context.Notes.Remove(note);
            context.SaveChanges();
            return View(note);
        }

    }
}
