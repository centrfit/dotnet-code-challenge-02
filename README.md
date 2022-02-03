# .NET Coding Challenge

This coding challenge is for a .NET developer that we assume is familiar with building .NET / .NET Core REST APIs. There is no strict time limit on this code challenge but it shouldn't take you more than two hours to complete.

Your task is to:

1. Build an API that manages recipes using the provided Api project shell
2. Write accompanying unit test(s) for the POST recipe endpoint

## Specification

### **Recipes**

#### URL Formats

#### POST

/api/recipes

#### GET

```
/api/recipes
/api/recipes/{id}
```

#### DELETE
```
/api/recipes/{id}
```

#### PUT
```
/api/recipes/{id}
```

#### PATCH
```
/api/recipes/{id}
```

#### Fields

| Field Name  | Data Type   | Required    | Validation     |
| ----------- | ----------- | ----------- | -----------    |
| ContentId   | `int`       | Yes         | > 0            |
| Name        | `string`    | Yes         | max length 128 |
| Summary     | `string`    | No          | max length 256 |
| ServingSize | `int`       | Yes         | > 0            |
| Calories    | `double`    | Yes         | >= 0           |

- Name should not allow null

## Requirements

- Your API project MUST compile and run, producing valid swagger
- Your unit test project MUST compile and run, demonstating appropriate mock behaviour
- Your patch endpoint need only demonstrate a simple replace operation 

## How will my code challenge be assessed?

Take some time to study the challenge notes and familiarise yourself with the available projects and keep in mind general design best practices and acronyms such as SOLID, KISS, DRY etc. as you approach this exercise.

You will be assesed on the overall production quality of your work and we will look at the commit log history to understand how you progressed through the challenge.

## How do I submit my code challenge?

Clone this repository and once you have completed the task, push it to a public repository and notify your recruiter with the link once it is ready for review.

