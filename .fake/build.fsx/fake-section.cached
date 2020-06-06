#r "paket:
nuget Fake.DotNet.Cli
nuget Fake.IO.FileSystem
nuget Fake.Core.Target
nuget FSharp.Data //"
#r "System.Xml.Linq.dll"
#load ".fake/build.fsx/intellisense.fsx"
open Fake.Core
open Fake.Core.TargetOperators
open FSharp.Data

Target.initEnvironment ()

type Author = XmlProvider<"""<author name="Paul Feyerabend" born="1924" />""">
let sample = Author.Parse("""<author name="Karl Popper" born="1902" />""")
Target.create "Xml" (fun _ ->
  Trace.log "here"
  )

Target.create "All" ignore

"Xml"
  ==> "All"

Target.runOrDefault "All"
