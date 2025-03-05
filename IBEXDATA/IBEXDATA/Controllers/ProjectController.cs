using IBEXDATA.Models;
using Microsoft.AspNetCore.Mvc;
using Common.DTO;
using Service;
using AutoMapper;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _ProjectService;
        private readonly ILogger<ProjectController> _logger;
        private readonly IMapper _mapper;

        public ProjectController(IProjectService ProjectService, ILogger<ProjectController> logger, IMapper mapper)
        {
            _ProjectService = ProjectService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ProjectCreateDTO Project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var proj = _mapper.Map<ProjectCreateDTO, Project>(Project);

            var projto = await _ProjectService.Add(proj);

            if (projto != null)
            {
                _logger.LogInformation("Successfully added Project: {ProjectName}", Project.ProjectName);

                ProjectDTO newProj = _mapper.Map<Project, ProjectDTO>(projto);
                return CreatedAtAction(nameof(GetById), new { id = newProj.ProjectId }, newProj);
            }

            _logger.LogWarning("Failed to add Project: {ProjectName}", Project.ProjectName);
            return BadRequest($"The Project {Project.ProjectName} not successfully added");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var proj = await _ProjectService.GetById(id);
            if (proj == null)
            {
                return NotFound();
            }

            var projDTO = _mapper.Map<Project, ProjectDTO>(proj);
            return Ok(projDTO);
        }




        [HttpGet("GetByContactorID/{id}")]
        public async Task<IActionResult> GetByContactorID(int id)
        {
            var proj = await _ProjectService.GetByContactorID(id);
            if (proj == null || !proj.Any())
            {
                return NotFound();
            }

            var projDTO = _mapper.Map<List<Project>, List<ProjectDTO>>(proj);
            return Ok(projDTO);
        }
    }
}

//using IBEXDATA.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Common;
//using Common.DTO;
//using Service;
//using AutoMapper;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Application.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProjectController : ControllerBase
//    {
//        private readonly IProjectService _ProjectService;
//        private readonly ILogger<ProjectController> _logger;  // הוספת הלוגר
//        IMapper _Mapper;

//        // עדכון הקונסטרקטור להוספת הלוגר
//        public ProjectController(IProjectService ProjectService, ILogger<ProjectController> logger, IMapper mapper)
//        {
//            _ProjectService = ProjectService;
//            _logger = logger;
//            _Mapper = mapper;
//        }
//        //FromBody FromQuery
//        [HttpPost]
//        public async Task<IActionResult> Add([FromBody] ProjectDTO Project)
//        {
//            var proj = _Mapper.Map<ProjectDTO, Project>(Project);
//          //  proj.ProjectName 

//            var projto = await _ProjectService.Add(proj);

//            if (projto != null)
//            {
//                _logger.LogInformation("Successfully added Project: {ProjectName}", Project.ProjectName);

//                ProjectDTO newProj = _Mapper.Map<Project, ProjectDTO>(projto);
//               // return CreatedAtAction(nameof(GetById), new { id = userdto.UserId }, user);
//                return Ok($"The Project {Project.ProjectName} added successfully");
//            }

//            _logger.LogWarning("Failed to add Project: {DonatorName}", Project.ProjectName);  
//            return BadRequest($"The Project {Project.ProjectName} not successfully added");
//        }

//    }
//}


//// GET: api/<Project>
////[HttpGet]
////public async Task<ActionResult<UserDTO>> Get(string id)
////{
////    User u = await Service.;
////    UserDTO userdto = _Mapper.Map<User, userdto>(u);
////}
////// PUT api/<Project>/5
////[HttpPut("{id}")]
////public void Put(int id, [FromBody] string value)
////{
////}

////// DELETE api/<Project>/5
////[HttpDelete("{id}")]
////public void Delete(int id)
////{
////}

////public IEnumerable<string> Get()
////{
////    return new string[] { "value1", "value2" };
////}

////// GET api/<Project>/5
////[HttpGet("{id}")]
////public string Get(int id)
////{
////    return "value";
////}
