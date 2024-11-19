## Welcome to a Asp.Net (C#) Project! 👋

# Backend for API Produtos

## Some code that I'm proud of
```csharp
[HttpPut("{id}")]
public async Task<ActionResult> PutProduto(int id, ProdutoClass produto)
{
    if (id != produto.ID)
    {
        return BadRequest();
    }

    _produtoClassContext.Entry(produto).State = EntityState.Modified;
    try
    {
        await _produtoClassContext.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        throw;
    }
    return Ok();
}
```

## Built with

- `C#`
- `Asp.Net Core Web API`
- `Entity Framework`
- `Sql Server`

## You Can
- Use local database;
- Use all CRUD functions;
- Connect with front-end.

## Front-End repository: [See Front-End!](https://github.com/lucasbailo/front-end-api-produtos)

## Author

- Website - [My GitHub](https://github.com/lucasbailo)
- Frontend Mentor - [@lucasbailo](https://www.frontendmentor.io/profile/lucasbailo)
- Instagram - [@lucassbailo](https://www.instagram.com/lucassbailo/)
- LinkedIn - [Lucas Bailo](https://www.linkedin.com/in/lcsbailo)
