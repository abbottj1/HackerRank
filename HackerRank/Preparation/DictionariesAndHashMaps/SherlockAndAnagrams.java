import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(String s) {
        HashMap<HashMap<Character, Integer>, Integer> anagramMap = new HashMap<HashMap<Character, Integer>, Integer>();

        char[] sChars = s.toCharArray();
        for (int len = 1; len <= s.length(); len++) {
            for (int i = 0; i <= s.length() - len; i++) {
                HashMap<Character, Integer> characterMap = new HashMap<Character, Integer>();
                int j = i + len - 1;
                for (int k = i; k <= j; k++) {
                    char sChar = sChars[k];

                    if (characterMap.containsKey(sChar)) {
                        characterMap.put(sChar, characterMap.get(sChar) + 1);
                    } else {
                        characterMap.put(sChar, 1);
                    }
                }

                if (anagramMap.containsKey(characterMap)) {
                    anagramMap.put(characterMap, anagramMap.get(characterMap) + 1);
                } else {
                    anagramMap.put(characterMap, 1);
                }
            }
        }

        int result = 0;
        for (Map.Entry<HashMap<Character, Integer>, Integer> entry : anagramMap.entrySet()) {
            int freq = entry.getValue();
            result += ((freq) * (freq - 1))/2;
        }

        return result;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int q = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int qItr = 0; qItr < q; qItr++) {
            String s = scanner.nextLine();

            int result = sherlockAndAnagrams(s);

            bufferedWriter.write(String.valueOf(result));
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
