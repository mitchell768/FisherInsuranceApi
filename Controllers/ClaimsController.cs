using Microsoft.AspNetCore.Mvc;

[Route("api/claims")]

public class ClaimsController : Controller
{

    //Post api/claims

    [HttpPost]

    public IActionResult Post([FromBody]string value)

    {
        return Created ("",value);

    }   

    //Get api/claims/5
    [HttpGet("{id}")]
    public IActionResult Get (int id)
    {
        return Ok ("The id is:" + id);
    }

    //PUT Api/claim/id
    [HttpPut("{id}")]

    public IActionResult Put (int id, [FromBody]string value)
    {
        return NoContent();
    }

    //Delete api/claim/
    [HttpDelete("{id}")]
    
    public IActionResult Delete()
    {
        return Delete();
    }
}