using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using photoShare.Models;

namespace photoShare.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        //home page 
        public IActionResult Index()
        {
            //create a list of photos
            List<Photo> photos = new List<Photo>();

            //create 3 photo obj

            //two way to create the obj
            Photo photo1 = new Photo() { Title = "my dog",
                CreatedAt = new DateTime(2025, 1, 14), 
                Description = "this is my dog",
                ImageFilename = "dog.jpg", 
                IsPublic = true, 
                PhotoId = 1 };
            //another way
            Photo photo2 = new Photo();
            photo2.PhotoId = 2;
            photo2.Title = "cat";
            photo2.ImageFilename = "cat.jpg";
            photo2.IsPublic = false;
            photo2.Description = string.Empty;
            photo2.CreatedAt = new DateTime();

            Photo photo3 = new Photo();
            photo2.PhotoId = 3;
            photo2.Title = "pig";
            photo2.ImageFilename = "pig.jpg";
            photo2.IsPublic = false;
            photo2.Description = string.Empty;
            photo2.CreatedAt = new DateTime();

            // add them to list
            photos.Add(photo1);
            photos.Add(photo2);
            photos.Add(photo3);

            return View();
        }

        //display the photo by id 
        public IActionResult DisplayPhoto(int id) {
            Photo photo = new Photo()
            {
                Title = "my bird",
                CreatedAt = new DateTime(2025, 1, 14),
                Description = "this is my bird",
                ImageFilename = "bird.jpg",
                IsPublic = true,
                PhotoId = id
            };
            return View();
        }

        public IActionResult Privacy() //naming is import that go to the view page base on like the name " Privacy " 
        {
            return View();
        }


    }
}
