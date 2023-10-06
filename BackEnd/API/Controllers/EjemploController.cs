using API.Dtos;
using API.Helpers;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class EjemploController : BaseApiController{

        private readonly IUnitOfWork _UnitOfWork;
        private readonly IMapper _Mapper;

        public EjemploController(IUnitOfWork unitOfWork,IMapper mapper){
            _UnitOfWork = unitOfWork;
            _Mapper = mapper;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<NombreDto>>> Get(){
            var records = await _UnitOfWork.NombrePluralIUnitOfWork!.GetAllAsync();
            return _Mapper.Map<List<NombreDto>>(records);
        }

        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<NombreDto>>> Get11([FromQuery] Params recordParams)
        {
            var record = await _UnitOfWork.NombrePluralIUnitOfWork!.GetAllAsync(recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
            var lstrecordsDto = _Mapper.Map<List<NombreDto>>(record.registros);
            return new Pager<NombreDto>(lstrecordsDto,record.totalRegistros,recordParams.PageIndex,recordParams.PageSize,recordParams.Search);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<NombreDto>> Get(string id)
        {
            var record = await _UnitOfWork.NombrePluralIUnitOfWork!.GetByIdAsync(id);
            if (record == null){
                return NotFound();
            }
            return _Mapper.Map<NombreDto>(record);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NombreEntidad>> Post(NombreDto recordDto){
            var record = _Mapper.Map<NombreEntidad>(recordDto);
            _UnitOfWork.NombrePluralIUnitOfWork!.Add(record);
            await _UnitOfWork.SaveAsync();
            if (record == null)
            {
                return BadRequest();
            }
            recordDto.Id = record.Id;
            return CreatedAtAction(nameof(Post),new {id= recordDto.Id}, recordDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NombreDto>> Put(string id, [FromBody]NombreDto recordDto){
            if(recordDto == null)
                return NotFound();
            var records = _Mapper.Map<NombreEntidad>(recordDto);
            _UnitOfWork.NombrePluralIUnitOfWork!.Update(records);
            await _UnitOfWork.SaveAsync();
            return recordDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(string id){
            var record = await _UnitOfWork.NombrePluralIUnitOfWork!.GetByIdAsync(id);
            if(record == null){
                return NotFound();
            }
            _UnitOfWork.NombrePluralIUnitOfWork.Remove(record);
            await _UnitOfWork.SaveAsync();
            return NoContent();
        }

    }
