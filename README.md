# BenchmarkDotNet
Template Benchmark For API

Installation: https://www.nuget.org/packages/BenchmarkDotNet/

__ CLI: dotnet add package BenchmarkDotNet --version 0.13.2

__ PM> NuGet\Install-Package BenchmarkDotNet -Version 0.13.2

Following step:

__ Step 1: Create API from Test Project

__ Step 2: Open Benchmark project (this source) and Installation BenchmarkDotNet package

__ Step 3: Design a Benchmark

______ Write a class with methods that you want to measure and mark them with the **Benchmark** attribute. In the following example, I compare GetListFromRepo and GetListThenOrderBy functions:

________ <img width="529" alt="image" src="https://user-images.githubusercontent.com/77050366/203266921-d11cd1da-a0bf-4b15-a71b-affb4afb016c.png">

__ Step 4: Build Benchmark project and view result
________ ![image](https://user-images.githubusercontent.com/77050366/203268452-84cbdcbc-10de-4c75-a511-e9af3736461c.png)

________ Note: build it in RELEASE


