public class Fibonacci {
    int y = 0;
    int z = 1;

    public int calcularFibonacci(int x) {
        int auxiliar = y;
        if (x == 0) {
            return 1;
        }
        System.out.println(y + z);
        y = y + z;
        z = auxiliar;
        return calcularFibonacci(x - 1);
    }
}
