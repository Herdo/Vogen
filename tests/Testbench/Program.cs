﻿using System;
using Vogen;

//[assembly: VogenDefaults(conversions: (Conversions)666)]

namespace Whatever;



public class Program
{
    public static void Main()
    {
        // throw new MyValidationException("aa");
    }
}


[ValueObject(underlyingType:typeof(int))]
public partial struct CustomerId
{
    private static Validation Validate(int value) => value > 0 ? Validation.Ok : Validation.Invalid("xxxx");
}

public class MyValidationException : Exception
{
    public MyValidationException(string message) : base(message) { }
}