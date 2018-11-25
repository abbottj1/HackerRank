import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the abbreviation function below.
    static String abbreviation(String a, String b) {
        Boolean[][] memo= new Boolean[a.length()][b.length()];
        boolean isAbb = abbreviation(a.toCharArray(), b.toCharArray(), 0, 0, memo);
        if(isAbb) {
            return "YES";
        }
        else {
            return "NO";
        }
    }

    static boolean abbreviation(char[] a, char[] b, int aI, int bI, Boolean[][] memo) {
        //Check all of both strings
        if(a.length - aI == 0 && b.length - bI == 0) {
            return true;
        }

        //Reached the end of A but not B
        if (a.length - aI == 0 && b.length - bI > 0)
        {
            return false;
        }
        
        //Reached the end of just B
        if (b.length - bI == 0) {
            while(a.length - aI > 0) {
                if (a[aI] >= 'A' && a[aI] <= 'Z') {
                    return false;
                }

                aI++;
            }

            return true;
        }

        if(memo[aI][bI] != null) {
            return memo[aI][bI];
        }
        
        //Characters are same or 'a' character toUpper is 'b' character
        //check next character in both strings
        if (a[aI] == b[bI] || a[aI] - 32 == b[bI]) {
            memo[aI][bI] = abbreviation(a, b, aI + 1, bI + 1, memo);
            if(memo[aI][bI]) {
                return true;
            }
        }
        
        //'a' character is lower
        //check next 'a' character in string
        if (a[aI] >= 'a' && a[aI] <= 'z'){
            memo[aI][bI] = abbreviation(a, b, aI + 1, bI, memo);
            return memo[aI][bI];
        }
            
        return false;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String a = scanner.nextLine();

            String b = scanner.nextLine();

            String result = abbreviation(a, b);

            bufferedWriter.write(result);
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
