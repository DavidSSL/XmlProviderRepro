#r "paket:
nuget Fake.DotNet.Cli
nuget Fake.IO.FileSystem
nuget Fake.Core.Target
nuget FSharp.Data //"
#r "System.Xml.Linq.dll"
#load ".fake/build.fsx/intellisense.fsx"
open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators
open FSharp.Data

Target.initEnvironment ()

(*
Target.create "Clean" (fun _ ->
    !! "src/**/bin"
    ++ "src/**/obj"
    |> Shell.cleanDirs
)

Target.create "Build" (fun _ ->
    !! "src/**/*.*proj"
    |> Seq.iter (DotNet.build id)
)
*)
Target.create "Xml" (fun _ ->
  Trace.log "here"
  )

Target.create "All" ignore

(*
"Clean"
  ==> "Build"
  ==> "All"
*)

"Xml"
  ==> "All"
  
Target.runOrDefault "All"
