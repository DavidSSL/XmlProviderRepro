#r ".fake/build.fsx/packages/FSharp.Data/lib/netstandard2.0/FSharp.Data.dll"
#r "System.Xml.Linq.dll"
open FSharp.Data

type Author = XmlProvider<"""<author name="Paul Feyerabend" born="1924" />""">
let sample = Author.Parse("""<author name="Karl Popper" born="1902" />""")

printfn "%s (%d)" sample.Name sample.Born