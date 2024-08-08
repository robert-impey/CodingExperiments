let fmt = "{0} {1} {2}"

// Create an array of strings
let strs = [| "one"; "two"; "three" |]

//printfn "%s" (System.String.Format(fmt, strs))
(*
> 
System.FormatException: Index (zero based) must be greater than or equal to zero and less than the size of the argument list.
   at System.Text.StringBuilder.AppendFormatHelper(IFormatProvider provider, String format, ParamsArray args)
   at System.String.FormatHelper(IFormatProvider provider, String format, ParamsArray args)
   at <StartupCode$FSI_0003>.$FSI_0003.main@() in C:\Users\a-roimpe\Documents\GitHub\CodingExperiments\F-Sharp\FormattingArrays.fsx:line 3
Stopped due to error
*)

// These run without a problem.
let objs = strs |> Array.map box

printfn "%s" (System.String.Format(fmt, objs))

printfn "%s" (System.String.Format(fmt, Array.map box strs))
