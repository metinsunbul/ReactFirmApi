using AuthorizedCompanySearch.Data;
using AuthorizedCompanySearch.Dtos;
using AuthorizedCompanySearch.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace AuthorizedCompanySearch.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class FirmController : ControllerBase
    {
        private readonly IFirmRepo _firmRepo;
        private readonly IPersonelRepo _personelRepo;
        private readonly IMapper _mapper;

        //metin baska test
        public FirmController(IFirmRepo firmRepo, IPersonelRepo personelRepo, IMapper mapper)
        {

            _firmRepo = firmRepo;
            _personelRepo = personelRepo;
            _mapper = mapper;
        }

        // GET: api/<FirmController>
        [HttpGet]
        public ActionResult<IEnumerable<PersonelReadDtos>> Get()
        {
            var firms =  _firmRepo.GetAllFirm();
            foreach (var firm in firms)
            {
                var firmPersonels = _personelRepo.GetPersonelByFirmId(firm.FirmId);
                firm.Personel = firmPersonels;

            }
            
            return Ok(_mapper.Map<IEnumerable<FirmReadDtos>>(firms));
        }

        // GET api/<FirmController>/5
        [HttpGet("{id}")]
        public ActionResult<PersonelReadDtos> Get(int id)
        {
            var firm = _firmRepo.GetFirmById(id);
            var firmPersonels = _personelRepo.GetPersonelByFirmId(firm.FirmId);
            firm.Personel = firmPersonels;

            return Ok(_mapper.Map<FirmReadDtos>(firm));
        }

        [HttpPost]
        public ActionResult Post([FromBody] FirmReadDtos firmReadDtos)
        {
            var firmDto = _mapper.Map<FirmModel>(firmReadDtos);  
            _firmRepo.AddFirm(firmDto);
            return Ok("Firm has been added"); 
        }

       
    }
}
