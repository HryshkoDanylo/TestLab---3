Feature: HTTPCat API Testing
    Scenario: Test HTTPCat API for Different Status Codes
        Given the HTTPCat API endpoint is "https://http.cat"
        When I make a GET request for status code <statusCode>
        Then the response status code should be OK
        Examples:
        | statusCode |
        | 101        |
        | 305        |
        | 404        |


    Scenario: Test HTTPCat API for Not Existing Status Codes
        Given the HTTPCat API endpoint is "https://http.cat"
        When I make a GET request for status code <statusCode>
        Then the response status code should be NOT FOUND
        Examples:
        | statusCode |
        | 666       |
        | 7777      |