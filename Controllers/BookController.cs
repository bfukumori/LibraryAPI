using LibraryAPI.Communication.Requests;
using LibraryAPI.Communication.Responses;
using LibraryAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;
public class BookController : LibraryAPIBaseController
{

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new Book()
        {
            Id = id,
            Title = "The Lord of The Rings",
            Author = "J.R.R Tolkien",
            Genre = "Fiction",
            Price = 50,
            Stock = 10
        };

        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new() {Id=1, Title ="The Lord of The Rings", Author = "J.R.R Tolkien", Genre = "Fiction", Price = 50, Stock = 10},
            new() { Id = 2, Title = "1984", Author = "George Orwell", Genre = "Dystopian", Price = 40, Stock = 15 },
            new() { Id = 3, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", Price = 35, Stock = 20 },
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestCreateBookJson request)
    {
        var response = new ResponseCreateBookJson
        {
            Id = 1,
            Title = request.Title
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }
}
