module GetPersonUseCase

    open fsharp_app.IO

    let Execute (id : int) : GetPersonOutput =
        {
            Id = id;
            Email = "email@email.com"
        }