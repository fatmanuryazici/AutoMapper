using AutoMapper;
using AutoMapper.Models;
using AutoMapperr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Diagnostics;

namespace AutoMapperr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;


        public HomeController(ILogger<HomeController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            Student student1 = new Student()
            {
                Id=Guid.NewGuid(),
                F�rstName="Remzi",
                LastName="Urhan",
                Age=30
            };
            //StudentVM studentVM = new StudentVM();
            //studentVM.Id = student1.Id;
            //studentVM.F�rstName=student1.F�rstName;   //Tum bunlar� tek tek yazmak yerine AutoMapper ile asag�daki gibi tek sat�rda tamam.
            //studentVM.LastName=student1.LastName;
            //studentVM.Age=student1.Age;

            var studentVM= _mapper.Map<StudentVM>(student1); //student1in StudentVMe d�nmesini istiyorum
                                                             //mapper verilen generic Type da T type da <StudentVM> bir nesnesini
                                                             //olusturuyor studentVM.
                                                             //Map lenmesini istedi�imiz nesne kimin student1

            return View();
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
