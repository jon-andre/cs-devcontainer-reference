# cs-devcontainer-reference

A simple C# project using Devcontainer and the CS Dev Kit. Based on [MS Learn](https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio)

Things to remember at the time of writing:

 * If you don't have access to Docker Desktop use Rancher Desktop over Podman Desktop
 * Creating Devcontainers 
 * Using the Solution Explorer GUI in VSCode seems to cause fewer issues (Devcontainer and local).
 * Project References are not updated automatically. Close and open Solution (Devcontainer only).
 * When adding a new Test Project the Devcontainer must be restarted to get Test View to work (Devcontainer).