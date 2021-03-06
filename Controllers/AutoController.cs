using Microsoft.AspNetCore.Mvc;

[Route("api/auto/quotes")]

public class AutoController : Controller
{

    //Post api/auto/quotes

    [HttpPost]

    public IActionResult Post([FromBody]string value)

    {
        return Created ("",value);

    }   

    //Get api/auto/quotes/5
    [HttpGet("{id}")]
    public IActionResult Get (int id)
    {
        return Ok ("The id is:" + id);
    }

    //PUT Api/auto/quotes/id
    [HttpPut("{id}")]

    public IActionResult Put (int id, [FromBody]string value)
    {
        return NoContent();
    }

    //Delete api/auto/quotes/
    [HttpDelete("{id}")]
    
    public IActionResult Delete()
    {
        return Delete();
    }
}