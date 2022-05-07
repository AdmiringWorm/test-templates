#include "./common.cake"

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src",
    title: "[[REPLACE_WITH_TITLE]]",
    repositoryOwner: "[[REPLACE_WITH_REPOSITORY_OWNER]]",
    repositoryName: "[[REPLACE_WITH_REPOSITORY_NAME]]",
    appVeyorAccountName: "[[REPLACE_WITH_APPVEYOR_ACCOUNT_NAME]]",
    shouldRunDotNetCorePack: true,
    shouldGenerateDocumentation: true,
    shouldRunCodecov: true,
    shouldRunCoveralls: false,
    shouldUseDeterministicBuilds: true,
    shouldUseTargetFrameworkPath: false,
    preferredBuildAgentOperatingSystem: PlatformFamily.Linux,
    preferredBuildProviderType: BuildProviderType.GitHubActions
)

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(
    context: Context
)

Build.RunDotNetCore();
