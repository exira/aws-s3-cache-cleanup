namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("aws-s3-cache-cleanup")>]
[<assembly: AssemblyProductAttribute("Exira.AwsS3Cache.Cleanup")>]
[<assembly: AssemblyDescriptionAttribute("Exira.AwsS3Cache.Cleanup is a task which cleans up expired cached objects from AWS S3")>]
[<assembly: AssemblyVersionAttribute("0.1.5")>]
[<assembly: AssemblyFileVersionAttribute("0.1.5")>]
[<assembly: AssemblyMetadataAttribute("githash","5b9d940d743e48c185590aa3794b81d2ddcb2b43")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.5"
