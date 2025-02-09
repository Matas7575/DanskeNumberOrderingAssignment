<h1>Danske bank number sorting Assignment</h1>
<p>This is an Assignment project from Danske bank</p>
<p>The project is done adhering to SOLID principles</p>
<p>Tested using NUnit testing</p>
<p>Hand written Mocks were used</p>
<p>NuGet packages used:</p>
<li>Microsoft.AspNetCore.OpenApi</li>
<li>BenchmarkDotNet</li>

<h2>Running the project</h2>

<p>In order to launch the Web Api, clone the project and write in the console:</p>

`dotnet run`
<p>Thats it the, Web Api is running</p>
<h2>Using the Web Api</h2>
<p>Once the Web Api is running, it can receive requests</p>
<h3>Post request</h3>
<p>To sort numbers user has to use this POST request:</p>

`http://localhost:5126/sortArray`

<p>The body of the request has to be in this format</p>

```JSON

{
  "array": [5, 2, 8, 10, 9],
  "algorithm": "AlgorithmName"
}
```
<p>The algorithms that can be used are:</p>
<li>BubbleSort</li>
<li>MergeSort</li>
<li>QuickSort</li>

<p>To use them just replace "AlgorithmName" with the name of the algorithm</p>
<p>Currently the size of the array has to be 1-10 and on success it is going to give code 200 and say the name of the file where the result is written</p>
<p>The algorithms themselves can sort bigger arrays</p>
<h3>Get request</h3>
<p>To access the file with the latest result of the sorted array simply make a GET request:</p>

`http://localhost:5126/latest`

<p>The program should send back the results of the latest sorting</p>
<p>If the file is not yet generated, it will just give the response code</p>

<H2>Benchmarks</H2>
<p>BenchmarkDotNet is used to measure the speed of each algorithm.</p>
<p>To launch it, put the project in release mode:</p>

`dotnet run --configuration Release`
<p>Then launch the project with</p>

`dotnet run -- --benchmark`

<p>The program is going to benchmark the algorithms and make a report of each algorithms performance</p>

<h2>Testing</h2>
<p>Testing is done using NUnit testing using AAA (Arrange-Act-Assert) pattern</p>
<p>34 Tests have been written in total</p>
<p>Tests consists of:</p>
<li>Performance of the Algorithms and comparisons between them</li>
<li>Algorithm unit tests</li>
<li>Services tests</li>
<li>Api endpoints tests</li>

![image](https://github.com/user-attachments/assets/21f40e4e-8f84-4271-8373-00990decbf1b)


<h2>Comments inside the files</h3>
<p>Some files have comments to explain what certain files are.</p>
<p>Algorithms themselves are commented in how they work and what is their run-time complexity and space complexity</p>
