using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T4Ex10.Models;
using T4Ex10.Services;

namespace T4Ex10.Pages;

public class IndexModel : PageModel
{
    private readonly TaskService _taskService;

    public IndexModel(TaskService taskService)
    {
        _taskService = taskService;
    }

    [BindProperty]
    public TaskItem NewTask { get; set; } = new TaskItem();

    public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();

    public void OnGet()
    {
        Tasks = _taskService.GetAllTasks();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            Tasks = _taskService.GetAllTasks();
            return Page();
        }

        _taskService.AddTask(NewTask);
        return RedirectToPage();
    }

    public IActionResult OnPostToggleCompleted(int taskId)
    {
        _taskService.ToggleTaskCompleted(taskId);
        return RedirectToPage();
    }
}
