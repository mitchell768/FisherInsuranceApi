using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

[Route("api/quotes")]

public class QuotesController : Controller
{
    //Post api/quotes
    private readonly FisherContext db;
    public QuotesController(FisherContext context){
        db=context;
    }
    
    [HttpPost]

    public IActionResult Post([FromBody] Quote quote)

    {
        var newQuote = db.Quotes.Add(quote);
        db.SaveChanges();
        return CreatedAtRoute("Get Claim", new {id = quote.Id, quote});
    }   

    //Get api/quotes
    [HttpGet]
    public IActionResult GetQuotes(){
       return Ok(db.Quotes);
    }

    //Get api/auto/quotes/5
    [HttpGet("{id}", Name = "GetClaim")]
        public IActionResult Get (int id){            
        return Ok (db.Quotes.Find(id));
    }

    //PUT Api/quotes/id
    [HttpPut("{id}")]
    public IActionResult Put (int id, [FromBody]Quote quote)
    {
        var newQuote = db.Quotes.Find(id);
        if(newQuote == null){
            return NotFound();
        }
        newQuote=quote;
        db.Quotes.Update(newQuote);
        db.SaveChanges();
        return Ok(newQuote);       
    }

    //Delete api/quotes/
    [HttpDelete("{id}")]    
    public IActionResult Delete(int id)
    {
        var quoteToDelete = db.Quotes.Find(id);
        if (quoteToDelete== null){
            return NotFound();
        }
        db.Quotes.Remove(quoteToDelete);
        db.SaveChangesAsync();
        return NoContent();
    }
}