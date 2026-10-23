using Microsoft.AspNetCore.Mvc;

namespace day2_minhanh.ViewComponents
{
    public class NotificationViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string message = "Hôm nay có bài kiểm tra!")
        {
            ViewBag.Notification = message;
            ViewBag.CurrentTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            return View();
        }
    }
}