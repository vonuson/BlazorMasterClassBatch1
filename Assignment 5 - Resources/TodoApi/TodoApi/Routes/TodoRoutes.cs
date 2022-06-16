using Microsoft.EntityFrameworkCore;
using TodoApi.Model;

namespace TodoApi.Routes
{
    public static class TodoRoutes
    {
        public static void MapTodoRoutes(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/todoitems", async (TodoDb db) =>
                await db.Todos.ToListAsync());

            app.MapGet("/api/todoitems/{id}", async (int id, TodoDb db) =>
                await db.Todos.FindAsync(id)
                    is Todo todo
                        ? Results.Ok(todo)
                        : Results.NotFound());

            app.MapPost("/api/todoitems", async (Todo todo, TodoDb db) =>
            {
                db.Todos.Add(todo);
                await db.SaveChangesAsync();

                return Results.Created($"/todoitems/{todo.Id}", todo);
            });

            app.MapPut("/api/todoitems/{id}", async (int id, Todo inputTodo, TodoDb db) =>
            {
                var todo = await db.Todos.FindAsync(id);

                if (todo is null) return Results.NotFound();

                todo.Title = inputTodo.Title;
                todo.Description = inputTodo.Description;
                todo.IsComplete = inputTodo.IsComplete;

                await db.SaveChangesAsync();

                return Results.NoContent();
            });

            app.MapDelete("/api/todoitems/{id}", async (int id, TodoDb db) =>
            {
                if (await db.Todos.FindAsync(id) is Todo todo)
                {
                    db.Todos.Remove(todo);
                    await db.SaveChangesAsync();
                    return Results.Ok(todo);
                }

                return Results.NotFound();
            });
        }
    }
}
