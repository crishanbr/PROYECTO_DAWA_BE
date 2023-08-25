using Microsoft.AspNetCore.Mvc;

namespace DON_KILO_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaRepository _categoriaRepository;
        
        public CategoriaController(IMapper mapper, ICategoriaRepository categoriaRepository)
        {
            _mapper = mapper;
            _categoriaRepository = categoriaRepository;
        }

        [HttpGet(Name = "GetCategoria")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var categorias = await _categoriaRepository.GetListCategorias();
                var categoriasDto = _mapper.Map<List<CategoriaDTO>>(categorias);
                return Ok(categoriasDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
