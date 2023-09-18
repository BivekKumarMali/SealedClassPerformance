# Performance Comparison: Sealed Class vs. Open Class in C#

## Overview
This .NET console application demonstrates a performance comparison between a sealed class and a open class in the C# programming language. In C#, a sealed class is one that cannot be inherited, which may have performance implications compared to Open classes. This project aims to measure and showcase the performance differences between the two.

## Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download/dotnet)

## Getting Started

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/BivekKumarMali/SealedClassPerformance.git
	```
2. Navigate to the project directory:
	```bash
   cd SealedClassPerformance
	```
3. Build the project:
	```bash
   dotnet build
	```
4. Install the BenchmarkDotNet NuGet package:
	```bash
   dotnet add package BenchmarkDotNet
	```
5. Run the application:
	```bash
   dotnet run
	```

## Performance Comparison

The application includes two classes: SealedClass and OpenClass. The main program measures the time it takes to create instances of these classes and call a method on them to showcase the performance difference.

## Benchmarking with BenchmarkDotNet

BenchmarkDotNet will run the benchmarks and provide detailed performance results, including metrics like execution time, memory usage, and more. You can analyze these results to observe the performance differences between the SealedClass and OpenClass.