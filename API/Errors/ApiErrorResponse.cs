using System;

namespace API.Errors;

public class ApiErrorResponse(int statusCode,string messsage, string? details)
{
    public int StatusCode { get; set; }= statusCode;
    public string Message { get; set; }= messsage;

    public string? Details { get; set; }= details;
}
