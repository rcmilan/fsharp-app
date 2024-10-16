namespace fsharp_app.Controllers

open Microsoft.AspNetCore.Mvc
open fsharp_app.IO

[<ApiController>]
[<Route("[controller]")>]
type public PersonController() =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() : ActionResult  =
        let people : CreatePersonOutput[] = [| { Id = 1; Email = "email@email.com" } |]
        
        //if people.Length > 0 then
        //    OkObjectResult(people)
        //else
        //    NotFoundResult()
        
        match people with
        | [||] -> NotFoundResult()
        | _ -> OkObjectResult(people)


    [<HttpGet("{id}")>]
    member _.Get([<FromRoute>] id : int) : GetPersonOutput =
        GetPersonUseCase.Execute id

    [<HttpPost>]
    member _.Post([<FromBody>] input : CreatePersonInput) : CreatePersonOutput =
        UpsertPersonUseCase.Execute input