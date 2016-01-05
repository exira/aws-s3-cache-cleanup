namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("aws-s3-cache-cleanup")>]
[<assembly: AssemblyProductAttribute("Exira.AwsS3Cache.Cleanup")>]
[<assembly: AssemblyDescriptionAttribute("Exira.AwsS3Cache.Cleanup is a task which cleans up expired cached objects from AWS S3")>]
[<assembly: AssemblyVersionAttribute("0.1.6")>]
[<assembly: AssemblyFileVersionAttribute("0.1.6")>]
[<assembly: AssemblyMetadataAttribute("githash","51ecacf0fc2e9b69110135f49d503f0c9ef9bf15")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.6"
