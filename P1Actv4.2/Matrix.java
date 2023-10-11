public class Matrix {
    int[][] _matrix = {
        {0,2,5,7,6},
        {0,0,0,3,8},
        {2,9,6,3,8},
        {1,5,6,1,4},
        {0,9,2,5,0}
    };

    public void contarCeros() {
        int ceros = 0;
        for (int i = 0; i < _matrix.length; i++) {
            for (int j = 0; j < _matrix[0].length; j++) {
                if(_matrix[i][j] == 0) ceros++;
            }
            System.out.println("# de Ceros en Fila " + i + ": " + ceros);
            ceros = 0;
        }
    }
}
