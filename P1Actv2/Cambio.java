public class Cambio {
    int contador = 0;
    final String[] denominaciones = {
    "$100 PESOS",
    "$50 PESOS",
    "$20 PESOS",
    "$10 PESOS",
    "$5 PESOS",
    "$1 PESO",
    "¢50 CENTAVOS",
    "¢20 CENTAVOS",
    "¢1 CENTAVO",
    };
    final int[] divisiones = {
    10000,
    5000,
    2000,
    1000,
    500,
    100,
    50,
    20,
    1
    };
    int[] cantidadMonedas = new int[12]; //Quiero suponer que por default se ponen 0 en vez de quedar con valores NULL
    
    public void CalcularCambio(float cantidad){
        cantidad *= 100;
        CalcularCambio((int) cantidad);
    }
    public void CalcularCambio(int cantidad){
        if(cantidad == 0){
            return;
        }
        int enteros = (cantidad/divisiones[contador]);
        int sobrante = cantidad%divisiones[contador];

        cantidadMonedas[contador] += enteros;
        if (enteros != 0) {
            System.out.print(Program.COLOR_CYAN);
        }else{
            System.out.print(Program.COLOR_ROJO);

        }
        System.out.println(denominaciones[contador] + ": " + cantidadMonedas[contador]);
        contador++;
        CalcularCambio(sobrante);
    }

}