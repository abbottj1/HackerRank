import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the largestRectangle function below.
    static long largestRectangle(int[] h) {
        Stack<Integer> heightStack = new Stack<Integer>();
        Stack<Integer> posStack = new Stack<Integer>();

        int max = 0;

        for(int i = 0; i < h.length; i++) {
            if(heightStack.isEmpty() || h[i] > heightStack.peek()) {
                heightStack.push(h[i]);
                posStack.push(i);
            } else if(h[i] < heightStack.peek()) {
                int tempPos = -1;
                while(!heightStack.isEmpty() && h[i] < heightStack.peek())
                {   
                    tempPos = posStack.pop();
                    max = Math.max(heightStack.pop() * (i - tempPos), max);
                }

                heightStack.push(h[i]);
                posStack.push(tempPos);
            }
        }

        while (!heightStack.isEmpty()) {
            max = Math.max(heightStack.pop() * (h.length - posStack.pop()), max);
        }

        return max;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[] h = new int[n];

        String[] hItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int hItem = Integer.parseInt(hItems[i]);
            h[i] = hItem;
        }

        long result = largestRectangle(h);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
