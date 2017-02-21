using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/claims")]

public class ClaimsController : Controller
{

    private IMemoryStore db;
    public ClaimsController(IMemoryStore repo)
    {
        db = repo;
    }

    //Post api/claims

    [HttpPost]

    public IActionResult Post([FromBody]Claim claim)

    {
        return Ok (db.CreateClaim(claim));

    }   
    //Get api/claims
    [HttpGet]
    public IActionResult GetClaims(){
        return Ok (db.RetrieveAllClaims);
    }
    //Get api/claims/5
    [HttpGet("{id}")]
    public IActionResult Get (int id)
    {
        return Ok (db.RetrieveClaim(id));
    }

    //PUT Api/claim/id
    [HttpPut("{id}")]

    public IActionResult Put ([FromBody] Claim claim)
    {
        return Ok(db.UpdateClaim(claim));
    }

    //Delete api/claim/
    [HttpDelete("{id}")]
    
    public IActionResult Delete(int id)
    {
        db.DeleteClaim(id);
        return Ok();
    }
}