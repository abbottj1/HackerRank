import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

import com.sun.org.apache.xml.internal.serializer.ElemDesc;

public class Solution {

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k) {
        int[] tempPrices = new int[prices.length];
        sort(prices, 0, prices.length - 1, tempPrices);

        int maxToys = 0;
        int currentCost = 0;
        while (maxToys < tempPrices.length) {

            if (currentCost + tempPrices[maxToys] <= k) {
                currentCost = currentCost + tempPrices[maxToys];
                maxToys++;
            } else {
                return maxToys;
            }
        }

        return maxToys;
    }

    static void sort(int[] prices, int start, int end, int[] tempPrices) {
        if(start == end) {
            return;
        }

        int pivot = (start + end) / 2;

        sort(prices, start, pivot, tempPrices);
        sort(prices, pivot + 1, end, tempPrices);
        merge(prices, start, pivot, end, tempPrices);
    }

    static void merge(int[] prices, int start, int pivot, int end, int[] tempPrices) {
        int left = start;
        int right = pivot + 1;
        int mergeIndex = start;

        while(left != pivot + 1 || right != end + 1) {
            if(right == end + 1 || (left != pivot + 1 && prices[left] < prices[right])) {
                tempPrices[mergeIndex] = prices[left];
                left++;
            }
            else {
                tempPrices[mergeIndex] = prices[right];
                right++;
            }

            mergeIndex++;
        }

        for(int i = start; i <= end; i++)
        {
            prices[i] = tempPrices[i];
        }
    }

    static void printList(int[] prices) {

        for (int price : prices) {
            System.out.print(price + " ");
        }
        System.out.println();
        System.out.println();
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] nk = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nk[0]);

        int k = Integer.parseInt(nk[1]);

        int[] prices = new int[n];

        String[] pricesItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int pricesItem = Integer.parseInt(pricesItems[i]);
            prices[i] = pricesItem;
        }

        int result = maximumToys(prices, k);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
