namespace fsharp_app.IO

open System.ComponentModel.DataAnnotations

type public CreatePersonInput = 
    {
        [<Required>]
        [<MinLength(1)>]
        Name : string
    }

