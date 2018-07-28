using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Waterman.DataAccess;
using Waterman.DataAccess.POCO;

namespace Waterman.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class TodoController
    {
        private readonly WatermanContext context;

        public TodoController(WatermanContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAll()
        {
            return new JsonResult(this.context.TodoItems.ToList());
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<Todo> GetById(long id)
        {
            var item = this.context.TodoItems.Find(id);

            return item ?? null;
        }

        [HttpPost]
        public IActionResult Create(Todo item)
        {
            this.context.TodoItems.Add(item);
            this.context.SaveChanges();

            return new CreatedAtRouteResult("GetTodo", new { Id=item.Id }, item);
        }

    }
}
