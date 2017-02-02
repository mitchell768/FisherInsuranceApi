using Microsoft.AspNetCore.Mvc;

[Route("api/life/quotes")]

public class LifeController : Controller
{

    //Post api/life/quotes

    [HttpPost]

    public IActionResult Post([FromBody]string value)

    {
        return Created ("",value);

    }   

    //Get api/life/quotes/5
    [HttpGet("{id}")]
    public IActionResult Get (int id)
    {
        return Ok ("The id is:" + id);
    }

    //PUT Api/life/quotes/id
    [HttpPut("{id}")]

    public IActionResult Put (int id, [FromBody]string value)
    {
        return NoContent();
    }

    //Delete api/life/quotes/id
    [HttpDelete("{id}")]
    
    public IActionResult Delete(int id)
    {
        return Delete(id);
    }
}