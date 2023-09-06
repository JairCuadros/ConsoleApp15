Console.WriteLine("Ingresar edad del ganador: ");
string edadTexto = Console.ReadLine();
Console.WriteLine("Ingresar cantidad de adivinanzas acertadas: ");
string adivinanzasAcertadas = Console.ReadLine();
float adivinzas = float.Parse(adivinanzasAcertadas);
float edad = float.Parse(edadTexto);
float montoInicial = 0f;
switch (edad >= 18)
{
    case true:
        switch (adivinzas)
        {
            case < 3:
                montoInicial = 30;
                break;
            default:
                montoInicial = 50;
                break;
        }
        break;
    default:
        switch (adivinzas)
        {
            case < 3:
                montoInicial = 50;
                break;
            default:
                montoInicial = 80;
                break;
        }
        break;
}
double montoExtra = (edad * 5.00) + (adivinzas * 2.00);
double montoFinal = montoInicial + montoExtra;
Console.WriteLine("El monto total recibido es de: S/. " + montoFinal);