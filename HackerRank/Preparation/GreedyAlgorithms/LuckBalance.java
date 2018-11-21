import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the luckBalance function below.
    static int luckBalance(int k, int[][] contests) {
        ArrayList<Integer> importantContest = new ArrayList<Integer>();
        ArrayList<Integer> unImportantContest = new ArrayList<Integer>();

        for (int i = 0; i < contests.length; i++) {
            if(contests[i][1] == 1)
            {
                importantContest.add(contests[i][0]);
            }
            else
            {
                unImportantContest.add(contests[i][0]);
            }
        }

        int luck = 0;

        if(importantContest.size() > 0)
        {
            // No need to sort of all important contests must be won
            if (k != 0) {
                Collections.sort(importantContest, Collections.reverseOrder());

                // Add the largest important contests to the luck
                for (int i = 0; i < k && i < importantContest.size(); i++) {
                    luck = luck + importantContest.get(i);
                }
            }

            //Subtract the smallest important contests from luck
            for (int i = k; i < importantContest.size(); i++) {
                luck = luck - importantContest.get(i);
            }
        }

        //Add all of the unimportant contest 
        for(int i = 0; i < unImportantContest.size(); i++)
        {
            luck = luck + unImportantContest.get(i);
        }

        return luck;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] nk = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nk[0]);

        int k = Integer.parseInt(nk[1]);

        int[][] contests = new int[n][2];

        for (int i = 0; i < n; i++) {
            String[] contestsRowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < 2; j++) {
                int contestsItem = Integer.parseInt(contestsRowItems[j]);
                contests[i][j] = contestsItem;
            }
        }

        int result = luckBalance(k, contests);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
