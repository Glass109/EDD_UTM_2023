public class Potencia {
    int _n1, _n2, og;

    public Potencia(int n1, int n2) {
        _n1 = n1;
        _n2 = n2;
        og = _n1;
    }

    public int Calculo() {
        if (_n2 == 1) {
            return _n1;
        }
        _n1 = _n1 * og;
        _n2--;
        return Calculo();
    }
}
