--https://www.hackerrank.com/challenges/the-pads/problem

/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

SELECT Name + '(' + SUBSTRING(Occupation,1,1) + ')'
FROM Occupations 
ORDER BY Name

SELECT 'There are a total of ' + STR(COUNT(*)) + ' ' + LOWER(Occupation) + 's.'  
FROM Occupations 
GROUP BY Occupation 
ORDER BY COUNT(*)
