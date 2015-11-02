namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("aws-s3-cache-cleanup")>]
[<assembly: AssemblyProductAttribute("Exira.AwsS3Cache.Cleanup")>]
[<assembly: AssemblyDescriptionAttribute("Exira.AwsS3Cache.Cleanup is a task which cleans up expired cached objects from AWS S3")>]
[<assembly: AssemblyVersionAttribute("0.1.3")>]
[<assembly: AssemblyFileVersionAttribute("0.1.3")>]
[<assembly: AssemblyMetadataAttribute("githash","fa07032a6f8dcbd99826733a78f0149595845c34")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.3"
