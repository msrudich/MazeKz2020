using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebMaze.DbStuff;
using WebMaze.DbStuff.Model.Polyclinic;
using WebMaze.DbStuff.Repository;
using WebMaze.Models.Polyclinic;

namespace WebMaze.Controllers
{
    public class PolyclinicController : Controller
    {
        private WebMazeContext _webMazeContext;
        private PolyclinicUserRepository polyclinicUserRepository;
        private PatientRepository patientRepository;

        private IWebHostEnvironment hostEnvironment;

        public PolyclinicController(WebMazeContext webMazeContext, PolyclinicUserRepository polyclinicUserRepository, PatientRepository patientRepository, IWebHostEnvironment hostEnvironment)
        {
            _webMazeContext = webMazeContext;
            this.polyclinicUserRepository = polyclinicUserRepository;
            this.patientRepository = patientRepository;
            this.hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            /*var polyclinicUserViewModel = new PolyclinicUserViewModel();
            polyclinicUserViewModel.ReturnURL = Request.Query["ReturnURL"];
            return View(polyclinicUserViewModel);*/
            return View();
        }

        [HttpPost]
        public IActionResult Index(PolyclinicUserViewModel polyclinicUserViewModel)
        {
            var polyclinicUser = polyclinicUserRepository
                .GetUserByNameAndPassword(polyclinicUserViewModel.UserName, polyclinicUserViewModel.Password);
            if (polyclinicUser == null)
            {
                return View(polyclinicUserViewModel);
            }

            if (polyclinicUser.Position.Contains("dmin"))
            {
                return RedirectToAction("Administration", "Polyclinic");
            }

            else if (polyclinicUser.Position.Contains("egistr"))
            {
                return RedirectToAction("Reception", "Polyclinic");

            }

            else
            {
                return RedirectToAction("DoctorOffice", "Polyclinic");
            }
        }

        [HttpGet]
        public IActionResult Reception()
        {
            var patientViewModel = new PatientViewModel();
            patientViewModel.PhotoURL = Request.Query["ReturnURL"];
            return View(patientViewModel);
        }

        [HttpPost]
        public IActionResult Reception(PatientViewModel patientViewModel)
        {
            var patient = patientRepository.GetPatientById(patientViewModel.PatientID);
            if (patient == null)
            {
                return View(patientViewModel);
            }
            else
            {

            }
            return View();
        }

        public IActionResult FindPatient(string selectedOption)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChoosePhoto(PatientViewModel viewModel)
        {
            var fileName = viewModel.Photo.FileName;
            var wwwrootPath = hostEnvironment.WebRootPath;
            var path = @$"{wwwrootPath}\image\Polyclinic\PatientPhotos\{fileName}";
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await viewModel.Photo.CopyToAsync(fileStream);
            }

            var patient = patientRepository.Get(viewModel.PatientID);
            //patient.PhotoURL = $"/image/Polyclinic/PatientPhotos/{fileName}";
            //patientRepository.Save(patient);


            return RedirectToAction("Reception", new { photo = viewModel.PhotoURL });

            //return RedirectToAction("Reception", "Polyclinic");

            //return RedirectToAction("Reception", new { patientId = viewModel.PatientID });
        }

        public IActionResult Administration()
        {

            return View();
        }


        public IActionResult PatientCard()
        {

            return View();
        }

        public IActionResult DoctorOffice()
        {

            return View();
        }

        public IActionResult Laboratory()
        {

            return View();
        }

        public IActionResult AddPolyclinicUser(string userName, string position)
        {
            return RedirectToAction("Index", "Polyclinic");
        }
    }
}
