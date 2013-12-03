#r @"tools\FAKE\tools\FakeLib.dll"

open Fake
RestorePackages()

// Directories
let buildDir  = "build"
let testDir   = "test"
let deployDir = "deploy"

Target "Clean" (fun _ -> 
    CleanDirs [buildDir; testDir; deployDir]
)

Target "BuildApp" (fun _ ->
    !! @"src\App\**\*.fsproj"
      |> MSBuildDebug buildDir "Build"
      |> Log "AppBuild-Output: "
)

Target "BuildTest" (fun _ ->
    !! @"src\Tests\**\*.fsproj"
      |> MSBuildDebug testDir "Build"
      |> Log "TestBuild-Output: "
)

Target "Test" (fun _ ->
    !! (testDir + "/Tests.dll") 
      |> NUnit (fun p ->
          {p with
             DisableShadowCopy = true;
             OutputFile = testDir + "TestResults.xml" })
)

"Clean" 
  ==> "BuildApp"
  ==> "BuildTest"
  ==> "Test"

RunTargetOrDefault "Test"
