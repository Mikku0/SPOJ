import java.util.Scanner;

// task: https://pl.spoj.com/problems/FCTRL3/

public class FCTRL3 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int D = sc.nextInt();

        for (int i = 0; i < D; i++) {
            int n = sc.nextInt();
            String result = what(n);
            System.out.println(result);
        }
    }

    public static String what(int n) {
        if (n > 9) {
            return "0 0";
        }
        switch(n){
            case 0:
                return "0 1";
            case 1:
                return "0 1";
            case 2:
                return "0 2";
            case 3:
                return "0 6";
            case 4:
                return "2 4";
            case 5:
                return "2 0";
            case 6:
                return "2 0";
            case 7:
                return "4 0";
            case 8:
                return "2 0";
            case 9:
                return "8 0";
        }
        return null;
    }
}
