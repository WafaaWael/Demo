using Microsoft.AspNetCore.Mvc;
using  Demo.Models;
namespace Demo.Controllers
{
    public class ProductController : Controller
    {
        #region First

        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public string ShowMsg()
        //{
        //    return "hello from frist Action";
        //}
        //public ContentResult ShowMsg2()
        //{
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "local msg";
        //    return contentResult;
        //}
        //public ViewResult ShowView()
        //{
        //    ViewResult viewResult = new ViewResult();
        //    viewResult.ViewName = "View1";
        //    return viewResult;
        //}
        //public JsonResult ShowJson()
        //{
        //    JsonResult result = new JsonResult(new { ID = 1, Name = "Ahmed" });
        //    return result;
        //}
        #endregion
        ProductSampleData sampleData = new ProductSampleData();
        public IActionResult GetAll()
        {
            List<Product> products = sampleData.GetAll();
            return View("ShowAll",products);
        }
        public IActionResult deatails(int id)
        {
            Product productmodle= sampleData.GetById(id);
            return View("ProductDetails",productmodle);
        }
    }
}
