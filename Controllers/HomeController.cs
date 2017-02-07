using Microsoft.AspNetCore.Mvc;

[Route("api/home/quotes")]

public class HomeController : Controller
{

    //Post api/home/quotes

    [HttpPost]

    public IActionResult Post([FromBody]string value)

    {
        return Created ("",value);

    }   

    //Get api/home/quotes/5
    [HttpGet("{id}")]
    public IActionResult Get (int id)
    {
        return Ok ("The id is:" + id);
    }

    //PUT Api/home/quotes/id
    [HttpPut("{id}")]

    public IActionResult Put (int id, [FromBody]string value)
    {
        return NoContent();
    }

    //Delete api/home/quotes/    [HttpDelete("{id}")]
    
    public IActionResult Delete()
    {
        return Delete();
    }
}