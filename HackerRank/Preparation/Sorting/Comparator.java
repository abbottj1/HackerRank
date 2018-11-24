import java.util.*;

class Player {
	String name;
	int score;

	Player(String name, int score) {
		this.name = name;
		this.score = score;
	}
}

class Checker implements Comparator<Player> {
  	// complete this method
	public int compare(Player a, Player b) {
        if(a.score != b.score) {
            return b.score - a.score;
        }

        int lenA = a.name.length();
        int lenB = b.name.length();

        char[] aChars = a.name.toCharArray();
        char[] bChars = b.name.toCharArray();

        int limit = Math.min(lenA, lenB);

        int i = 0;

        while(i < limit) {
            if(aChars[i] != bChars[i]) {
                return aChars[i] - bChars[i];
            }

            i++;
        }

        return lenA - lenB;
    }
}


public class Solution {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();

        Player[] player = new Player[n];
        Checker checker = new Checker();
        
        for(int i = 0; i < n; i++){
            player[i] = new Player(scan.next(), scan.nextInt());
        }
        scan.close();

        Arrays.sort(player, checker);
        for(int i = 0; i < player.length; i++){
            System.out.printf("%s %s\n", player[i].name, player[i].score);
        }
    }
}
