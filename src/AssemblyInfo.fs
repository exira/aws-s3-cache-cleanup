namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("aws-s3-cache-cleanup")>]
[<assembly: AssemblyProductAttribute("Exira.AwsS3Cache.Cleanup")>]
[<assembly: AssemblyDescriptionAttribute("Exira.AwsS3Cache.Cleanup is a task which cleans up expired cached objects from AWS S3")>]
[<assembly: AssemblyVersionAttribute("0.1.4")>]
[<assembly: AssemblyFileVersionAttribute("0.1.4")>]
[<assembly: AssemblyMetadataAttribute("githash","834e0f511c56dc5f4000fc05648baa0b85acde22")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.4"
