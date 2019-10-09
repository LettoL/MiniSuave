open MiniSuave.Http
open MiniSuave.Console
open MiniSuave.Successful

[<EntryPoint>]
let main argv =
  let request = {Route = ""; Type = GET}
  let response = {Content = ""; StatusCode = 200}
  let context = {Request = request; Response = response}
  
  executeInLoop context (OK "Hello Suave")
  
  0
