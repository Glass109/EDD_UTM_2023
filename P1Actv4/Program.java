import java.util.Arrays;

public class Program {

    public static void main(String[] args) {
        int[][] _matrix = Matrix.crearMatrix(); //Obtener un Array de lo escrito por el usuario
        _matrix = Matrix.rellenar(_matrix);
        System.out.println(Arrays.deepToString(_matrix));
    }

}