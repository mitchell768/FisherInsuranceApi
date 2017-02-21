using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/quotes")]

public class QuotesController : Controller
{
    private IMemoryStore db;
    public QuotesController(IMemoryStore repo){
        db = repo;
    }

    //Post api/quotes

    [HttpPost]

    public IActionResult Post([FromBody] Quote quote)

    {
        return Ok(db.CreateQuote(quote));

    }   

    //Get api/quotes
    [HttpGet]
    public IActionResult GetQuotes(){
        return Ok(db.RetrieveAllQuotes);
    }
    //Get api/auto/quotes/5
    [HttpGet("{id}")]
        public IActionResult Get (int id)
    {
        return Ok (db.RetrieveQuote(id));
    }

    //PUT Api/quotes/id
    [HttpPut("{id}")]

    public IActionResult Put ([FromBody]Quote quote)
    {
        return Ok(db.UpdateQuote(quote));
    }

    //Delete api/quotes/
    [HttpDelete("{id}")]
    
    public IActionResult Delete(int id)
    {
        db.DeleteQuote(id);
        return Ok();
    }
}