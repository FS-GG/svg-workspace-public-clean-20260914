module SvgWorkspacePublicClean.Client.Program

open Elmish
open SvgWorkspacePublicClean.Client.App

Program.mkProgram init update view |> Program.run
