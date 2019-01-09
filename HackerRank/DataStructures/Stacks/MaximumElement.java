import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) throws IOException {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
                BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int numberOfQueries = Integer.parseInt(bufferedReader.readLine().replaceAll("\\s+$", ""));

        List<String> queries = new ArrayList<>();

        for (int i = 0; i < numberOfQueries; i++) {
            queries.add(bufferedReader.readLine().replaceAll("\\s+$", ""));
        }

        List<String> result = processQueries(numberOfQueries, queries);

        for (int i = 0; i < result.size(); i++) {
            bufferedWriter.write(result.get(i));

            if (i != result.size() - 1) {
                bufferedWriter.write("\n");
            }
        }

        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }

    public static List<String> processQueries(int numberOfQueries, List<String> queries) {
        Stack<Integer> contentsStack = new Stack<Integer>();
        Stack<Integer> maximumStack = new Stack<Integer>();
        List<String> results = new ArrayList<String>();

        for (int i = 0; i < numberOfQueries; i++) {
            String[] query = queries.get(i).split(" ");

            switch (query[0]) {
                case "1":
                    int value = Integer.parseInt(query[1]);
                    contentsStack.push(value);

                    if(maximumStack.isEmpty() || maximumStack.peek() < value) {
                        maximumStack.push(value);
                    } else {
                        maximumStack.push(maximumStack.peek());
                    }
                    break;
                case "2":
                    contentsStack.pop();
                    maximumStack.pop();
                    break;
                case "3":
                    results.add(String.valueOf(maximumStack.peek()));
                    break;
            }
        }

        return results;
    }
}

