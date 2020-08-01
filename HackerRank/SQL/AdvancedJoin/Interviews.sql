--https://www.hackerrank.com/challenges/interviews/problem

/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/

DECLARE @Subs AS TABLE (contest_id INT, total_submissions INT ,total_accepted_submissions INT)
INSERT INTO @Subs (contest_id, total_submissions, total_accepted_submissions)
SELECT CON.contest_id, 
       Sum(SS.total_submissions), 
       Sum(SS.total_accepted_submissions)
FROM   contests CON 
       JOIN colleges COL 
         ON CON.contest_id = COL.contest_id 
       JOIN challenges CHA 
         ON COL.college_id = CHA.college_id 
       JOIN submission_stats SS 
         ON CHA.challenge_id = SS.challenge_id 
GROUP  BY CON.contest_id
ORDER  BY CON.contest_id 

DECLARE @Views AS TABLE (contest_id INT, total_views INT ,total_unique_views INT)
INSERT INTO @Views (contest_id, total_views, total_unique_views)
SELECT CON.contest_id, 
       Sum(VS.total_views), 
       Sum(VS.total_unique_views)
FROM   contests CON 
       JOIN colleges COL 
         ON CON.contest_id = COL.contest_id 
       JOIN challenges CHA 
         ON COL.college_id = CHA.college_id 
       JOIN view_stats VS 
         ON CHA.challenge_id = VS.challenge_id
GROUP  BY CON.contest_id
ORDER  BY CON.contest_id 

SELECT CON.contest_id, 
       CON.hacker_id, 
       CON.Name, 
       SS.total_submissions, 
       SS.total_accepted_submissions,
       VS.total_views, 
       VS.total_unique_views
FROM   contests CON 
       JOIN @Views VS 
         ON CON.contest_id = VS.contest_id
       JOIN @Subs SS 
         ON CON.contest_id = SS.contest_id 
ORDER  BY CON.contest_id 
