# MathPowWithNan
This repository shows the difference between Math.Pow(1,double.NaN) in .Net Framework vs .Net Core

In .Net Framework Math.Pow(1,double.NaN) results in double.NaN, whereas

In .Net Core Math.Pow(1,double.NaN)  results in 1.0

According to the documentation [https://docs.microsoft.com/de-de/dotnet/api/system.math.pow?view=net-6.0 the](https://docs.microsoft.com/de-de/dotnet/api/system.math.pow?view=net-6.0%C2%A0the) .
Net Framework behaviour is the correct one.
