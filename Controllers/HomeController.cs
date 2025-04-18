using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriGuide.Data;
using NutriGuide.Models;
using System.Diagnostics;

namespace NutriGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly NutriGuideDbContext _context;

        public HomeController(ILogger<HomeController> logger, NutriGuideDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tieuduong()
        {
            return View();
        }
        [Authorize]
        public IActionResult History()
        {
            var email = User.Identity.Name;
            var userId = _context.Users
                        .Where(u => u.Email == email)
                        .Select(u => u.Id)
                        .FirstOrDefault();
            if (userId != 0)
            {
                ViewBag.UserId = userId;
            }
            else {
                ViewBag.UserId = 0;
            }
            return View("History");
        }

        [HttpGet]
        public IActionResult Predict()
        {            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Predict(IFormFile uploadFile)
        {
            if (ModelState.IsValid)
            {
                if (uploadFile != null && uploadFile.Length > 0)
                {
                    var fileext = Path.GetExtension(uploadFile.FileName);
                    var myUniqueFileName = Guid.NewGuid() + fileext;

                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", myUniqueFileName);
                    //Using Buffering
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        // The file is saved in a buffer before being processed
                        await uploadFile.CopyToAsync(stream);
                    }

                    // Create single instance of sample data from first line of dataset for model input
                    var imageBytes = System.IO.File.ReadAllBytes(filePath);
                    NutriGuideModel.ModelInput sampleData = new NutriGuideModel.ModelInput()
                    {
                        ImageSource = imageBytes,
                    };

                    // Make a single prediction on the sample data and print results.
                    //var sortedScoresWithLabel = ImgMLModel.Predict(sampleData);
                    var sortedScoresWithLabel = NutriGuideModel.PredictAllLabels(sampleData);

                    PredictResult result = new PredictResult();

                    foreach (var score in sortedScoresWithLabel)
                    {
                        if (score.Value >= 0.5)
                        {
                            result.Label = score.Key;
                            result.Score = score.Value;
                        }
                        break;
                    }
                    ViewBag.Result = result;
                    return View();
                }
            }
            return View();
        }

        public IActionResult Bmi()
        {
            return View();
        }

        public IActionResult Symptom()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
