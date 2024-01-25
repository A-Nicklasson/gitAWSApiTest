var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!!!");
app.MapGet("/add", (int num1, int num2) => addNumbers(num1, num2));
app.MapGet("/sub", (int num1, int num2) => subtractNumber(num1, num2));

app.Run();

string addNumbers(int num1, int num2) { 

    return $"Summan av {num1} och {num2} är: {num1 + num2}";

}

string subtractNumber(int num1, int num2) { 

    return $"Differensen av {num1} och {num2} är: {num1 - num2}";

}