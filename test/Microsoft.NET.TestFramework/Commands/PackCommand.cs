// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq;
using Microsoft.DotNet.Cli.Utils;

namespace Microsoft.NET.TestFramework.Commands
{
    public sealed class PackCommand : TestCommand
    {
        public PackCommand(MSBuildTest msbuild, string projectPath)
            : base(msbuild, projectPath)
        {
        }

        public override CommandResult Execute(params string[] args)
        {
            var newArgs = args.ToList();
            newArgs.Insert(0, FullPathProjectFile);

            var command = MSBuild.CreateCommandForTarget("pack", newArgs.ToArray());

            return command.Execute();
        }
    }
}
