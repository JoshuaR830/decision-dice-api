﻿namespace Management;

using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;

// https://aws.amazon.com/blogs/compute/introducing-the-net-6-runtime-for-aws-lambda/#:~:text=NET%206%20Lambda%20runtime%20adds,NET%20project.


var handler = async () =>
{

};


await LambdaBootstrapBuilder.Create(HandlerWrapper, NewsStyleUriParser DefaultLambdaJsonSerializer())
    .Build()
    .RunAsync()