# BenchmarkDotNet
Template Benchmark For API

**Installation**: https://www.nuget.org/packages/BenchmarkDotNet/
* CLI: dotnet add package BenchmarkDotNet --version 0.13.2
* PM> NuGet\Install-Package BenchmarkDotNet -Version 0.13.2

**Set up**:
* Step 1: Create API from The `Test Project`
* Step 2: Open The `Benchmark project` (this source) and install `BenchmarkDotNet package`
* Step 3: Design your Benchmark
  * Write a class with methods that you want to measure and mark them with the **Benchmark** attribute. In the following example, I compare GetListFromRepo and GetListThenOrderBy functions:

  * <img width="529" alt="image" src="https://user-images.githubusercontent.com/77050366/203266921-d11cd1da-a0bf-4b15-a71b-affb4afb016c.png">

* Step 4: Build Benchmark project and view result
  * ![image](https://user-images.githubusercontent.com/77050366/203268452-84cbdcbc-10de-4c75-a511-e9af3736461c.png)

  * Note: build it in **RELEASE**


**EXTEND:**

* Config options:

_______ Update later~

* Attribute options:

_______ Update later~

