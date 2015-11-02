namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("aws-s3-cache-cleanup")>]
[<assembly: AssemblyProductAttribute("Exira.AwsS3Cache.Cleanup")>]
[<assembly: AssemblyDescriptionAttribute("Exira.AwsS3Cache.Cleanup is a task which cleans up expired cached objects from AWS S3")>]
[<assembly: AssemblyVersionAttribute("0.1.2")>]
[<assembly: AssemblyFileVersionAttribute("0.1.2")>]
[<assembly: AssemblyMetadataAttribute("githash","4112c2aaed12313c97456a2968a94c3782ae6979")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.2"
