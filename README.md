# MathAPI

This API provides the functionality to check if given numbers are multiple of eleven.

It is written in C# (.NET Core) and it was built using Visual Studio.

This visual studio solution contains a Test project (xUnit). 

## Solution

The request content is validated using [Fluent Validation](https://fluentvalidation.net). If the request is valid, then the class method to validate if the given numbers are multiple of eleven is called (using dependency injection).

## How to use this API

To use this WebAPI, make a Http POST request to the route /multipleofeleven with a JSON content.

### Sample request URL
```
https://localhost:5001/multipleofeleven
```

### Sample Request (JSON Body)
```
{
  "numbers": [ 
		"123959",
		"112233", 
		"30800", 
		"2937", 
		"323455693", 
		"5038297", 
		"112234",
		"1331",
		"14641",
		"24350",
		"-154",
		"-874",
		"00",	
		"22",
		"33",
		"99",
		"1",
		"11",
		"4611686018427387901307445734561825860123058430092136939501844674407370955160",
		"4611686018427387903307445734561825860223058430092136939511844674407370955161",
		"94186565",
		"56568143",
		"90166560",
		"90166561"
	] 
}
```
### Sample Response
```
{
  "result": [
    {
      "number": "123959",
      "isMultiple": true
    },
    {
      "number": "112233",
      "isMultiple": true
    },
    {
      "number": "30800",
      "isMultiple": true
    },
    {
      "number": "2937",
      "isMultiple": true
    },
    {
      "number": "323455693",
      "isMultiple": true
    },
    {
      "number": "5038297",
      "isMultiple": true
    },
    {
      "number": "112234",
      "isMultiple": false
    },
    {
      "number": "1331",
      "isMultiple": true
    },
    {
      "number": "14641",
      "isMultiple": true
    },
    {
      "number": "24350",
      "isMultiple": false
    },
    {
      "number": "-154",
      "isMultiple": true
    },
    {
      "number": "-874",
      "isMultiple": false
    },
    {
      "number": "00",
      "isMultiple": true
    },
    {
      "number": "22",
      "isMultiple": true
    },
    {
      "number": "33",
      "isMultiple": true
    },
    {
      "number": "99",
      "isMultiple": true
    },
    {
      "number": "1",
      "isMultiple": false
    },
    {
      "number": "11",
      "isMultiple": true
    },
    {
      "number": "4611686018427387901307445734561825860123058430092136939501844674407370955160",
      "isMultiple": true
    },
    {
      "number": "4611686018427387903307445734561825860223058430092136939511844674407370955161",
      "isMultiple": false
    },
    {
      "number": "94186565",
      "isMultiple": true
    },
    {
      "number": "56568143",
      "isMultiple": false
    },
    {
      "number": "90166560",
      "isMultiple": true
    },
    {
      "number": "90166561",
      "isMultiple": false
    }
  ]
}
```

## How to run tests

In the test project just right click on MultipleOfElevenTests class and Run Tests.
