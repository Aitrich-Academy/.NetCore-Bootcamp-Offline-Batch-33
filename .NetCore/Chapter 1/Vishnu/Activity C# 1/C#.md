#### c#

#### 

#### 1\. ASP.NET Core explanation

#### 

#### ASP.NET Core is a re‑designed, modular version of ASP.NET that runs on Windows, Linux, and macOS, and is optimized for cloud and container deployments. It offers features like a lightweight middleware-based HTTP pipeline, the Kestrel web server, built‑in dependency injection, flexible configuration, and first‑class support for modern web patterns such as MVC, Razor Pages, Blazor, and minimal APIs.

#### 

#### ----------------------------------------------------

#### 

#### 5\. Latest version of .NET Core

#### 

#### The old branding “.NET Core” has been unified under “.NET” since .NET 5; newer releases are just called .NET 5, 6, 7, 8, 9, 10, etc. As of late 2025, the most recent release is .NET 10 (an LTS version) released in November 2025, which continues the .NET Core line under the simplified “.NET” name.

#### 

#### -----------------------------------------------------

#### 

#### 7\. Docker in .NET Core

#### 

#### Docker is used to package .NET/ASP.NET Core applications into containers so that the app, its runtime, and dependencies run consistently across environments. ASP.NET Core and .NET have official Docker images (for example, asp.net and sdk images on Docker Hub) that let you build images using multi‑stage Dockerfiles, support container‑friendly configuration (environment variables, secrets), and integrate into orchestrators like Kubernetes and Azure Container Apps. Visual Studio and the .NET CLI both provide built‑in support to add Docker files, build images, and debug containerized ASP.NET Core apps.

#### 

#### -------------------------------------------------------

#### 

#### 8\. Specific features of .NET Core / ASP.NET Core

#### 

#### 

#### Some notable features you can mention in exams or interviews:​

#### 

#### ===> Built‑in dependency injection and middleware pipeline for request processing.

#### ===> Unified framework for MVC, Web API, Razor Pages, Signal R, and Blazor.

#### ===> Flexible configuration (JSON, environment variables, user secrets) and strong logging/diagnostics.

#### ===> Cross‑platform and cloud‑ready with first‑class support for Docker and microservices.

#### ===> High performance Kestrel web server and optimized runtime with JIT and async support.

#### ===> Side‑by‑side app versioning and choice of LTS vs current .NET releases for support.

#### 

#### ------------------------------------------------------------

#### 

#### 9\. name space?

#### 

#### In .NET / C#, a namespace is a logical container used to group related types (classes, interfaces, structs, enums, etc.) and avoid name conflicts.​

#### 

#### What a namespace does

#### Organizes code so related types live under a common “path”, for example System.Collections.Generic groups generic collection types like List<T>.​

#### 

#### Prevents naming collisions: you can have MyCompany.Project.Customer and OtherCompany.Project.Customer without conflict because their full names (including namespace) are different.​

#### 

#### Basic syntax and usage

#### Declaring a namespace (block scoped):

#### namespace MyCompany.MyProduct { /\* classes, interfaces, etc. \*/ }.​

#### 

#### Using a namespace:

#### 

#### With fully qualified name: MyCompany.MyProduct.Customer c = new MyCompany.MyProduct.Customer();.​

#### 

#### With using directive at top of file: using MyCompany.MyProduct; then simply Customer c = new Customer();

#### 

#### ---------------------------------------------------------------------

#### 

#### 6\. .NET SDK vs .NET Runtime

#### 

#### .NET Runtime:

#### Contains what is needed to run .NET apps: the runtime (CLR‑style engine), base libraries, JIT, and GC.​

#### Installed on machines that only need to execute existing .NET/ASP.NET Core applications, not develop them.​

#### 

#### .NET SDK:

#### Superset of the runtime that adds compilers, CLI tools (dotnet new/build/test/publish), project templates, and developer tooling.​

#### Required on development machines to create, build, test, and publish .NET/ASP.NET Core applications.

#### 

#### -----------------------------------------------------------------------

#### 

#### 2\. ASP.NET vs ASP.NET Core

#### 

#### ASP.NET is the older web framework that only works on Windows and uses the full .NET Framework. It runs apps mainly through IIS and includes everything built-in, which makes it heavier but simpler for basic Windows web sites. ASP.NET Core is the newer version rebuilt from scratch—it's much faster, smaller, and runs anywhere like Windows, Linux, or Mac, using modern .NET instead. Core uses a lightweight server called Kestrel, lets you pick only what you need via packages, and supports Docker/cloud easily, while old ASP.NET sticks to Windows-only hosting and feels slower for big apps.

#### 

#### ------------------------------------------------------------------------

#### 

#### 3\. Main Components of .NET (Core/Modern .NET)

#### 

#### The .NET runtime is the engine that actually runs your code—it handles memory cleanup (garbage collection), compiles it on-the-fly (JIT), keeps types safe, catches errors, and lets code talk to native apps. Base Class Libraries (BCL) are the ready-made tools everyone uses, like lists/dictionaries for data, file/network reading, threading for speed, and LINQ for easy queries across all your projects. SDK and tooling help you build: it packs compilers (like Roslyn for C#), commands like dotnet build or dotnet run, templates to start projects fast, and works with VS Code or Visual Studio. Workload libraries are add-ons for real apps—ASP.NET Core for websites/APIs, Entity Framework for databases, or MAUI for desktop/mobile—you grab them from NuGet as needed.

#### 

#### -------------------------------------------------------------------------

#### 

#### 4\. Characteristics of .NET Core

#### 

#### .NET Core (now just .NET) works on any operating system—Windows, Linux, or macOS—so you can build and run the same app anywhere without changes.​

#### It's fully open source on GitHub, meaning anyone can see, fix, or add to the code, and Microsoft plus thousands of developers keep improving it together.​

#### Apps stay small and fast because you only include the packages you need—no bloat—and it starts quickly with low memory use, perfect for cloud or containers.​

#### Deployment is flexible: run with shared runtime on servers or bundle everything self-contained, even side-by-side so multiple app versions don't conflict.

