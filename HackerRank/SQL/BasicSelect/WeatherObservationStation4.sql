-- hackerrank.com/challenges/weather-observation-station-4

/*
Enter your query here.
*/
SELECT COUNT(CITY) - COUNT(DISTINCT(CITY)) FROM STATION
