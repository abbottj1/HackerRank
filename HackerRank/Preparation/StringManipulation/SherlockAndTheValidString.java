import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the isValid function below.
    static String isValid(String s) {
        int[] charCount = new int[26];
        for(char c : s.toCharArray()) {
            charCount[c-97] = charCount[c - 97] + 1;
        }

        boolean isOneOut = false;
        int maxCount = -1;

        for(char c = 0; c < 26; c++) {
            int count = charCount[c];
            if (count > 0) {
                System.out.println((char) (c + 97) + " " + charCount[c]);
                if(maxCount == -1) {
                    maxCount = count;
                }
                else {
                    int diff = count - maxCount;

                    if ((diff == 1 || count == 1) && !isOneOut) {
                        isOneOut = true;
                        diff = 0;
                    }

                    if(diff != 0)
                    {
                        return "NO";
                    }
                }
            }
        }

        return "YES";

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String s = scanner.nextLine();

        String result = isValid(s);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
