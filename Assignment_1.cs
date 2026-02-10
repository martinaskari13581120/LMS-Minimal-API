namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Library Management System API");



            app.MapPost("/auth/register", () =>
            {
                return " Staff registered successfully";
            });
            app.MapPost("/auth/login", () =>
            {
                return " Staff logged in successfully";
            });




            app.MapGet("/dashboard", () =>
            {
                return new
                {
                    TotalBooks = 100,
                    TotalReaders = 40,
                    ActiveBorrowering = 15
                };
            });



            app.MapGet("/books", () =>
            {
                return "List of all books";
            });
            app.MapGet("/books/{id}", (int id) =>
            {
                return $"Details of book with id ={id}";
            });
            app.MapPost("/books", () =>
            {
                return "Book added successfully";
            });
            app.MapPut("/books/{id}", (int id) =>
            {
                return $"Book with id={id} updated successfully";
            });
            app.MapDelete("/books/{id}", (int id) =>
            {
                return $"Book with id={id} deleted successfully";
            });



            app.MapGet("/readers", () =>
            {
                return "List of all readers";
            });
            app.MapPost("/readers/{id}", (int id) =>
            {
                return $"Details of reader with id={id}";
            });
            app.MapPost("/readers", () =>
            {
                return $"Reader added successfully";
            });

            app.MapPut("/readers/{id}", (int id) =>
            {
                return $"Readers with id={id} updated successfully";
            });
            app.MapDelete("/readers/{id}", (int id) =>
            {
                return $"Reader with {id}=id deleted successfully";
            });


            app.MapGet("/Borrowings/overdue", () =>
            {
                return new
                {
                    BorrowindId = 5,
                    DaysLate = 3,
                    Charge = "$6"
                };
            });


            app.MapGet("/reports/books", () =>
            {
                return "Books report generated";
            });
            app.MapGet("/reports/readers", () =>
            {
                return "Readers report generated";
            });
            app.MapGet("/reports/borrowings", () =>
            {
                return "Borrowings report generated";
            });

            app.Run();
        }
    }
}   
    


    

