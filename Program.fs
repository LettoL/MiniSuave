open MiniSuave
open MiniSuave.Http
open MiniSuave.Console
open MiniSuave.Successful
open MiniSuave.Filters
open MiniSuave.Combinators

[<EntryPoint>]
let main argv =
  let request = {Route = ""; Type = Http.GET}
  let response = {Content = ""; StatusCode = 200}
  let context = {Request = request; Response = response}
  
  let app = Choose [
    GET >=> Path "/hello" >=> OK "Hello GET"
    POST >=> Path "/hello" >=> OK "Hello POST"
    Path "/foo" >=> Choose [
      GET >=> OK "Foo GET"
      POST >=> OK "FOO POST"
    ]
  ]
  
  executeInLoop context app
  
  0
