module UpsertPersonUseCase

    open fsharp_app.IO

    let Execute (input : CreatePersonInput) : CreatePersonOutput=
        {
            Id = System.Random.Shared.Next(0, 999)
            Email = input.Name
        }