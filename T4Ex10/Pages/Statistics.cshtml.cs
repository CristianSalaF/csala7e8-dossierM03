using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T4Ex10.Services;

namespace T4Ex10.Pages
{
    public class StatisticsModel : PageModel
    {
        private readonly TaskService _taskService;

        public StatisticsModel(TaskService taskService)
        {
            _taskService = taskService;
        }

        public int Total { get; set; }
        public int Completed { get; set; }
        public int Pending { get; set; }

        public void OnGet()
        {
            Total = _taskService.GetTotalTasks();
            Completed = _taskService.GetCompletedTasks();
            Pending = _taskService.GetPendingTasks();
        }
    }
}
