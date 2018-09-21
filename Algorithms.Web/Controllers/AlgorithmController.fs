namespace Algorithms.Web.Controllers

open System.Collections.Generic
open Microsoft.AspNetCore.Mvc
open QuickSort

[<Route("api/algorithm")>]
[<ApiController>]
type AlgorithmController ()=
    inherit ControllerBase()

    [<HttpGet("sort/quick")>]
    member this.Get(values : string) =
        let array = values.Split [|','|] |> Seq.map System.Int32.Parse 
        let result = quicksort <| List.ofSeq array
        ActionResult<IEnumerable<int>>(result)