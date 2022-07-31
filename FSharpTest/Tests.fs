module Tests

open System
open FSharpAndCSharp
open Hedgehog
open Hedgehog.Xunit


//[<Property; Recheck("19_11670738321710543822_15170413700225871527_1010101010")>]
////[<Property>]
//let ``Test with Property attribute`` (x : int32, y : int32) =
//    let res = FSModule.add x y
//    res = x + y
   
[<Xunit.Fact>]
let ``Test with plain Hedgehog`` () =
    let prop =
        property {
            let! x = Gen.int32 (Range.linearBounded())
            let! y = Gen.int32 (Range.linearBounded())
            return (x + y) = (FSModule.add x y)
        }
    prop |> Property.recheckBool "0_7333683850760263877_13670925995324076957_01010101010101010101010101010101010110110"
//    prop |> Property.checkBool
