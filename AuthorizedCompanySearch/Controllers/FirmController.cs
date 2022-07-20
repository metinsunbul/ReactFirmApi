using AuthorizedCompanySearch.Data;
using AuthorizedCompanySearch.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthorizedCompanySearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmController : ControllerBase
    {
        private readonly IFirmRepo _firmRepo;
        private readonly IMapper _mapper;

        public FirmController(IFirmRepo firmRepo, IMapper mapper)
        {

            _firmRepo = firmRepo;
            _mapper = mapper;
        }

        // GET: api/<FirmController>
        [HttpGet]
        public ActionResult<IEnumerable<PersonelReadDtos>> Get()
        {
            var firms =  _firmRepo.GetAllFirm();

            return Ok(_mapper.Map<IEnumerable<PersonelReadDtos>>(firms));
        }

        // GET api/<FirmController>/5
        [HttpGet("{id}")]
        public ActionResult<PersonelReadDtos> Get(int id)
        {
            var firm = _firmRepo.GetFirmById(id);

            return Ok(_mapper.Map<PersonelReadDtos>(firm));
        }

       
    }
}
