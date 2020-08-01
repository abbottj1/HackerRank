--https://www.hackerrank.com/challenges/more-than-75-marks

/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT Name
FROM Students
WHERE Marks > 75
ORDER BY RIGHT(Name,3), ID
