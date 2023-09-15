public class Factorial {
    public int Calculo(int x) {
        if (x == 0 || x == 1) {
            return 1;
        }
        return x * Calculo(x - 1);
    }
}
