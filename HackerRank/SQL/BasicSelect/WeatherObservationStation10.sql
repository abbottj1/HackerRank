--https://www.hackerrank.com/challenges/weather-observation-station-10

/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT DISTINCT(CITY)
FROM STATION
WHERE UPPER(RIGHT(CITY, 1)) NOT IN ('A','E','I','O','U')
