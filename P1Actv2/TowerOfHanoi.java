public class TowerOfHanoi {
    
    public TowerOfHanoi(int numDisk){
        int _numDisks = numDisk; //Cambiar como sea necesario
        char deDonde = 'A';
        char auxiliar = 'B';
        char destino = 'C';
        System.out.println("Torre de Hanoi usando " + _numDisks + " discos:");
        towerOfHanoi(_numDisks, deDonde, auxiliar, destino);
    }

    public void towerOfHanoi(int n, char deDonde, char auxiliar, char destino) {
        if (n == 1) {
            System.out.println("Disco #1 se mueve desde " + deDonde + " hacia " + destino);
            return;
        }

        towerOfHanoi(n - 1, deDonde, destino, auxiliar);
        System.out.println("Disco #" + n + " se mueve desde " + deDonde + " hacia " + destino);
        towerOfHanoi(n - 1, auxiliar, deDonde, destino);
    }
}