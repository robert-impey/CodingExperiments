// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System.IO
open System.Runtime.Serialization
open System.Text
open System.Xml

[<DataContract>]
type Foo = 
    { [<field:DataMember>]
      Bar : string }

[<EntryPoint>]
let main argv = 
    let foo = { Bar = "Baz" }
    let serializer = DataContractSerializer(typeof<Foo>)
    let stringBuilder = new StringBuilder()
    let writer = new XmlTextWriter(new StringWriter(stringBuilder))
    serializer.WriteObject(writer, foo)
    printfn "%s" <| stringBuilder.ToString()
    0
