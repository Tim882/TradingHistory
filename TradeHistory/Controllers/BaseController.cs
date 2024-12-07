using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeHistory.Data.Interfaces;
using TradeHistory.Models;

namespace TradeHistory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseEntity
    {
        protected readonly IBaseDataService<T> _dataService;

        public BaseController(IBaseDataService<T> dataService)
        {
            _dataService = dataService;
        }

        [Route("api/[controller]/all")]
        [HttpGet]
        public IActionResult Get(long id)
        {
            try
            {
                T entity = _dataService.Get(id);

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                List<T> entities = _dataService.Get();

                return Ok(entities);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] T entity)
        {
            try
            {
                if (_dataService.Create(entity))
                {
                    return Ok();
                }

                return StatusCode(500, "Entity was not added");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] T entity)
        {
            try
            {
                if (_dataService.Update(entity))
                {
                    return Ok();
                }

                return StatusCode(500, "Entity was not updated");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            try
            {
                if (_dataService.Delete(id))
                {
                    return Ok();
                }

                return StatusCode(500, "Entity was not deleted");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
