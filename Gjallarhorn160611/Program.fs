open System
open Gjallarhorn
open Gjallarhorn.Bindable
open Gjallarhorn.Validation
open FsXaml
open System.Windows


type MainWin = XAML<"MainWindow2.xaml">

[<STAThread>]
[<EntryPoint>]
let main _ =     

    Gjallarhorn.Wpf.install true |> ignore

    let app = Application()
    let win = MainWin(DataContext = Context3.create())
    app.Run win
    